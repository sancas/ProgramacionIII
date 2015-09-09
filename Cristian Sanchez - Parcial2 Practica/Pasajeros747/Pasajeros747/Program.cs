using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasajeros747
{
    class Pasajero
    {
        private string nombre;
        private string pasaporte;
        private string numeroAsiento;

        public Pasajero(string nombre, string pasaporte, string numeroAsiento)
        {
            this.nombre = nombre;
            this.pasaporte = pasaporte;
            this.numeroAsiento = numeroAsiento;
        }

        public Pasajero()
        {
            nombre = null;
            pasaporte = null;
            numeroAsiento = null;
        }

        public void setData(string nombre, string pasaporte, string numeroAsiento)
        {
            this.nombre = nombre;
            this.pasaporte = pasaporte;
            this.numeroAsiento = numeroAsiento;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue pasajeros = new Queue(); //Cola que almacenara a los pasajeros
            int contadorPrimeraClase = 0; //Contador de tipo entero que contara el numero de pasajeros de primera clase
            int contadorClaseEjecutiva = 0; //Contador de tipo entero que contara el numero de pasajeros en clase ejecutiva
            int contadorClaseEconomica = 0; //Contador de tipo entero que contara el numero de pasajeros en clase economica
            int opc; //Entero que contendra el tipo de accion que el usuario elija

            do
            {
                //Informacion de vuelo
                Console.Clear();
                Console.WriteLine("Manejo de pasajeros con destino X en un avion 747");
                Console.WriteLine("Pasajeros abordo: {0}", pasajeros.Count);
                Console.WriteLine("Espacios primera clase disponibles: {0}", 23 - contadorPrimeraClase);
                Console.WriteLine("Espacios clase ejecutiva disponibles: {0}", 90 - contadorClaseEjecutiva);
                Console.WriteLine("Espacios clase economica disponibles: {0}", 313 - contadorClaseEconomica);
                Console.WriteLine("");
                //Inicio del menu
                Console.WriteLine("Elija una opcion: ");
                Console.WriteLine("1. Agregar un pasajero a primera clase");
                Console.WriteLine("2. Agregar un pasajero a clase ejecutiva");
                Console.WriteLine("3. Agregar un pasajero a clase economica");
                Console.WriteLine("4. Cerrar las puertas y despejar");
                opc = int.Parse(Console.ReadLine()); //Almacenamos el valor digitado por el teclado
                switch (opc)
                {
                    case 1:
                        if (contadorPrimeraClase <= 23)
                        {
                            contadorPrimeraClase++;
                            Pasajero miPasajeroVIP = addPasajero();
                            pasajeros.Enqueue(miPasajeroVIP);
                            Console.WriteLine("Agregado Correctamente");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ya no hay espacio para mas pasajeros en clase VIP para este vuelo");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        if (contadorClaseEjecutiva <= 90)
                        {
                            contadorClaseEjecutiva++;
                            Pasajero miPasajeroEjecutivo = addPasajero();
                            pasajeros.Enqueue(miPasajeroEjecutivo);
                            Console.WriteLine("Agregado Correctamente");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ya no hay espacio para mas pasajeros en clase Ejecutiva para este vuelo");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        if (contadorClaseEconomica <= 313)
                        {
                            contadorClaseEconomica++;
                            Pasajero miPasajeroEconomico = addPasajero();
                            pasajeros.Enqueue(miPasajeroEconomico);
                            Console.WriteLine("Agregado Correctamente");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ya no hay espacio para mas pasajeros en clase Economica para este vuelo");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Por favor abrochese su cinturon, el avion esta a punto de despegar");
                        Console.WriteLine("Les pedimos que pongan atencion a su piloto este dia que tengan un buen viaje");
                        Console.WriteLine("Presione una tecla para despegar...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        Console.ReadKey();
                        break;
                }
            } while (opc != 4);
        }

        public static Pasajero addPasajero()
        {
            string nombre;
            string pasaporte;
            string numeroAsiento;
            Console.WriteLine("Nombre del pasajero: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Pasaporte del pasajero: ");
            pasaporte = Console.ReadLine();
            Console.WriteLine("Numero de asiento: ");
            numeroAsiento = Console.ReadLine();
            Pasajero miPasajero = new Pasajero(nombre, pasaporte, numeroAsiento);
            return miPasajero;
        }
    }
}
