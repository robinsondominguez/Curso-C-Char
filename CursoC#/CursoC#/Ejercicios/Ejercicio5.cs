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
    public partial class Ejercicio5 : UserControl
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        int N1;

        int N2;

        public string titulo;

        private void AsignarValores()
        {
            N1 = Convert.ToInt32(txtN1.Text);
            N2 = Convert.ToInt32(txtN2.Text);
        }

        private void Calcular()
        {
            if (N1%2 == 0 && N2%2 == 0)
            {
                lblResultado.Text = "Ambos son pares";
            }
            else if (N1%2 == 0 && N2%2!= 0)
            {
                lblResultado.Text = N1 + " Es par";
            }
            else if (N1%2!= 0 && N2%2 == 0)
            {
                lblResultado.Text = N2 + " Es par";
            }
            else
            {
                lblResultado.Text = "Ambos son impares";
            }
        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ejercicio5_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = titulo;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AsignarValores();
            Calcular();
        }
    }
}
