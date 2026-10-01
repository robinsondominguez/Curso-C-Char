using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrusCurso.Datos;
using OrusCurso.Logica;

namespace OrusCurso.Presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }
        int Idcargo = 0;
        int desde = 1;
        int hasta = 10;
        int contador;
        int Idpersonal;
        private int items_por_pagina = 10;
        string estado;
        int totalPaginas;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelCargos.Visible = false;
            panelPaginado.Visible = false;
            panelRegistros.Visible = true;
            panelRegistros.Dock = DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnGuardarCambiosPersonal.Visible = false;
            Limpiar();
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombres.Text))
            {
                if (!string.IsNullOrEmpty(txtIdentificacion.Text))
                {
                    if (!string.IsNullOrEmpty(cbxPais.Text))
                    {
                        if (Idcargo > 0)
                        {
                            if (!string.IsNullOrEmpty(txtSueldoHora.Text))
                            {
                                Insertar_Personal();
                            }
                        }
                    }
                }
            }
        }

        private void mostrarPersonal()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.MostrarPersonal(ref dt, desde, hasta);
            dataListadoPersonal.DataSource = dt;
            DiseñarDtvPersonal();
        }

        private void DiseñarDtvPersonal()
        {
            Bases.DiseñoDtv(ref dataListadoPersonal);
            Bases.DiseñoDtvEliminar(ref dataListadoPersonal);
            panelPaginado.Visible = true;
            dataListadoPersonal.Columns[2].Visible = false;
            dataListadoPersonal.Columns[7].Visible = false;

        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            Insertar_Cargos();
        }

        private void txtCargos_TextChanged(object sender, EventArgs e)
        {
            buscarCargos();
        }

        private void txtSueldoG_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoG, e);
        }

        private void txtSueldoHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(txtSueldoHora, e);
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            LocalizarDtvCargos();
            panelCargos.Visible = true;
            panelCargos.Dock = DockStyle.Fill;
            panelCargos.BringToFront();
            btnGuardarC.Visible = true;
            btnGuardarCambiosC.Visible = false;
            txtCargoG.Clear();
            txtSueldoG.Clear();
        }

        private void Limpiar()
        {
            txtNombres.Clear();
            txtCargos.Clear();
            txtSueldoHora.Clear(); 
            txtIdentificacion.Clear();
            buscarCargos();
        }

        private void Insertar_Personal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Nombres = txtNombres.Text;
            parametros.Identificacion = txtIdentificacion.Text;
            parametros.Pais = cbxPais.Text;
            parametros.Id_Cargo = Idcargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoHora.Text);
            if (funcion.insertarPersonal(parametros) == true)
            {
                reiniciarPaginado();
                mostrarPersonal();
                panelRegistros.Visible = false;
            }
        }

        private void Insertar_Cargos()
        {
            if (!string.IsNullOrEmpty(txtCargoG.Text))
            {
                if (!string.IsNullOrEmpty(txtSueldoG.Text))
                    {
                    Lcargos parametros = new Lcargos();
                    Dcargos funcion = new Dcargos();
                    parametros.Cargo = txtCargoG.Text;
                    parametros.SueldoPorHora = Convert.ToDouble(txtSueldoG.Text);
                    if (funcion.insertarCargo(parametros) == true)
                    {
                        txtCargos.Clear();
                        buscarCargos();
                        panelCargos.Visible = false;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Agrege el Sueldo", "Falta el Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Agrege el cargo", "Falta el cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LocalizarDtvCargos()
        {
            dataListadoCargos.Location = new Point(txtSueldoHora.Location.X, txtSueldoHora.Location.Y);
            dataListadoCargos.Size = new Size(469, 141);
            dataListadoCargos.Visible = true;
            lblSueldo.Visible = false;
            panelBtnGuardarPersonal.Visible = false;
        }   
        private void buscarCargos()
        {
            DataTable dt = new DataTable();
            Dcargos funcion = new Dcargos();
            funcion.buscarCargos(ref dt, txtCargos.Text);
            dataListadoCargos.DataSource = dt;
            Bases.DiseñoDtv(ref dataListadoCargos);
            dataListadoCargos.Columns[1].Visible = false;
            dataListadoCargos.Columns[3].Visible = false;
        }

        private void dataListadoCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataListadoCargos.Columns["EditarC"].Index)
            {
                ObtenerCargosEditar();
            }
            if(e.ColumnIndex == dataListadoCargos.Columns["Cargo"].Index)
            {
                ObtenerCargosDatos();
            }
        }

        private void ObtenerCargosDatos()
        {
            Idcargo = Convert.ToInt32(dataListadoCargos.SelectedCells[1].Value);
            txtCargos.Text = dataListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoHora.Text = dataListadoCargos.SelectedCells[3].Value.ToString();
            dataListadoCargos.Visible = false;
            panelBtnGuardarPersonal.Visible = true;
            lblSueldo.Visible = true;
        }
        private void ObtenerCargosEditar()
        {
            Idcargo = Convert.ToInt32(dataListadoCargos.SelectedCells[1].Value);
            txtCargoG.Text = dataListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoG.Text = dataListadoCargos.SelectedCells[3].Value.ToString();
            btnGuardarCambiosC.Visible = false;
            txtCargoG.Focus();
            txtCargoG.SelectAll();
            panelCargos.Visible = true;
            panelCargos.Dock = DockStyle.Fill;
            panelCargos.BringToFront();
        }

        private void btnVolverCargos_Click(object sender, EventArgs e)
        {
            panelCargos.Visible = true;

        }

        private void btnVolverPersonal_Click(object sender, EventArgs e)
        {
            panelRegistros.Visible = true;
            panelPaginado.Visible = true;
        }

        private void btnGuardarCambiosC_Click(object sender, EventArgs e)
        {
            editarCargos();
        }

        private void editarCargos()
        {
            Lcargos parametros = new Lcargos();
            Dcargos funcion = new Dcargos();
            parametros.Id_Cargo = Idcargo;
            parametros.Cargo = txtCargoG.Text;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoG.Text);
            if (funcion.editarCargo(parametros) == true)
            {
                txtCargos.Clear();
                buscarCargos();
                panelCargos.Visible = false;
            }
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            reiniciarPaginado();
            mostrarPersonal();
        }
        private void reiniciarPaginado()
        {
            desde = 1;
            hasta = 10;
            contar();   
            if (contador > hasta)
            {
                btnSig.Visible = true;
                btnAtras.Visible = false;
                btnUltima.Visible = true;
                btnPrimera.Visible = true;
            }
            else
            {
                btnSig.Visible = false;
                btnAtras.Visible = false;
                btnUltima.Visible = false;
                btnPrimera.Visible = false;
            }
            paginar();
        }

        private void dataListadoPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListadoCargos.Columns["Eliminar"].Index)
            {
                DialogResult result = MessageBox.Show("¿Solo se cambiara el estado para que sea innacesible, desea Continuar?", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    EliminarPersonal();
                }
            }
            if (e.ColumnIndex == dataListadoCargos.Columns["Editar"].Index)
            {
                ObtenerDatos();
            }
        }
        private void ObtenerDatos()
        {
            Idpersonal = Convert.ToInt32(dataListadoPersonal.SelectedCells[2].Value);
            estado = dataListadoPersonal.SelectedCells[8].Value.ToString();
            if(estado == "Eliminado")
            {
                restaurarPersonal();
            }
            else
            {
                LocalizarDtvCargos();
                txtNombres.Text = dataListadoPersonal.SelectedCells[3].Value.ToString();
                txtIdentificacion.Text = dataListadoPersonal.SelectedCells[4].Value.ToString();
                txtSueldoHora.Text = dataListadoPersonal.SelectedCells[5].Value.ToString();
                txtCargos.Text = dataListadoPersonal.SelectedCells[6].Value.ToString();
                Idcargo = Convert.ToInt32(dataListadoPersonal.SelectedCells[7].Value.ToString());
                cbxPais.Text = dataListadoPersonal.SelectedCells[10].Value.ToString();
                panelPaginado.Visible = false;
                panelRegistros.Visible = true;
                panelRegistros.Dock = DockStyle.Fill;
                dataListadoCargos.Visible = false;
                lblSueldo.Visible = true;
                panelBtnGuardarPersonal.Visible = true;
                btnGuardarPersonal.Visible = false;
                btnGuardarCambiosPersonal.Visible = true;
                panelCargos.Visible = false;    
            }
        }

        private void restaurarPersonal()
        {
            DialogResult result = MessageBox.Show("¿Este usuario se elimino, Desea Restaurarlo?", "Restauracion Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                habilitarPersonal();
            }
        }

        private void habilitarPersonal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Id_personal = Idpersonal;
            if (funcion.restaurarPersonal(parametros) == true)
            {
                mostrarPersonal();
            }
        }
        private void EliminarPersonal()
        {
            Idpersonal = Convert.ToInt32(dataListadoPersonal.SelectedCells[2].Value);
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Id_personal = Idpersonal;
            if (funcion.eliminarPersonal(parametros) == true)
            {
                mostrarPersonal();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DiseñarDtvPersonal();
            timer1.Enabled = false;
        }

        private void btnGuardarCambiosPersonal_Click(object sender, EventArgs e)
        {
            editarPersonal();
        }

        private void editarPersonal()
        {
            Lpersonal parametros = new Lpersonal();
            Dpersonal funcion = new Dpersonal();
            parametros.Id_personal = Idpersonal;
            parametros.Nombres = txtNombres.Text;
            parametros.Identificacion = txtIdentificacion.Text;
            parametros.Pais = cbxPais.Text;
            parametros.Id_Cargo = Idcargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoHora.Text);
            if (funcion.editarPersonal(parametros) == true)
            {
                mostrarPersonal();
                panelRegistros.Visible = false;
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            desde += 10;
            hasta += 10;
            mostrarPersonal();
            contar();
            if (contador > hasta)
            {
                btnSig.Visible = true;
                btnAtras.Visible = true;
            }
            else
            {
                btnAtras.Visible = true;
                btnSig.Visible = false;
            }
            paginar();
        }
        private void contar()
        {
            Dpersonal funcion = new Dpersonal();
            funcion.contarPersonal(ref contador);
        }

        private void paginar()
        {
            try
            {
                lblPagina.Text = (hasta / 10).ToString();
                lblTotalPaginas.Text = Math.Ceiling(Convert.ToSingle(contador) / items_por_pagina).ToString();
                totalPaginas = Convert.ToInt32(lblTotalPaginas.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            desde -= 10;
            hasta -= 10;
            mostrarPersonal();
            contar();
            if (contador > hasta)
            {
                btnSig.Visible = true;
                btnSig.Visible = true;
            }
            else
            {
                btnSig.Visible = false;
                btnSig.Visible = true;
            }
            if (desde == 1)
            {
                reiniciarPaginado();
            }
            paginar();
        }

        private void btnUltima_Click(object sender, EventArgs e)
        {
            hasta = totalPaginas * items_por_pagina;
            desde = hasta - 9;
            mostrarPersonal();
            contar();
            if (contador > hasta)
            {
                btnSig.Visible = true;
                btnSig.Visible = true;
            }
            else
            {
                btnSig.Visible = false;
                btnSig.Visible = true;
            }   
            paginar();
        }

        private void btnPrimera_Click(object sender, EventArgs e)
        {
            reiniciarPaginado();
            mostrarPersonal();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            buscarPersonal();
        }
        private void buscarPersonal()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.buscarPersonal(ref dt, desde, hasta, txtBuscador.Text);
            dataListadoPersonal.DataSource = dt;
            DiseñarDtvPersonal();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            reiniciarPaginado();
            mostrarPersonal();
        }
    }
}
