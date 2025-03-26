using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
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

            public string GetConnectionString()
            {
                return connectionString;
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

