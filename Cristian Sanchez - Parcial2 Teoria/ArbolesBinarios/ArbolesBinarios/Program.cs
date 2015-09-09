using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolesBinarios
{
    public class NodoT
    {
        public NodoT NodoIzquierdo;
        public int Informacion;
        public NodoT NodoDerecho;
        //Constructor
        public NodoT()
        {
            this.NodoIzquierdo = null;
            this.Informacion = 0;
            this.NodoDerecho = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Opcion = 0;
            NodoT[] Raiz = new NodoT[2];
            int arbol = 0;
            do
            {
                if (arbol == 0)
                    Console.WriteLine("TRABAJANDO CON ARBOL 1");
                else
                    Console.WriteLine("TRABAJANDO CON ARBOL 2");
                Opcion = Menu();
                if (Opcion == 3)
                {
                    if (arbol == 0)
                        arbol = 1;
                    else
                        arbol = 0;
                }
                if (Opcion == 4)
                {
                    if (DeterminarSimilitud(Raiz))
                        Console.WriteLine("Los arboles son similares");
                    else
                        Console.WriteLine("Los arboles no son similares");
                    Console.ReadKey();
                }
                if (arbol == 0)
                    Operaciones(ref Raiz[arbol], Opcion);
                else
                    Operaciones(ref Raiz[arbol], Opcion);                
            } while (Opcion != 5);
        }
        static void Operaciones(ref NodoT Raiz, int Opcion)
        {
            int Dato;
            switch (Opcion)
            {
                case 1:
                    Console.Write("Valor del Nuevo Nodo: ");
                    Dato = int.Parse(Console.ReadLine());
                    if (Raiz == null)
                    {
                        NodoT NuevoNodo = new NodoT();
                        NuevoNodo.Informacion = Dato;
                        Raiz = NuevoNodo;
                    }
                    else
                    {
                        Insertar(Raiz, Dato);
                    }
                    Console.Clear();
                    break;
                case 2:
                    Console.Write("Teclee el Dato a Eliminar: ");
                    Dato = int.Parse(Console.ReadLine());
                    if (Raiz != null)
                    {
                        EliminarNodo(ref Raiz, Dato);
                    }
                    else
                    {
                        Console.WriteLine("ERROR, Arbol Vacio....");
                    }
                    Console.Clear();
                    break;
                case 5:
                    Finalizar();
                    break;
            }
        }
        static int Menu()
        {

            int Resultado = 0;
            do
            {
                Console.WriteLine("MENU DE ARBOLES");
                Console.WriteLine("");
                Console.WriteLine("1.- Registrar un Nuevo Nodo");
                Console.WriteLine("2.- Eliminar un Nodo");
                Console.WriteLine("3.- Cambiar de arbol");
                Console.WriteLine("4.- Determinar similitud de los arboles");
                Console.WriteLine("5.- Finalizar el Programa");
                Console.WriteLine("");
                Console.Write("Teclee la Opcion Deseada: ");
                Resultado = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (Resultado < 1 || Resultado > 5)
                {
                    Console.WriteLine("ERROR, Opcion Invalida....");
                    Console.ReadLine();
                    Console.WriteLine("");
                }
                Console.Clear();
            } while (Resultado < 1 || Resultado > 5);
            return Resultado;
        }
        //Insertar en un arbol binario
        static void Insertar(NodoT Raiz, int Dato)
        {
            if (Dato < Raiz.Informacion)
            {
                if (Raiz.NodoIzquierdo == null)
                {
                    NodoT NuevoNodo = new NodoT();
                    NuevoNodo.Informacion = Dato;
                    Raiz.NodoIzquierdo = NuevoNodo;
                }
                else
                {
                    //Llamada recursiva
                    Insertar(Raiz.NodoIzquierdo, Dato);
                }
            }
            else
            //Buscar por el lado derecho
            {
                if (Dato > Raiz.Informacion)
                {
                    if (Raiz.NodoDerecho == null)
                    {
                        NodoT NuevoNodo = new NodoT();
                        NuevoNodo.Informacion = Dato;
                        Raiz.NodoDerecho = NuevoNodo;
                    }
                    else
                    {
                        //Llamada recursiva por el lado derecho
                        Insertar(Raiz.NodoDerecho, Dato);
                    }
                }
                else
                {
                    //El Nodo existe en el Arbol
                    Console.WriteLine("Nodo Existente, Imposible Insertar...");
                    Console.ReadLine();
                }
            }
        }
        //Metodo de Eliminar
        static void EliminarNodo(ref NodoT Raiz, int Dato)
        {
            if (Raiz != null)
            {
                if (Dato < Raiz.Informacion)
                {
                    EliminarNodo(ref Raiz.NodoIzquierdo, Dato);
                }
                else
                {
                    if (Dato > Raiz.Informacion)
                    {
                        EliminarNodo(ref Raiz.NodoDerecho, Dato);
                    }
                    else
                    {
                        //Si lo Encontro
                        NodoT NodoEliminar = Raiz;
                        if (NodoEliminar.NodoDerecho == null)
                        {
                            Raiz = NodoEliminar.NodoIzquierdo;
                        }
                        else
                        {
                            if (NodoEliminar.NodoIzquierdo == null)
                            {
                                Raiz = NodoEliminar.NodoDerecho;
                            }
                            else
                            {
                                NodoT AuxiliarNodo = null;
                                NodoT Auxiliar = Raiz.NodoIzquierdo;
                                bool Bandera = false;
                                while (Auxiliar.NodoDerecho != null)
                                {
                                    AuxiliarNodo = Auxiliar;
                                    Auxiliar = Auxiliar.NodoDerecho;
                                    Bandera = true;
                                }
                                Raiz.Informacion = Auxiliar.Informacion;
                                NodoEliminar = Auxiliar;
                                if (Bandera == true)
                                {
                                    AuxiliarNodo.NodoDerecho = Auxiliar.NodoIzquierdo;
                                }
                                else
                                {
                                    Raiz.NodoIzquierdo = Auxiliar.NodoIzquierdo;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR, EL Nodo no se Encuentra en el Arbol...");
                Console.ReadLine();
            }
        }
        //Determinar similitud de arboles
        static bool DeterminarSimilitud(NodoT[] Raiz)
        {
            if (Raiz[0] == null && Raiz[1] == null)
                return true;
            else
            {
                if (Raiz[0] != null && Raiz[1] != null)
                {
                    NodoT[] ladoIzquierdo = new NodoT[2];
                    ladoIzquierdo[0] = Raiz[0].NodoIzquierdo;
                    ladoIzquierdo[1] = Raiz[1].NodoIzquierdo;
                    if (DeterminarSimilitud(ladoIzquierdo))
                    {
                        NodoT[] ladoDerecho = new NodoT[2];
                        ladoDerecho[0] = Raiz[0].NodoDerecho;
                        ladoDerecho[1] = Raiz[1].NodoDerecho;
                        if (DeterminarSimilitud(ladoDerecho))
                            return true;
                        else
                            return false;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
        }
        //Metodo de Finalizacion
        static void Finalizar()
        {
            Console.WriteLine("Fin del Programa, press any key to continue,...");
            Console.ReadLine();
        }
    }
}