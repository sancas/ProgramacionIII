using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaElectronica
{
    class Program
    {
        static int dato = 0;

        static void Main(string[] args)
        {
            int Opcion = 0;
            Agenda Raiz = null;
            EntradaAgenda Dato;
            do
            {
                Opcion = Menu();
                switch (Opcion)
                {
                    case 1:
                        dato = 0;
                        Dato = new EntradaAgenda();
                        Dato.ingresarEntrada();
                        if (Raiz == null)
                        {
                            Agenda NuevoNodo = new Agenda();
                            NuevoNodo.Informacion = Dato;
                            Raiz = NuevoNodo;
                        }
                        else
                        {
                            Insertar(Raiz, Dato);
                        }
                        Console.Clear();
                        break;
                    //Recorrido en In Orden del Arbol
                    case 2:
                        Console.WriteLine("Apellido,Nombre,\tDireccion,\tTelefono,\tMovil,\tEmail");
                        RecorridoInorden(Raiz);
                        Console.WriteLine("Fin del Recorrido,...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        dato = 0;
                        Dato = new EntradaAgenda();
                        Dato.setNombre();
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
                    case 4:
                        dato = 0;
                        Dato = new EntradaAgenda();
                        Dato.setNombre();
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
                        int cantidad;
                        cantidad = CalcularCantidad(Raiz);
                        Console.WriteLine("La cantidad de nodos es {0}", cantidad);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Finalizar();
                        break;
                }
            } while (Opcion != 6);
        }

        static int Menu()
        {

            int Resultado = 0;
            do
            {
                Console.WriteLine("MENU DE ARBOLES");
                Console.WriteLine("");
                Console.WriteLine("1.- Ingresar un nuevo Contacto");
                Console.WriteLine("2.- Mostrar Agenda");
                Console.WriteLine("3.- Buscar un Contacto");
                Console.WriteLine("4.- Eliminar un Contacto");
                Console.WriteLine("5.- Numero de Contactos");
                Console.WriteLine("6.- Finalizar el Programa");
                Console.WriteLine("");
                Console.Write("Teclee la Opcion Deseada: ");
                Resultado = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (Resultado < 1 || Resultado > 6)
                {
                    Console.WriteLine("ERROR, Opcion Invalida....");
                    Console.ReadLine();
                    Console.WriteLine("");
                }
                Console.Clear();
            } while (Resultado < 1 || Resultado > 6);
            return Resultado;
        }
        //Insertar en un arbol binario
        static void Insertar(Agenda Raiz, EntradaAgenda Dato)
        {
            if (Dato.getNombre()[dato] < Raiz.Informacion.getNombre()[dato])
            {
                if (Raiz.NodoIzquierdo == null)
                {
                    Agenda NuevoNodo = new Agenda();
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
                if (Dato.getNombre()[dato] > Raiz.Informacion.getNombre()[dato])
                {
                    if (Raiz.NodoDerecho == null)
                    {
                        Agenda NuevoNodo = new Agenda();
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
                    if (Dato.getNombre() == Raiz.Informacion.getNombre())
                    {
                        Console.WriteLine("Contacto Existente, Imposible Insertar...");
                        Console.ReadLine();
                    }
                    else
                    {
                        dato++;
                        Insertar(Raiz, Dato);
                        
                    }
                }
            }
        }
        //Metodo de recorrido en In-Orden
        static void RecorridoInorden(Agenda Raiz)
        {
            if (Raiz != null)
            {
                RecorridoInorden(Raiz.NodoIzquierdo);
                Console.Write("{0},\t", Raiz.Informacion.getNombre());
                Console.Write("{0},\t", Raiz.Informacion.getDireccion());
                Console.Write("{0},\t", Raiz.Informacion.getTelefono());
                Console.Write("{0},\t", Raiz.Informacion.getMovil());
                Console.WriteLine("{0}", Raiz.Informacion.getEmail());
                RecorridoInorden(Raiz.NodoDerecho);
            }
        }
        //Calcular nodos del arbol
        static int cant;
        static int CalcularCantidad(Agenda Raiz)
        {
            cant = 0;
            AuxCantidad(Raiz);
            return cant;
        }
        static void AuxCantidad(Agenda Raiz)
        {
            if (Raiz != null)
            {
                cant++;
                AuxCantidad(Raiz.NodoIzquierdo);
                AuxCantidad(Raiz.NodoDerecho);
            }
        }
        //Metodo de Buscar un nodo
        static void BuscarNodo(Agenda Raiz, EntradaAgenda Dato)
        {
            if (Dato.getNombre()[dato] < Raiz.Informacion.getNombre()[dato])
            {
                //Buscar por el Sub-Arbol izquierdo
                if (Raiz.NodoIzquierdo == null)
                {
                    Console.WriteLine("ERROR, No se encuentra el Contacto...");
                    Console.ReadLine();
                }
                else
                {
                    BuscarNodo(Raiz.NodoIzquierdo, Dato);
                }
            }
            else
            {
                if (Dato.getNombre()[dato] > Raiz.Informacion.getNombre()[dato])
                {
                    //Buscar por el Sub-Arbol derecho
                    if (Raiz.NodoDerecho == null)
                    {
                        Console.WriteLine("ERROR, No se encuentra el Contacto...");
                        Console.ReadLine();
                    }
                    else
                    {
                        BuscarNodo(Raiz.NodoDerecho, Dato);
                    }
                }
                else
                {
                    if (Dato.getNombre() == Raiz.Informacion.getNombre())
                    {
                        Console.WriteLine("Contacto Existente");
                        Console.WriteLine("Nombre: " + Raiz.Informacion.getNombre());
                        Console.WriteLine("Direccion: " + Raiz.Informacion.getDireccion());
                        Console.WriteLine("Telefono: " + Raiz.Informacion.getTelefono());
                        Console.WriteLine("Movil: " + Raiz.Informacion.getMovil());
                        Console.WriteLine("Email: " + Raiz.Informacion.getEmail());
                        Console.ReadLine();
                    }
                    else
                    {
                        if (dato >= Dato.getNombre().Length - 1 || dato >= Raiz.Informacion.getNombre().Length - 1)
                        {
                            Console.WriteLine("ERROR, No se encuentra el Contacto...");
                            Console.ReadLine();
                        }
                        else
                        {
                            dato++;
                            BuscarNodo(Raiz, Dato);
                        }
                    }
                }
            }
        }
        //Metodo de Eliminar
        static void EliminarNodo(ref Agenda Raiz, EntradaAgenda Dato)
        {
            if (Raiz != null)
            {
                if (Dato.getNombre()[dato] < Raiz.Informacion.getNombre()[dato])
                {
                    EliminarNodo(ref Raiz.NodoIzquierdo, Dato);
                }
                else
                {
                    if (Dato.getNombre()[dato] > Raiz.Informacion.getNombre()[dato])
                    {
                        EliminarNodo(ref Raiz.NodoDerecho, Dato);
                    }
                    else
                    {
                        //Si lo Encontro
                        Agenda NodoEliminar = Raiz;
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
                                Agenda AuxiliarNodo = null;
                                Agenda Auxiliar = Raiz.NodoIzquierdo;
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
                Console.WriteLine("ERROR, EL Contacto no se Encuentra en la Agenda...");
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
