using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiProgramaSelectivo
{
    class Program
    {
        static void SumarFunction()
        {
            int a, b, suma;
            Console.WriteLine("Digite el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = int.Parse(Console.ReadLine());
            suma = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, suma);
        }

        static void RestarFunction()
        {
            int a, b, resta;
            Console.WriteLine("Digite el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = int.Parse(Console.ReadLine());
            resta = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, resta);
        }

        static void DividirFunction()
        {
            int a, b;
            double division;
            Console.WriteLine("Digite el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = int.Parse(Console.ReadLine());
            division = a / b;
            Console.WriteLine("{0} / {1} = {2}", a, b, division);
        }

        static void MultiplicarFunction()
        {
            int a, b;
            double multiplicacion;
            Console.WriteLine("Digite el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = int.Parse(Console.ReadLine());
            multiplicacion = a * b;
            Console.WriteLine("{0} * {1} = {2}", a, b, multiplicacion);
        }


        static void Main(string[] args)
        {
            char chOpt;

            Console.WriteLine("1-Sumar");
            Console.WriteLine("2-Restar");
            Console.WriteLine("3-Dividir");
            Console.WriteLine("4-Multiplicar");
            Console.Write("Seleccione  entre [1] a [4]:");

            //Verifica que los valores de entradas esten entre 1 e 4
            //caso contrario pide los números nuevamente
            do
            {

                chOpt = char.Parse(Console.ReadLine());
                

            } while (chOpt < '1' || chOpt > '4');

            switch (chOpt)
            {
                case '1':
                    Console.WriteLine("Inserir...");
                    SumarFunction();
                    break;
                case '2':
                    Console.WriteLine("Atualizar...");
                    RestarFunction();
                    break;
                case '3':
                    Console.WriteLine("Apagar...");
                    DividirFunction();
                    break;
                case '4':
                    MultiplicarFunction();
                    break;
                default:
                    Console.WriteLine("Procurar...");
                    break;
            }
            Console.Write("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
