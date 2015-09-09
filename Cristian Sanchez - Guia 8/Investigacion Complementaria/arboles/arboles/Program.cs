using System;
using System.Collections.Generic;
using System.Text;
namespace arboles
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
            NodoT Raiz = null;
            int Dato;
            do
            {
                Opcion = Menu();
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
                    //Recorrido en Pre Orden del Arbol
                    case 2:
                        RecorridoPreorden(Raiz);
                        Console.WriteLine("Fin del Recorrido,...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //Recorrido en Post Orden del Arbol
                    case 3:
                        RecorridoPostorden(Raiz);
                        Console.WriteLine("Fin del Recorrido,...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    //Recorrido en In Orden del Arbol
                    case 4:
                        RecorridoInorden(Raiz);
                        Console.WriteLine("Fin del Recorrido,...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Write("Teclee el Dato a Buscar: ");
                        Dato = int.Parse(Console.ReadLine());
                        if (Raiz != null)
                        {
                            BuscarNodo(Raiz, Dato);
                        }
                        else
                        {
                            Console.WriteLine("ERROR, Arbol Vacio....");
                        }
                        Console.Clear();
                        break;
                    case 6:
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
                    case 7:
                        int altura;
                        altura = CalcularAltura(Raiz);
                        Console.WriteLine("La altura es {0}", altura);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Write("Teclee el Dato a Buscar: ");
                        Dato = int.Parse(Console.ReadLine());
                        if (Raiz != null)
                        {
                            NodoProfundidad(Raiz, Dato);
                        }
                        else
                        {
                            Console.WriteLine("ERROR, Arbol Vacio....");
                        }
                        Console.Clear();
                        break;
                    case 9:
                        int cantidad;
                        cantidad = CalcularCantidad(Raiz);
                        Console.WriteLine("La cantidad de nodos es {0}", cantidad);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 10:
                        Finalizar();
                        break;
                }
            } while (Opcion != 10);
        }
        static int Menu()
        {

            int Resultado = 0;
            do
            {
                Console.WriteLine("MENU DE ARBOLES");
                Console.WriteLine("");
                Console.WriteLine("1.- Registrar un Nuevo Nodo");
                Console.WriteLine("2.- Recorrido en Pre-orden");
                Console.WriteLine("3.- Recorrido en Post-orden");
                Console.WriteLine("4.- Recorrido en In-orden");
                Console.WriteLine("5.- Buscar un Nodo");
                Console.WriteLine("6.- Eliminar un Nodo");
                Console.WriteLine("7.- Calcular altura del arbol");
                Console.WriteLine("8.- Profundidad un Nodo");
                Console.WriteLine("9.- Cantidad de Nodos");
                Console.WriteLine("10.- Finalizar el Programa");
                Console.WriteLine("");
                Console.Write("Teclee la Opcion Deseada: ");
                Resultado = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (Resultado < 1 || Resultado > 10)
                {
                    Console.WriteLine("ERROR, Opcion Invalida....");
                    Console.ReadLine();
                    Console.WriteLine("");
                }
                Console.Clear();
            } while (Resultado < 1 || Resultado > 10);
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
        //Metodo de recorrido en Pre-Orden
        static void RecorridoPreorden(NodoT Raiz)
        {
            if (Raiz != null)
            {
                Console.Write("{0}, ", Raiz.Informacion);
                RecorridoPreorden(Raiz.NodoIzquierdo);
                RecorridoPreorden(Raiz.NodoDerecho);
            }
        }
        //Metodo de recorrido en In-Orden
        static void RecorridoInorden(NodoT Raiz)
        {
            if (Raiz != null)
            {
                RecorridoInorden(Raiz.NodoIzquierdo);
                Console.Write("{0}, ", Raiz.Informacion);
                RecorridoInorden(Raiz.NodoDerecho);
            }
        }
        //Metodo de recorrido en Post-Orden
        static void RecorridoPostorden(NodoT Raiz)
        {
            if (Raiz != null)
            {
                RecorridoPostorden(Raiz.NodoIzquierdo);
                RecorridoPostorden(Raiz.NodoDerecho);
                Console.Write("{0}, ", Raiz.Informacion);
            }
        }
        //Calcular altura de arbol
        static int CalcularAltura(NodoT Raiz) 
        {
            if (Raiz != null)
            {
                int alturaIzquierda = 0;
                int alturaDerecha = 0;
                int altura;
                if (Raiz.NodoDerecho != null)
                    alturaDerecha = CalcularAltura(Raiz.NodoDerecho);
                if (Raiz.NodoIzquierdo != null)
                    alturaIzquierda = CalcularAltura(Raiz.NodoIzquierdo);
                altura = Math.Max(alturaIzquierda, alturaDerecha) + 1;
                return altura;
            }
            else
            {
                return 0;
            }
        }
        //Calcular nodos del arbol
        static int cant;
        static int CalcularCantidad(NodoT Raiz)
        {
            cant = 0;
            AuxCantidad(Raiz);
            return cant;
        }
        static void AuxCantidad(NodoT Raiz)
        {
            if (Raiz != null)
            {
                cant++;
                AuxCantidad(Raiz.NodoIzquierdo);
                AuxCantidad(Raiz.NodoDerecho);
            }
        }
        //Metodo de Buscar profundidad de un nodo
        static int profundidad;
        static void NodoProfundidad(NodoT Raiz, int Dato)
        {
            profundidad = 0;
            auxProfundidad(Raiz, Dato);
            if (profundidad != 0)
            {
                Console.WriteLine("La profundidad del nodo es: {0}", profundidad);
                Console.ReadLine();
            }
        }
        static void auxProfundidad(NodoT Raiz, int Dato)
        {
            if (Dato < Raiz.Informacion)
            {
                //Buscar por el Sub-Arbol izquierdo
                if (Raiz.NodoIzquierdo == null)
                {
                    Console.WriteLine("ERROR, No se encuentra el Nodo...");
                    Console.ReadLine();
                    profundidad = 0;
                }
                else
                {
                    profundidad++;
                    auxProfundidad(Raiz.NodoIzquierdo, Dato);
                }
            }
            else
            {
                if (Dato > Raiz.Informacion)
                {
                    //Buscar por el Sub-Arbol derecho
                    if (Raiz.NodoDerecho == null)
                    {
                        Console.WriteLine("ERROR, No se encuentra el Nodo...");
                        Console.ReadLine();
                        profundidad = 0;
                    }
                    else
                    {
                        profundidad++;
                        auxProfundidad(Raiz.NodoDerecho, Dato);
                    }
                }
                else
                {
                    //El nodo se encontro
                    profundidad++;
                }
            }
        }
        //Metodo de Buscar un nodo
        static void BuscarNodo(NodoT Raiz, int Dato)
        {
            if (Dato < Raiz.Informacion)
            {
                //Buscar por el Sub-Arbol izquierdo
                if (Raiz.NodoIzquierdo == null)
                {
                    Console.WriteLine("ERROR, No se encuentra el Nodo...");
                    Console.ReadLine();
                }
                else
                {
                    BuscarNodo(Raiz.NodoIzquierdo, Dato);
                }
            }
            else
            {
                if (Dato > Raiz.Informacion)
                {
                    //Buscar por el Sub-Arbol derecho
                    if (Raiz.NodoDerecho == null)
                    {
                        Console.WriteLine("ERROR, No se encuentra el Nodo...");
                        Console.ReadLine();
                    }
                    else
                    {
                        BuscarNodo(Raiz.NodoDerecho, Dato);
                    }
                }
                else
                {
                    //El nodo se encontro
                    Console.WriteLine("Nodo Localizado en el Arbol...");
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
        //Metodo de Finalizacion
        static void Finalizar()
        {
            Console.WriteLine("Fin del Programa, press any key to continue,...");
            Console.ReadLine();
        }
    }
}