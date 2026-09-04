using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoC_.Listas
{
    public partial class FrmListas_Arrays : Form
    {
        public FrmListas_Arrays()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarListas();
        }

        private void AgregarListas()
        {
            List<string> nombres = new List<string>();
            nombres.Add("John Doe");
            nombres.Add("Jane Doe");

            foreach (string nombre in nombres)
            {
                ListDatos.Items.Add(nombre);
            }   
        }

        private void AgregarArrays()
        {
            string[] nombres = new string[4]
            {
                "John Doe",
                "Jane Doe",
                "Juan Perez",
                "Maria Lopez"
            };
            foreach(string nombre in nombres)
            {
                ListDatos.Items.Add(nombre);
            }
        }

        private void FrmListas_Arrays_Load(object sender, EventArgs e)
        {
            DibujarTeclado();
        }

        private void DibujarTeclado()
        {
            char[] numeros;
            numeros = "1234567890".ToCharArray();
            PanelNumerico.Controls.Clear();
            foreach (char numero in numeros)
            {
                Button btn = new Button();
                btn.Text = numero.ToString();
                btn.Size = new Size(50, 50);
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.FromArgb(100, 50, 145);
                btn.FlatAppearance.BorderSize = 2;
                PanelNumerico.Controls.Add(btn);
                btn.Click += btn_Click;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string numero = ((Button)sender).Text;
            txtPantalla.Text += numero;
        }
    }
}
