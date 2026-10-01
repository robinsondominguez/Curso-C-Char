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
    public partial class Ejercicio3 : UserControl
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        double peso;
        double altura;
        double imc;
        public string titulo;

        private void AsignarDatos()
        {
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
        }

        private void obtenerIMC()
        {
            imc = peso / Math.Pow(altura, 2);
            txtImc.Text = imc.ToString(("N2"));
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            lblEjercicio.Text = titulo;
        }

        private void Condicionar()
        {
            if (imc < 18.5)
            {
                lblCondicion.Text = "Bajo peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                lblCondicion.Text = "Normal";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                lblCondicion.Text = "Sobrepeso";
            }
            else if (imc >= 30)
            {
                lblCondicion.Text = "Obesidad";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignarDatos();
            obtenerIMC();
            Condicionar();
        }
    }
}
