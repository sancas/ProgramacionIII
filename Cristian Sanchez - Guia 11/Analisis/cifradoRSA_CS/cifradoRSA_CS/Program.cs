using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
namespace cifradoRSA_CS
{
    class Program
    {
        private static string dirPruebas = AppDomain.CurrentDomain.BaseDirectory + "../../../../";
        private static string ficPruebas = Path.Combine(dirPruebas, "MisClaves_CS.xml");
        static void Main()
        {
            // Cifrar y descifrar con RSA
            Console.Title = "Cifrar y descifrar con RSA";
            // Si no existe el fichero de claves
            if (File.Exists(ficPruebas) == false)
            {
                crearXMLclaves(ficPruebas);
            }
            string xmlKeys = clavesXML(ficPruebas);
            byte[] datos = cifrar("Hola RSA C#", xmlKeys);
            string res = descifrar(datos, xmlKeys);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        private static void crearXMLclaves(string ficPruebas)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string xmlKey = rsa.ToXmlString(true);
            // Si no existe el directorio, crearlo
            string dirPruebas = Path.GetDirectoryName(ficPruebas);
            if (Directory.Exists(dirPruebas) == false)
            {
                Directory.CreateDirectory(dirPruebas);
            }
            using (StreamWriter sw = new StreamWriter(ficPruebas, false, Encoding.UTF8))
            {
                sw.WriteLine(xmlKey);
                sw.Close();
            }
        }
        private static string clavesXML(string fichero)
        {
            string s;
            using (StreamReader sr = new StreamReader(fichero, Encoding.UTF8))
            {
                s = sr.ReadToEnd();
                sr.Close();
            }
            return s;
        }
        private static byte[] cifrar(string texto, string xmlKeys)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(xmlKeys);
            byte[] datosEnc = rsa.Encrypt(Encoding.Default.GetBytes(texto), false);
            return datosEnc;
        }
        private static string descifrar(byte[] datosEnc, string xmlKeys)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(xmlKeys);
            byte[] datos = rsa.Decrypt(datosEnc, false);
            string res = Encoding.Default.GetString(datos);
            return res;
        }
    }
}