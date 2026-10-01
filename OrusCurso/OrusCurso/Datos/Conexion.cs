    using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OrusCurso.Datos
{
    public class Conexion
    {
        public static string conexion = @"Data Source=DESKTOP-KEKQ7DR\SQLEXPRESS; Initial Catalog=OrusCadence; Integrated Security=true";

        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
