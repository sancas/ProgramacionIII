using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tabla
{
    class TablaMultiplicar
    {
        public void CargarValor()
        {
            int valor;
            string linea;
            do
            {
                Console.Write("Ingrese un valor (-1 para finalizar):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != -1)
                {
                    Calcular(valor);
                }
            } while (valor != -1);
        }

        public void Calcular(int v)
        {
            for (int f = v; f <= v * 10; f = f + v)
            {
                Console.Write(f + "-");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TablaMultiplicar tm = new TablaMultiplicar();
            tm.CargarValor();
        }
    }
}
