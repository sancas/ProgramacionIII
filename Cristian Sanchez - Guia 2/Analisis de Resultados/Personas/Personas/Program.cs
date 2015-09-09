using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombrea, nombreb;
            string apellidoa, apellidob;
            int edada, edadb;
            Console.WriteLine("Ingrese el nombre de la primera persona");
            nombrea = Console.ReadLine();
            Console.WriteLine("Ingrese el apellio de la primera persona");
            apellidoa = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la primera persona");
            edada = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre de la segunda persona");
            nombreb = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido de la segunda persona");
            apellidob = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la segunda persona");
            edadb = int.Parse(Console.ReadLine());
            if (edada > edadb)
                Console.WriteLine("{0} es mayor que {1}", nombrea, nombreb);
            else if (edadb > edada)
                Console.WriteLine("{0} es mayor que {1}", nombreb, nombrea);
            else
                Console.WriteLine("Ambos tienen la misma edad");
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
