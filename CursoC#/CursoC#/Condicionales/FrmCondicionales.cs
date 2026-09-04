using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoC_.Condicionales
{
    public partial class FrmCondicionales : Form
    {
        public FrmCondicionales()
        {
            InitializeComponent();
        }

        int numero;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignarValores();
            Calcular();
        }


        private void Calcular()
        {
            if (numero > 0) 
            {
                lblResultado.Text = "El número es positivo";
            }
            else if (numero == 0)
            {
                lblResultado.Text = "El número es cero";
            }
            else 
            { 
                lblResultado.Text = "El número es negativo";
            } 

        }

        private void AsignarValores()
        {
            numero = Convert.ToInt32(txtNumero.Text);
        }
    }
}
