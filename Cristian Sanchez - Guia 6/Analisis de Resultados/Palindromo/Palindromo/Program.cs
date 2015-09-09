using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase; //string que contendra la frase digitada por el usuario
            Stack mipila = new Stack(); //Pila que contendra la frase por partes
            int contadorPalabrasIguales = 0; //contador que contara la cantidad de palabras iguales
            string valor;

            Console.WriteLine("Digite una frase: "); //Le indico que necesito que digite una frase
            frase = Console.ReadLine(); //Guardo la frase en la variable "frase"

            for (int i = 0; i < frase.Length; i++) //para i = 0 hasta que i sea menor al tamaño de la frase
            {
                mipila.Push(frase.Substring(i,1)); //Enviar a la pila una subcadena de la frase
            }
            for (int i = 0; i < frase.Length; i++)
            {
                valor = mipila.Pop().ToString();
                if (valor == frase.Substring(i,1))
                {
                    contadorPalabrasIguales++;
                }
            }
            if (contadorPalabrasIguales == frase.Length)
            {
                Console.WriteLine("La frase es palindromo");
            }
            else
            {
                Console.WriteLine("La frase no es palindromo");
            }
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
