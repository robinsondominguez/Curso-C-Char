using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CursoC_.Datos
{
    public class Conexion
    {
        public static string conexion = @"Data Source=DESKTOP-KEKQ7DR\SQLEXPRESS;Initial Catalog=BaseCurso;Integrated Security=True";

        public static SqlConnection con = new SqlConnection(conexion);

        public static void Abrir()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static void Cerrar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
