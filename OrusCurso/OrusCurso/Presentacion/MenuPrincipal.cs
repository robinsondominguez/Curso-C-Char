using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrusCurso.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            PanelBienvenida.Dock = DockStyle.Fill;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            PruebaForm frm = new PruebaForm();
            frm.ShowDialog();

            
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            PruebaControls Control = new PruebaControls();
            panel2.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panel2.Controls.Add(Control);
        }
    }
}
