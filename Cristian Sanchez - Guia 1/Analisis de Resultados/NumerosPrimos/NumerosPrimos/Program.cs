using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad; //Cantidad de numeros primos a generar
            int contador = 0; //Contador de divisiones para calcular numeros primos
            int contadorPrimos = 0; //Contador de numeros primos impresos

            Console.WriteLine("Digite la cantidad de numeros primos que desea: "); //Le indico que deseo la cantidad de primos que desea
            cantidad = int.Parse(Console.ReadLine()); //Guarda el dato que el ingreso

            for (int i = 2; i == i; i++) //Comienzo un ciclo repetitivo infinito
            {
                for (int j = 1; j <= i; j++) //Comienzo un ciclo for para comparar con los numeros anteriores
                {
                    if (i % j == 0) //Si i es divisible perfectamente entre j 
                    {
                        contador = contador + 1; //Sumar 1 al contador
                    }
                }
                if (contador < 3) //Si el contador es menos que 3 o sea que si es primo
                {
                    contadorPrimos = contadorPrimos + 1; //Sumo 1 al contador de primos impresos
                    if (contadorPrimos == cantidad) //Si ya se alcanzo la cantidad deseada
                        Console.Write(i); //Imprimo el numero solamente
                    else //Sino
                        Console.Write(i + ", "); //Imprimo el numero seguido de una coma para mejor entendimiento
                }
                contador = 0; //Reinicio el contador para volver a probar con otro numero
                if (contadorPrimos == cantidad) //Si ya se alcanzo la cantidad de numeros primos deseados
                    break; //Salgo del ciclo infinito
            }
            Console.ReadKey(); //Espero que el usuario presione una tecla

        }
    }
}
