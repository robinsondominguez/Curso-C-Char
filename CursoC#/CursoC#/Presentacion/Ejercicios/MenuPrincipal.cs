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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio1();
        }

        private void Ejercicio1()
        {
            panelVisor.Controls.Clear();
            Ejercicio1 ctl = new Ejercicio1();
            ctl.titulo = btnE1.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }
        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2();
        }
     
        private void Ejercicio2()
        {
            panelVisor.Controls.Clear();
            Ejercicio2 ctl = new Ejercicio2();
            ctl.titulo = btnE2.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void Ejercicio3()
        {
            panelVisor.Controls.Clear();
            Ejercicio3 ctl = new Ejercicio3();
            ctl.titulo = btnE3.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            Ejercicio3();
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            Ejercicio4();
        }

        private void Ejercicio4()
        {
            panelVisor.Controls.Clear();
            Ejercicio4 ctl = new Ejercicio4();
            ctl.titulo = btnE4.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            Ejercicio5();
        }

        private void Ejercicio5()
        {
            panelVisor.Controls.Clear();
            Ejercicio5 ctl = new Ejercicio5();
            ctl.titulo = btnE5.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnE6_Click(object sender, EventArgs e)
        {
            Ejercicio6();
        }

        private void Ejercicio6()
        {
            panelVisor.Controls.Clear();
            Ejercicio6 ctl = new Ejercicio6();
            ctl.titulo = btnE6.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }
    }
}
