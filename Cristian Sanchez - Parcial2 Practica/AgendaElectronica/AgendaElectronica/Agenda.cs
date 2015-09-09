using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaElectronica
{
    public class Agenda
    {
        public Agenda NodoIzquierdo;
        public EntradaAgenda Informacion;
        public Agenda NodoDerecho;
        //Constructor
        public Agenda()
        {
            this.NodoIzquierdo = null;
            this.Informacion = new EntradaAgenda();
            this.NodoDerecho = null;
        }
    }
}
