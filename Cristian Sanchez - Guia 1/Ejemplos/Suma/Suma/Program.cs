using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int suma;

            Console.WriteLine("Ingrese el primer numero a sumar");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero a sumar");
            b = int.Parse(Console.ReadLine());

            suma = a + b;

            Console.WriteLine("La suma es: {0}", suma);
            Console.ReadKey();
        }
    }
}
