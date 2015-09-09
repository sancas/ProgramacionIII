using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nombre del archivo
            String nombre;
            Console.Write("Nombre del archivo.txt");
            //Lee el nombre del archivo
            nombre = Console.ReadLine();
            ordenamiento c = new ordenamiento(nombre);
            c.procesar();
            Console.ReadLine(); 
        }
    }
}
