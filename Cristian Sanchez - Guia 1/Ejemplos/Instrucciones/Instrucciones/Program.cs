using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrucciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int i;

            Console.WriteLine("**********Ejemplo de IF**********");
            Console.WriteLine("-Pide dos numeros enteros y los compara");

            Console.WriteLine("Ingrese el primer numero entero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero entero");
            b = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine("A,{0} es mayor que B,{1}", a, b);
            }
            else
            {
                Console.WriteLine("B,{1} es mayor que A,{0}", a, b);
            }
            Console.ReadKey();

            Console.WriteLine("**********Ejemplo de FOR**********");
            Console.WriteLine("Imprime numeros de 1 hasta 10");
            for (i = 1; i < 11; i++)
                Console.WriteLine(i);
            Console.ReadKey();

            Console.WriteLine("**********Ejemplo de WHILE**********");
            Console.WriteLine("Imprime numeros de 1 hasta 10");
            i = 1;
            while (i < 11)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
