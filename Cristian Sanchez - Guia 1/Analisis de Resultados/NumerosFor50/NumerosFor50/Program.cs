using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosFor50
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear programa que imprima los numeros del 1 al 50 excepto el 25
            int i = 0;

            for (i = 1; i <= 50; i++)
            {
                if (i == 25) continue;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
