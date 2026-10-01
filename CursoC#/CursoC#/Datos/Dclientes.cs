using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CursoC_.Logica;
using System.Windows.Forms;

namespace CursoC_.Datos
{
    public class Dclientes
    {
        public void InsertarClientes(Lclientes cliente)
        {
			try
			{
				Conexion.Abrir();
				SqlCommand cmd = new SqlCommand("InsertarClientes", Conexion.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
				cmd.Parameters.AddWithValue("@Edad", cliente.Edad);
				cmd.Parameters.AddWithValue("@Codigo", cliente.Codigo);
				cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente insertado correctamente");	
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

            }
			finally 
			{
                Conexion.Cerrar();
            }
        }
		public void MostrarClientes(ref DataTable dt)
		{
			try
			{
				Conexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarClientes", Conexion.con);
                da.Fill(dt);
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Conexion.Cerrar();
            }
		}

		public void EditarClientes(Lclientes cliente)
		{
			try
			{
				Conexion.Abrir();
				SqlCommand cmd = new SqlCommand("EditarClientes", Conexion.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Id_Clientes", cliente.Id_Clientes);
				cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
				cmd.Parameters.AddWithValue("@Edad", cliente.Edad);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Cliente editado correctamente");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Conexion.Cerrar();
			}
		}

		public void EliminarClientes(Lclientes cliente)
		{
			try
			{
				Conexion.Abrir();
				SqlCommand cmd = new SqlCommand("EliminarClientes", Conexion.con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Id_Clientes", cliente.Id_Clientes);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Cliente eliminado correctamente");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Conexion.Cerrar();
			}
		}
    }
}
