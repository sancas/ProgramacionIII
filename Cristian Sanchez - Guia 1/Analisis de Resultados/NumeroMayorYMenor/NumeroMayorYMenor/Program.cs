using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMayorYMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            double a; //Numero 1
            double b; //Numero 2
            double c; //Numero 3
            double mayor = 0; //Numero mayor
            double menor = 0; //Numero menor

            //Mensaje de bienvenida
            Console.WriteLine("Pide 3 numeros y determina cual es el menor y el mayor");
            //Ingreso de datos
            Console.WriteLine("Ingrese el 1er numero");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 2do numero");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 3er numero");
            c = Double.Parse(Console.ReadLine());

            //Procedimiento para determinar cual es mayor
            if (a >= b && a >= c)
                mayor = a;
            if (b >= a && b >= c)
                mayor = b;
            if (c >= a && c >= b)
                mayor = c;
            //Procedimiento para determinar cual es menor
            if (a <= b && a <= c)
                menor = a;
            if (b <= a && b <= c)
                menor = b;
            if (c <= a && c <= b)
                menor = c;

            //Mostrar mensajes
            Console.WriteLine("Numero mayor: {0}", mayor);
            Console.WriteLine("Numero menor: {0}", menor);
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
