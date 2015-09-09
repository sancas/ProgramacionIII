using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LugaresTuristicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblBuses.Text = "";
            lblDireccion.Text = "";
            lblDescripcion.Text = "";
            lblHorarios.Text = "";
            lblDescripcion.Text = "Descripcion: ";
            lblDescripcion.Text += "La costa del Sol tiene una de las mas grandes y variadas infraestructuras hoteleras del pais reunidas en el estero Jaltepeque, playa San marcelino, Playa los blancos y la costa del sol.";
            lblBuses.Text = "Ruta de buses: 249, 134C, 462, 571A";
            lblDireccion.Text = "Diríjase al sur sobre la Autopista a Comalapa, gire a la derecha incorporándose a la Carretera del Litoral (CA-2), donde tomará el desvío hacia el Blvd. Costa del Sol.";
            lblHorarios.Text = "Abierto todo el dia";
            pictureBox1.Image = LugaresTuristicos.Properties.Resources.costa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblBuses.Text = "";
            lblDireccion.Text = "";
            lblDescripcion.Text = "";
            lblHorarios.Text = "";
            lblDescripcion.Text = "Descripcion: ";
            lblDescripcion.Text += "En el Paseo El Carmen se mezclan la tradición, lo moderno, el arte en diversas expresiones, la diversión, un clima agradable cuya frescura le rodea cuando visita uno de los mejores destinos turísticos de El Salvador.";
            lblBuses.Text = "Ruta de buses: 101A, 101B, 101C, 101D";
            lblDireccion.Text = "Paseo El Carmen, Santa Tecla, La Libertad, El Salvador";
            lblHorarios.Text = "Abierto todo el dia, pero preferiblemente llegar de noche";
            pictureBox1.Image = LugaresTuristicos.Properties.Resources.paseo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBuses.Text = "";
            lblDireccion.Text = "";
            lblDescripcion.Text = "";
            lblHorarios.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblBuses.Text = "";
            lblDireccion.Text = "";
            lblDescripcion.Text = "";
            lblHorarios.Text = "";
            lblDescripcion.Text = "Descripcion: ";
            lblDescripcion.Text += "Parque acuático los chorros es un turicentro que se encuentra ubicado, en santa tecla departamento de la libertad y se puede considerar una ruta turística más en El Salvador, donde se puede ir a disfrutar a dar un rico baño en las piscinas o disfrutar de la naturaleza independientemente si quiere ir solo acompañando en familia.";
            lblBuses.Text = "El precio es de $ 0.80 por persona más sin embargo estas cuotas pueden variar. Los niños menores de 10 años y las personas mayores de 60 años entran totalmente gratis, si va en auto el parqueo cuesta 69 Centros de dólar";
            lblHorarios.Text = "Abierto de 08:00 am hasta 16:00 pm";
            pictureBox1.Image = LugaresTuristicos.Properties.Resources.chorros;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblBuses.Text = "";
            lblDireccion.Text = "";
            lblDescripcion.Text = "";
            lblHorarios.Text = "";
            lblDescripcion.Text = "Descripcion: ";
            lblDescripcion.Text += "El lago Coatepeque es de origen volcánico y está situado a 18 km al sur de la ciudad de Santa Ana en el municipio de El Congo. Tiene una altitud de 745 msnm y una superficie de 25.3 km². Además, su profundidad de 115 m.";
            lblBuses.Text = "Desde la ciudad capital, inicie el recorrido por la Carretera Panamericana CA – 1 rumbo a Santa Ana; en El Congo, a la altura del kilómetro 50 se toma el desvío hacia el Lago";
            lblHorarios.Text = "Abierto a cualquier hora";
            pictureBox1.Image = LugaresTuristicos.Properties.Resources.lago;
        }
    }
}
