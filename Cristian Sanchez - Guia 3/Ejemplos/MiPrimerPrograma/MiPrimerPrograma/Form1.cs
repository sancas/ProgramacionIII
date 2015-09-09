using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerPrograma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDatos.Text = "Gerente General " + txtNombre.Text;
            lblDatos.Text += "\nDireccion: " + txtDireccion.Text;
            lblDatos.Text += "\nTelefono: " + txtTelefono.Text;
            lblDatos.Text += "\nCorreo: " + txtCorreo.Text;
        }
    }
}
