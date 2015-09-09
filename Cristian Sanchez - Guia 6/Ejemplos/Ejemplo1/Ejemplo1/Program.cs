using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class nodo
        {
            public char info;
            //sgte es un objeto que simula el puntero
            public nodo sgte;
        }
        class pila
        {
            public nodo tope;
            public pila()
            {
                tope = null;
            }
            public void Push(char valor)
            {
                nodo aux = new nodo();
                aux.info = valor;
                //si no hay nada en la pila
                if (tope == null)
                {
                    //se asigna el aux como el unico nodo
                    tope = aux;
                    //como solo hay un dato en la pila el puntero se dirige a null
                    aux.sgte = null;
                }
                else
                {
                    //si la pila no esta vacia el dato se inserta arriba de la pila
                    //es decir en el tope
                    aux.sgte = tope;
                    tope = aux;
                }
            }
            public void mostrar()
            {
                nodo puntero;
                puntero = tope;
                Console.WriteLine("{0}", puntero.info);
                //se recorre el puntero del tope a el fondo
                while (puntero.sgte != null)
                {
                    puntero = puntero.sgte;
                    Console.WriteLine("{0}", puntero.info);
                }

            }
            public char Pop()
            {
                char valor = ' ';
                if (tope == null)
                    Console.WriteLine("Lista vacia");
                else
                {
                    //se elimina el ultimo en entrar y se retorna el valor que se elimina
                    valor = tope.info;
                    tope = tope.sgte;
                }
                return valor;
            }
        }
        static void Main(string[] args)
        {
            string cadena;
            char caracter;
            pila mipila = new pila();
            pila pilafrase = new pila();

            //PARTE 1
            //SE INGRESAN CARACTERES DE MANERA INDIVIDUAL A LA PILA Y LUEGO SE MUESTRAN
            Console.WriteLine("\t\t---PARTE I---");
            //ingresamos elementos a la pila
            mipila.Push('p');
            mipila.Push('b');
            mipila.Push('z');
            mipila.Push('s');
            //mostramos el contenido de la pila
            mipila.mostrar();
            Console.ReadLine();
            //sacamos un elemento de la pila
            mipila.Pop();
            mipila.mostrar();
            Console.ReadLine();
            //PARTE 2
            //SE INGRESA UNA CADENA Y SE INGRESAN TODOS LOS
            //CARACTERES DE DICHA CADENA
            Console.WriteLine("\t\t---PARTE II---");
            Console.Write("Ingrese la palabra: ");
            cadena = Console.ReadLine();
            for (int i = 0; i < cadena.Length; i++)
            {
                //extrae una caracter de la cadena y lo convierte en char
                caracter = char.Parse(cadena.Substring(i,
                    1));
                pilafrase.Push(caracter);
            }
            //imprimir el contenido de la pila
            pilafrase.mostrar();
            Console.ReadLine();
        }
    }
}
