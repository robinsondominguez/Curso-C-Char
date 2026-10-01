using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoC_.Datos;
using CursoC_.Logica;

namespace CursoC_.Presentacion.CRUD
{
    public partial class FrmCRUD : Form
    {
        public FrmCRUD()
        {
            InitializeComponent();
        }

        int id_Clientes;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InsertarClientes(); 
        }

        private void InsertarClientes()
        {
            Lclientes cliente = new Lclientes();
            Dclientes datos = new Dclientes();
            cliente.Nombre = txtNombre.Text;
            cliente.Edad = Convert.ToInt32(txtEdad.Text);
            cliente.Codigo = Convert.ToInt32(txtCodigo.Text);
            datos.InsertarClientes(cliente);
            MostrarClientes();
        }

        private void FrmCRUD_Load(object sender, EventArgs e)
        {
            MostrarClientes();  
        }

        private void MostrarClientes()
        {
            Dclientes datos = new Dclientes();
            DataTable dt = new DataTable();
            datos.MostrarClientes(ref dt);
            DataListado .DataSource = dt;
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_Clientes = Convert.ToInt32(DataListado.SelectedCells[0].Value.ToString());
                txtNombre.Text = DataListado.SelectedCells[1].Value.ToString();
                txtEdad.Text = DataListado.SelectedCells[2].Value.ToString();
                txtCodigo.Text = DataListado.SelectedCells[3].Value.ToString();
            }
        }

        private void ActualizarDatos()
        {
            Dclientes datos = new Dclientes();
            Lclientes cliente = new Lclientes();
            cliente.Id_Clientes = id_Clientes;
            cliente.Nombre = txtNombre.Text;
            cliente.Edad = Convert.ToInt32(txtEdad.Text);
            datos.EditarClientes(cliente);
            MostrarClientes();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarClientes();
        }

        private void EliminarClientes()
        {
            Dclientes datos = new Dclientes();
            Lclientes cliente = new Lclientes();
            cliente.Id_Clientes = id_Clientes;
            datos.EliminarClientes(cliente);
            MostrarClientes();
        }
    }
}
