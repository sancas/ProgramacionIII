using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparacionApellidos
{
    class Program
    {
        static void Main(string[] args)
        {
            string apellidoa, apellidob;
            Console.WriteLine("Ingrese un apellido");
            apellidoa = Console.ReadLine();
            Console.WriteLine("Ingrese otro apellido");
            apellidob = Console.ReadLine();
            if (String.Compare(apellidoa, apellidob) == 0)
                Console.WriteLine("Los apellidos son iguales");
            else
                Console.WriteLine("Los apellidos son diferentes");
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
