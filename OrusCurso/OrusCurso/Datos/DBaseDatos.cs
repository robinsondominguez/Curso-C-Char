using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace OrusCurso.Datos
{
    public class DBaseDatos
    {
        private const string NombreBase = "OrusCadence";

        public void Respaldar(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
                throw new ArgumentException("Debe indicar un archivo de respaldo.", nameof(rutaArchivo));

            string directorio = Path.GetDirectoryName(Path.GetFullPath(rutaArchivo));
            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);

            using (SqlConnection connection = Conexion.CrearConexion())
            using (SqlCommand command = new SqlCommand(
                "BACKUP DATABASE [" + NombreBase + "] TO DISK = @Ruta WITH INIT, STATS = 10;",
                connection))
            {
                command.Parameters.Add("@Ruta", SqlDbType.NVarChar, 4000).Value = rutaArchivo;
                command.CommandTimeout = 0;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Restaurar(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo))
                throw new FileNotFoundException("No se encontró el archivo de respaldo.", rutaArchivo);

            using (SqlConnection connection = Conexion.CrearConexionMaster())
            using (SqlCommand command = new SqlCommand(
                "ALTER DATABASE [" + NombreBase + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;" +
                "RESTORE DATABASE [" + NombreBase + "] FROM DISK = @Ruta WITH REPLACE, RECOVERY, STATS = 10;" +
                "ALTER DATABASE [" + NombreBase + "] SET MULTI_USER;",
                connection))
            {
                command.Parameters.Add("@Ruta", SqlDbType.NVarChar, 4000).Value = rutaArchivo;
                command.CommandTimeout = 0;
                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                }
                finally
                {
                    try
                    {
                        using (SqlCommand multiUser = new SqlCommand(
                            "ALTER DATABASE [" + NombreBase + "] SET MULTI_USER;",
                            connection))
                        {
                            multiUser.ExecuteNonQuery();
                        }
                    }
                    catch
                    {
                        // El RESTORE puede cerrar la sesión; no se oculta el error original.
                    }
                }
            }
        }

        public DataTable ObtenerEstado()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection connection = Conexion.CrearConexion())
            using (SqlCommand command = new SqlCommand(
                "SELECT DB_NAME() AS BaseDatos, " +
                "SUSER_SNAME() AS LoginSQL, " +
                "USER_NAME() AS UsuarioBD, " +
                "@@SERVERNAME AS Servidor, " +
                "GETDATE() AS FechaServidor;",
                connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                adapter.Fill(tabla);
            }

            return tabla;
        }
    }
}
