using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntradasPositivasyNegativas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variables.lista.Add(int.Parse(txtValor.Text));
            if (Variables.lista.Count != 1)
                lblDatos.Text += ", ";
            lblDatos.Text += txtValor.Text;
            if (int.Parse(txtValor.Text) >= 0)
                Variables.contadorPositivos++;
            else
                Variables.contadorNegativos++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total de numeros positivos: " + Variables.contadorPositivos + "\nTotal de numeros negativos: " + Variables.contadorNegativos);
        }
    }
}
