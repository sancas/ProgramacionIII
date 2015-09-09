using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            Stack mipila = new Stack();
            //ingreso de elementos a la pila
            mipila.Push("z");
            mipila.Push("ba");
            mipila.Push("nom");
            //imprimir elementos de la pila pueden ser de tipo char, int, string o
            //cualquier otro tipo ya que es un tipo object dependera de lo que el
            //usuario necesite
            foreach (string var in mipila)
            {
                Console.WriteLine(var);
            }
            Console.WriteLine("\n\n");
            //Peek RETORNA el valor que esta al tope de la pila sin eliminarlo
            Console.WriteLine("El tope de la pila es");
            Console.WriteLine(mipila.Peek());
            //retorna el valor del tope eliminandolo
            valor = mipila.Pop().ToString();
            Console.WriteLine("eliminado de la pila: " + valor);
            Console.WriteLine("\n\n");
            //mostrando contenido de la pila
            foreach (string var in mipila)
            {
                Console.WriteLine(var);
            }
            Console.ReadLine();
        }
    }
}
