using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoC_.Ejercicios
{
    public partial class Ejercicio2 : UserControl
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        double radio;
        double area;
        double pi = Math.PI;
        double longitud;

        public string titulo;

        private void AsignarDatos()
        {
            area = Convert.ToDouble(txtArea.Text);  
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void obtenerRadio()
        {
            radio = Math.Sqrt(  area / pi);
            lblRadio1.Text = radio.ToString(("N2"));
            lblRadio2.Text = radio.ToString(("N2"));
            lblRadioResult.Text = radio.ToString(("N2"));
        }

        private void obtenerLongitud()
        {
            longitud = 2 * pi * radio;
            lblLongitudResult.Text = longitud.ToString(("N2"));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignarDatos();
            obtenerRadio();
            obtenerLongitud();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            lblEjercicio.Text = titulo;
        }
    }
}
