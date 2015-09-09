using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaElectronica
{
    public class EntradaAgenda
    {
        private string nombre;
        private string direccion;
        private string telefono;
        private string movil;
        private string email;

        public EntradaAgenda()
        {
            nombre = null;
            direccion = null;
            telefono = null;
            movil = null;
            email = null;
        }

        public void ingresarEntrada()
        {
            string nombre, apellidos;
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            apellidos = Console.ReadLine();
            this.nombre = apellidos + "," + nombre;
            Console.WriteLine("Direccion: ");
            this.direccion = Console.ReadLine();
            Console.WriteLine("Telefono: ");
            this.telefono = Console.ReadLine();
            Console.WriteLine("Movil: ");
            this.movil = Console.ReadLine();
            Console.WriteLine("Email: ");
            this.email = Console.ReadLine();
        }

        public void ingresarEntrada(string nombre, string direccion, string telefono, string movil, string email)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.movil = movil;
            this.email = email;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getDireccion()
        {
            return this.direccion;
        }
        public string getTelefono()
        {
            return this.telefono;
        }
        public string getMovil()
        {
            return this.movil;
        }
        public string getEmail()
        {
            return this.email;
        }

        public void setNombre()
        {
            string nombre, apellidos;
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            apellidos = Console.ReadLine();
            this.nombre = apellidos + "," + nombre;
        }
    }
}
