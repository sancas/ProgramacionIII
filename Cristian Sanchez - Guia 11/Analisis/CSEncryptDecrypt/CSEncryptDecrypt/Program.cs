using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text;
namespace CSEncryptDecrypt
{
    class Class1
    { 
        // Llamar a esta función para quitar la clave de la memoria después de su uso por seguridad
        [System.Runtime.InteropServices.DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);
        // Función para generar una clave de 64 bits.
        static string GenerateKey()
        { 
            // Crear una instancia del algoritmo simétrico. La clave y el IV generan automáticamente.
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            // Utilizar la clave generada automáticamente para el cifrado.
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }
        static void EncryptFile(string sInputFilename, string sOutputFilename, string sKey)
        {
            FileStream fsInput = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            FileStream fsEncrypted = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);
            byte[] bytearrayinput = new byte[fsInput.Length];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsInput.Close();
            fsEncrypted.Close();
        }
        static void DecryptFile(string sInputFilename, string sOutputFilename, string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            //Se necesita una clave de 64 bits y un IV para este proveedor.
            //Establecer la clave secreta para el algoritmo DES.
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            //Establecer el vector de inicialización.
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            //Crear una secuencia de archivo para volver a leer el archivo cifrado.
            FileStream fsread = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            //Crear un descriptor de DES desde la instancia de DES.
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            //Crear una secuencia de cifrado para leer y realizar una transformación de
            //cifrado DES en los bytes de entrada.
            CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read);
            //Imprimir el contenido del archivo descifrado.
            StreamWriter fsDecrypted = new StreamWriter(sOutputFilename);
            fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
            fsDecrypted.Flush();
            fsDecrypted.Close();
        }
        static void Main()
        { // Debe ser 64 bits, 8 bytes.
            // Distribuir esta clave al usuario que descifrará este archivo.
            string sSecretKey;
            // Obtener la clave para que el archivo se cifre.
            sSecretKey = GenerateKey();
            // Para mayor seguridad, fijar la clave.
            GCHandle gch = GCHandle.Alloc(sSecretKey, GCHandleType.Pinned);
            // Cifrar el archivo…
            EncryptFile(AppDomain.CurrentDomain.BaseDirectory + "../../../../MyData.txt", AppDomain.CurrentDomain.BaseDirectory + "../../../../Encrypted.txt", sSecretKey);
            // Descifrar el archivo.
            DecryptFile(AppDomain.CurrentDomain.BaseDirectory + "../../../../Encrypted.txt", AppDomain.CurrentDomain.BaseDirectory + "../../../../Decrypted.txt", sSecretKey);
            // Quitar la clave de la memoria.
            ZeroMemory(gch.AddrOfPinnedObject(), sSecretKey.Length * 2);
            gch.Free();
        }
    }
}