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
    public partial class Ejercicio1 : UserControl
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        double c;
        double resultado;
        public string titulo;

        private void AsignarDatos()
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
        }

        private void Calcular()
        {
            resultado = ((c + 5) * (Math.Pow(b, 2) - 3 * a * c) * Math.Pow(a, 2)) / (4 * a);
            lblResultado.Text = resultado.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignarDatos();
            Calcular();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            lblEjercicio.Text = titulo;
        }
    }
}
