using OrusCurso.Datos;
using OrusCurso.Logica;
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
    public partial class tomarAsistencia : Form
    {
        public tomarAsistencia()
        {
            InitializeComponent();
        }

        string identificacion;
        int id_personal;
        int Contador;
        DateTime fechaReg;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora2.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha2.Text = DateTime.Now.ToShortDateString();
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            buscarPersonalIdent();
            if (identificacion == txtIdentificacion.Text)
            {
                buscarAsistenciasId();
                if(Contador == 0)
                {
                    DialogResult result = MessageBox.Show("¿Agregar Observacion?", "Observaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if(DialogResult == DialogResult.OK)
                    {
                        panelObservacion.Visible = true;
                        panelObservacion.Location = new Point(panel1.Location.X , panel1.Location.Y);
                        panelObservacion.Size = new Size(panel1.Width, panel1.Height);
                        panelObservacion.BringToFront();
                        txtObservacion.Clear();
                        txtObservacion.Focus();
                    }
                    else
                    {
                        insertarAsistencias();   
                    }
                }
                else
                {
                    confirmarSalida();
                }
            }
        }

        private void confirmarSalida()
        {
            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion = new Dasistencias();
            parametros.Id_personal = id_personal;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Horas = Bases.DateDiff(Bases.DateInterval.Hour, fechaReg, DateTime.Now);
            if (funcion.confirmarSalida(parametros)==true)
            {
                txtAviso.Text = "Salida Registrada";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
            }
        }
        private void insertarAsistencias()
        {
            if (string.IsNullOrEmpty(txtObservacion.Text))
            {
                txtObservacion.Text = "-";
            }

            Lasistencias parametros = new Lasistencias();
            Dasistencias funcion = new Dasistencias();
            parametros.Id_personal = id_personal;
            parametros.Fecha_entrada = DateTime.Now;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Estado = "ENTRADA";
            parametros.Horas = 0;
            parametros.Observacion = txtObservacion.Text;
            if (funcion.insertarAsistencias(parametros) == true)
            {
                txtAviso.Text = "Entrada Registrada";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
                panelObservacion.Visible = false;   
            }
        }

        private void buscarAsistenciasId()
        {
            DataTable dt = new DataTable();
            Dasistencias funcion = new Dasistencias();
            funcion.buscarAsistenciasId(ref dt, id_personal);
            Contador = dt.Rows.Count;
            if(Contador > 0)
            {
                fechaReg = Convert.ToDateTime(dt.Rows[0]["Fecha_entrada"]);
            }
        }

        private void buscarPersonalIdent()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.buscarPersonalIdentidad(ref dt, txtIdentificacion.Text);
            if (dt.Rows.Count > 0)
            {
                identificacion = dt.Rows[0]["Identificacion"].ToString();
                id_personal = Convert.ToInt32(dt.Rows[0]["Id_personal"]);
                txtNombre.Text = dt.Rows[0]["Nombres"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertarAsistencias();
        }
    }
}
