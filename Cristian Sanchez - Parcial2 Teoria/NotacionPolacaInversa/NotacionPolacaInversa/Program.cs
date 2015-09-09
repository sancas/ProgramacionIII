using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotacionPolacaInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack(); //Pila para almacenar los datos
            string valor; //Cadena para almacenar el dato a enviar a la pila
            float val1;

            Console.Write("Introduce una expresión en notación postfija para hallar el resultado.\n");
            Console.Write("Introduzca un valor o operador y pulse intro para introducir el siguiente, escriba = para calcular el resultado\n");
            Console.Write("  Ejemplo:\n\n   5\n   9\n   +\n   2\n   *\n   6\n   5\n   *\n   +\n");
            Console.Write("Indique la expresion:\n\n");

            do
            {
                valor = Console.ReadLine();
                switch (valor[0])
                {
                    case '+':
                        val1 = float.Parse(pila.Pop().ToString());
                        pila.Push(val1 + float.Parse(pila.Pop().ToString()));
                        break;
                    case '-':
                        val1 = float.Parse(pila.Pop().ToString());
                        pila.Push(val1 - float.Parse(pila.Pop().ToString()));
                        break;
                    case '*':
                        val1 = float.Parse(pila.Pop().ToString());
                        pila.Push(val1 * float.Parse(pila.Pop().ToString()));
                        break;
                    case '/':
                        val1 = float.Parse(pila.Pop().ToString());
                        pila.Push(val1 / float.Parse(pila.Pop().ToString()));
                        break;
                    case '=':
                        Console.WriteLine("El resultado es: {0}", pila.Pop().ToString());
                        break;
                    default:
                        pila.Push(valor);
                        break;
                }
            } while (valor[0] != '=');
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
