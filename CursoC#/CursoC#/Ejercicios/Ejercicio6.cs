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
    public partial class Ejercicio6 : UserControl
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        public string titulo;
        string operacion;
        double num1;
        double num2;
        double resultado;
        bool reiniciar = false;
        bool punto = true;

        private void Ejercicio6_Load(object sender, EventArgs e)
        {
            lblEjercicio6.Text = titulo;
            DibujarTeclado();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DibujarTeclado()
        {

            char[] numeros;
            numeros = "7894563210.".ToCharArray();
            PanelNumerico.Controls.Clear();

            foreach (char numero in numeros)
            {
                Button btn = new Button();
                btn.Text = numero.ToString();
                btn.Size = new Size(52, 50);
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.White;
                btn.BackColor = Color.Transparent;
                btn.BackgroundImage = Properties.Resources.botonNegro;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                PanelNumerico.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            reiniciarProcesos();
            string NumeroString = ((Button)sender).Text;
            if (NumeroString == ".")
            {
                punto = true;
                if (txtPantalla.Text.Contains("."))
                {
                    punto = false;
                }
                if (punto == true)
                {
                    if (txtPantalla.Text != "")
                    {
                        txtPantalla.Text += ".";
                    }
                }
            }
            else
            {
                if (txtPantalla.Text == "0")
                {
                    txtPantalla.Clear();
                }
                txtPantalla.Text += NumeroString;
            }

        }

        private void reiniciarProcesos()
        {
            if (reiniciar == true)
            {
                txtPantalla.Text = "0";
                reiniciar = false;
            }
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacion = btnDiv.Text;
            definirOperacion();
        }

        private void definirOperacion()
        {
            AsignarDatos();
            if (num2 > 0)
            {
                lblNum1.Text = txtPantalla.Text;
                lblOperacion.Text = operacion;
                txtPantalla.Text = "0";
                lblNum1.Visible = true;
                lblOperacion.Visible = true;
            }
        }

        private void AsignarDatos()
        {
            num1 = Convert.ToDouble(lblNum1.Text);
            num2 = Convert.ToDouble(txtPantalla.Text);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            AsignarDatos();
            if (lblOperacion.Text == btnDiv.Text)
            {
                dividirOperacion();

            }
            if (lblOperacion.Text == btnMult.Text)
            {
                multiplicarOperacion();
            }
            if (lblOperacion.Text == btnResta.Text)
            {
                restarOperacion();
            }
            if (lblOperacion.Text == btnSuma.Text)
            {
                sumarOperacion();
            }
            if (lblOperacion.Text == btnPorcen.Text)
            {
                porcentajeOperacion();
            }
        }

        private void porcentajeOperacion()
        {
            resultado = (num1 * num2) / 100;
            txtPantalla.Text = resultado.ToString();
            limpieza();
        }

        private void sumarOperacion()
        {
            resultado = num1 + num2;
            txtPantalla.Text = resultado.ToString();
            limpieza();
        }

        private void restarOperacion()
        {
            resultado = num1 - num2;
            txtPantalla.Text = resultado.ToString();
            limpieza();
        }

        private void multiplicarOperacion()
        {
            resultado = num1 * num2;
            txtPantalla.Text = resultado.ToString();
            limpieza();
        }

        private void dividirOperacion()
        {
            resultado = num1 / num2;
            txtPantalla.Text = resultado.ToString();
            limpieza();
        }

        private void limpieza()
        {
            reiniciar = true;
            lblOperacion.Text = "0";
            lblNum1.Text = "0";
            lblOperacion.Visible = false;
            lblNum1.Visible = false;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operacion = btnMult.Text;
            definirOperacion();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = btnResta.Text;
            definirOperacion();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = btnSuma.Text;
            definirOperacion();
        }

        private void btnPorcen_Click(object sender, EventArgs e)
        {
            operacion = btnPorcen.Text;
            definirOperacion();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void borrar()
        {
            txtPantalla.Text = "0";
            lblOperacion.Text = "0";
            lblNum1.Text = "0";
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPantalla.Text);
        }
    }
}
