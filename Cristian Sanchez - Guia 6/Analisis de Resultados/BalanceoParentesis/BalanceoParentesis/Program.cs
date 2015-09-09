using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceoParentesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string ecuacion; //Variable que contendra la ecuacion
            Stack mipila = new Stack(); //Pila que almacenara los parentesis
            int contadorParentesis = 0; //Variable que contara el numero de parentesis en la ecuacion
            char caracter; //Variable que contendra el caracter a operar

            Console.WriteLine("Escriba una ecuacion: "); //Le informo al usuario que necesito una ecuacion
            ecuacion = Console.ReadLine(); //Guardo esa ecuacion en la variable "ecuacion"

            for (int i = 0; i < ecuacion.Length; i++) //Para i=0 mientras i sea menos que el tamaño de ecuacion e i aumentara de 1 en 1
            {
                caracter = char.Parse(ecuacion[i].ToString()); //Guardo el caracter en la variable caracter
                mipila.Push(caracter); //Envio el caracter a la pila
            }
            foreach (char var in mipila) //Por cada string en mipila hacer
            {
                if (var.ToString() == "(" || var.ToString() == ")") //Si el valor es un parentesis
                {
                    contadorParentesis++; //Aumentar el contador
                }
            }
            if (contadorParentesis % 2 != 0) //Si el modulo 2 del contador es diferentes de 0
            {
                Console.WriteLine("La ecuacion esta desbalanceada");
            }
            else
            {
                Console.WriteLine("La ecuacion esta balanceada");
            }
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
