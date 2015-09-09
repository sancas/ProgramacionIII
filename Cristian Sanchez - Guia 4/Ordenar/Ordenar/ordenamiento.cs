using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ordenar
{
    class ordenamiento
    {
        StreamReader sr; //lector de archivos
        StreamWriter sw; //escritor de archivos

        bool abierto1 = false;
        bool abierto2 = false;
        string nombrearchivo2;
        Stopwatch temporizador;
        double time = 0;

        public ordenamiento(string filename) //O(1)
        {
            temporizador = Stopwatch.StartNew();
            try
            {
                //si el nombre del archivo dado existe
                //abre el archivo en modo lectura con sr SteamReader
                sr = new StreamReader(filename);
                abierto1 = true;
            }
            catch (Exception e)
            {
                //si no encuentra el archivo
                Console.WriteLine("Error en la apertura de \"{0}\": {1}", filename, e.ToString());
            }
            if (abierto1)
            {
                //transforma "nombre.txt" en "nombre.salida.txt"
                nombrearchivo2 = filename.Insert(filename.IndexOf('.'), "salida");
            }
            try
            {
                //abre el archivo2 en modo escritura con sw y StreamWriter
                sw = new StreamWriter(nombrearchivo2);
                abierto2 = true;
                temporizador.Stop();
                time += temporizador.Elapsed.TotalMilliseconds;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la apertura de \"{0}\": {1}", nombrearchivo2, e.ToString());
            }
        }
        //funcion ordenamiento por insercion
        public int[] Insercion(int[] x) //n*n/2= O(n^2)
        {
            temporizador.Restart();
            int longitud = x.Length;
            int auxili;
            int j;
            for (int i = 0; i < x.Length; i++)
            {
                auxili = x[i];
                j = i - 1;
                while (j >= 0 && x[j] > auxili)
                {
                    x[j + 1] = x[j];
                    j--;
                }
                x[j + 1] = auxili;
            }
            temporizador.Stop();
            time += temporizador.Elapsed.TotalMilliseconds;
            return x;
        }

        //funcion procesar
        public void procesar() //O(n) + O(n) + O(n^2) = O(n(2+n))
        {
            temporizador.Restart();
            string linea;
            ArrayList Arreglo = new ArrayList();
            if (!abierto1 || !abierto2) return;
            Console.WriteLine("Procesando");
            linea = sr.ReadLine();
            char[] Caracteres = { ' ', '\t' };
            string[] words = linea.Split(Caracteres);
            foreach (string s in words) //O(n)
            {
                Arreglo.Add(Convert.ToInt32(s));
            }
            int[] Numeros = (int[])Arreglo.ToArray(typeof(int));
            temporizador.Stop();
            Insercion(Numeros); //O(n^2)
            temporizador.Start();
            //imprime el tiempo transcurrido
            for (int i = 0; i < Insercion(Numeros).Length; i++) //O(n)
                sw.WriteLine("" + Insercion(Numeros)[i]);
            sr.Close(); abierto1 = false;
            sw.Close(); abierto2 = false;
            Console.WriteLine("Listo Archivo de salida creado");
            temporizador.Stop();
            time += temporizador.Elapsed.TotalMilliseconds;
            Console.Write("El tiempo transcurrido fue de: {0} Milisegundos", time.ToString());
        }
    }
}
