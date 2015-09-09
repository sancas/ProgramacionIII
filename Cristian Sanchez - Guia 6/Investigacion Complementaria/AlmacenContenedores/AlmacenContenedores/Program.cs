using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenContenedores
{
    class Program
    {
        private static int numeroContenedores; //int que contendra el numero de contenedores que hay

        static void Main(string[] args)
        {
            Stack contenedores = new Stack(); //Pila de contenedores
            int opcionMenu; //int para el menu
            int retirarContenedorNumero; //Numero del contenedor que se retirara

            Console.WriteLine("Digite el numero de contenedores que desea: "); //Le hacemos saber lo que necesitamos
            numeroContenedores = int.Parse(Console.ReadLine()); //Guardamos el numero de contenedores

            for (int i = 1; i <= numeroContenedores; i++) //Para i = 1 hasta que i sea menor o igual al numero de contenedores
            {
                contenedores.Push(i); //Enviar a la pila el valor de i
            }
            do
            {
                Console.Clear();
                Console.WriteLine("1. Mostrar contenedores"); //Opcion 1 del menu
                Console.WriteLine("2. Retirar un contenedor"); //Opcion 2 del menu
                Console.WriteLine("3. Salir"); //Opcion 3 del menu
                Console.WriteLine("Seleccione una opcion: "); //Pedimos seleccionar una opcion
                opcionMenu = int.Parse(Console.ReadLine()); //Guardamos la opcion
                if (opcionMenu == 1)
                {
                    imprimirContenedores(contenedores);
                    Console.ReadKey(); //Esperamos para continuar
                }
                else if (opcionMenu == 2)
                {
                    Console.WriteLine("Digite el numero de contenedor a retirar: "); //Solicitamos el numero de contenedor a retirar
                    retirarContenedorNumero = int.Parse(Console.ReadLine()); //Guardamos el dato
                    contenedores = retirarContenedor(contenedores, retirarContenedorNumero); //Llamamos al metodo para retirar contenedores
                    imprimirContenedores(contenedores); //Imprimimos el contenedor para que el usuario lo vea
                    Console.ReadKey(); //Esperamos para continuar
                }
                else
                {
                    Console.WriteLine("Eliga una opcion valida");
                }
            } while (opcionMenu != 3); //Mientras la opcion elegida sea diferente de 3
            Console.WriteLine("Presione una tecla para salir..."); //Solicitamos salir
            Console.ReadKey(); //Esperamos para salir
        }

        static void imprimirContenedores(Stack mipila)
        {
            Console.WriteLine("Contenedores: {0}", mipila.Count); //Mostramos el numero de contenedores
            Console.WriteLine("-------"); //Escribimos unas lineas para mayor comprension
            foreach (int var in mipila) //Por cada entero en mipila
            {
                Console.WriteLine("-- {0} --", var); //Mostrar el valor de la pila
                Console.WriteLine("-------"); //Y un separador
            }
        }

        static Stack retirarContenedor(Stack mipila, int numeroContenedor)
        {
            Stack contenedorTemporal = new Stack();
            for (int i = 0; i < numeroContenedores; i++)
            {
                if (int.Parse(mipila.Peek().ToString()) != numeroContenedor)
                {
                    contenedorTemporal.Push(mipila.Pop());
                }
                else
                {
                    mipila.Pop();
                    numeroContenedores--;
                }
            }
            foreach (int valor in contenedorTemporal)
            {
                mipila.Push(valor);
            }
            return mipila;
        }
    }
}
