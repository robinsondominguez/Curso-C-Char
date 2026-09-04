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
    public partial class Ejercicio4 : UserControl
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        public string titulo;

        private void lblEjercicio_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void calcular()
        {
            double total = 0;
            string detalle = "";
            if (rbTallaL.Checked == true)
            {
                total += 100;
                detalle += "Casacas Talla L $100 \r\n";
            }
            if(rbTallaM.Checked == true)
            {
                total += 200;
                detalle += "Casacas Talla M $200 \r\n";
            }
            if(rbTallaS.Checked == true)
            {
                total += 300;
                detalle += "Casacas Talla S $300 \r\n";
            }       
            if (rbColorBlanco.Checked == true)
            {
                total += 10;
                detalle += "     Blanco \r\n";
            }
            if (rbColorRojo.Checked == true)
            { 
                total += 20;
                detalle += " Color Rojo \r\n";
            }
            detalle += "El total a pagar es de "+ total + "\r\n "; 
            txtDetalle.Text = detalle;
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = titulo;
        }
    }
}
