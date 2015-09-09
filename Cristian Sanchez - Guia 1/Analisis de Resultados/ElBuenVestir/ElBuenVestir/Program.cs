using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElBuenVestir
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int NumeroEmpleados; //Numero de empleados
            //Para el conjunto de empleados
            double totalRentas = 0; //Total de renta
            double totalAfps = 0; //Total de afp
            double totalIsss = 0; //Total de isss
            double totalDescuentos = 0; //Total de descuento
            double totalSueldosBase = 0; //Total de sueldos base
            double totalSueldosNeto = 0; //Total de sueldos neto
            
            //Solicitar cantidad de empleados
            Console.WriteLine("Digite la cantidad de empleados que posee");
            NumeroEmpleados = int.Parse(Console.ReadLine());

            //Creacion de matrizes para almacenar los datos de todos los empleados
            string[] nombre = new string[NumeroEmpleados];
            double[] sueldosBase = new double[NumeroEmpleados];
            double[] renta = new double[NumeroEmpleados]; //10% del sueldo base
            double[] afp = new double[NumeroEmpleados]; //5% del sueldo base
            double[] isss = new double[NumeroEmpleados]; //4% del sueldo base
            double[] descuentos = new double[NumeroEmpleados]; //renta+afp+isss
            double[] sueldoNeto = new double[NumeroEmpleados]; //sueldobase-descuentos

            //Ingresando los datos de los empleados
            for (i = 0; i < NumeroEmpleados; i++)
            {
                Console.WriteLine("Ingrese el nombre del empleado {0}", i + 1); //Le indico que deseo el nombre
                nombre[i] = Console.ReadLine(); //Guardo el nombre en el arreglo nombre en el espacio i
                Console.WriteLine("Ingrese el sueldo base del empleado {0}", i + 1); //Le indico que deseo el sueldo base
                sueldosBase[i] = Double.Parse(Console.ReadLine()); //Guardo el sueldo base en el arreglo sueldosBase en el espacio i
                
                //Procedimientos para obtener la renta, afp, isss, descuento y sueldo neto
                renta[i] = sueldosBase[i] * 0.10; //Renta = 10% del sueldo base
                afp[i] = sueldosBase[i] * 0.05; //Afp = 5% del sueldo base
                isss[i] = sueldosBase[i] * 0.04; //ISSS = 4% del sueldo base
                descuentos[i] = renta[i] + afp[i] + isss[i]; //Descuento = renta + afp + isss
                sueldoNeto[i] = sueldosBase[i] - descuentos[i]; //Sueldo neto = Sueldo base - descuentos

                //Actualizando los valores totales
                totalSueldosBase = totalSueldosBase + sueldosBase[i];
                totalRentas = totalRentas + renta[i];
                totalAfps = totalAfps + afp[i];
                totalIsss = totalIsss + isss[i];
                totalDescuentos = totalDescuentos + descuentos[i];
                totalSueldosNeto = totalSueldosNeto + sueldoNeto[i];

                //Limpiando la pantalla
                Console.Clear();
            }

            //Generando reporte
            Console.WriteLine("Nombre\tSueldo Base\tRenta\tAFP\tISSS\tDescuento\tSueldoNeto");
            for (i = 0; i < NumeroEmpleados; i++)
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}\t{5}\t\t{6}", nombre[i].Substring(0, 6), sueldosBase[i], renta[i], afp[i], isss[i], descuentos[i], sueldoNeto[i]);
            Console.WriteLine("Totales\t{0}\t\t{1}\t{2}\t{3}\t{4}\t\t{5}", totalSueldosBase, totalRentas, totalAfps, totalIsss, totalDescuentos, totalSueldosNeto);
            Console.ReadKey();
        }
    }
}
