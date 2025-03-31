using Microsoft.Data.SqlClient; // Usa Microsoft.Data.SqlClient para .NET 8


namespace Dogman.Context
{
    public class Conexion
    {
        private readonly string connectionString;

        public Conexion()
        {
            connectionString = "Server=LAPTOP-8ACQMTFU\\MSSQLSERVER01;Database=Dogman;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        }

        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        public void ProbarConexion()
        {
            try
            {
                using var conexion = new SqlConnection(connectionString);
                conexion.Open();
                Console.WriteLine("✅ Conexión exitosa a SQL Server.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al conectar: {ex.Message}");
            }
        }
    }
}

