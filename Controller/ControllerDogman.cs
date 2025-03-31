using Dogman.Context;
using Dogman.Model;
using Microsoft.Data.SqlClient;

namespace Dogman.Controller
{
    public class ControllerDogman : IControllerDogman
    {
        private Conexion conexion = new Conexion();

        // OBTENER TODOS LOS PERSONAJES
        public List<DogManModel> ObtenerPersonajes()
        {
            List<DogManModel> personajes = new List<DogManModel>();

            using (SqlConnection conn = conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Personajes";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personajes.Add(new DogManModel
                            {
                                Id_Personaje = Convert.ToInt32(reader["Id_Personaje"]),
                                Nombre = reader["Nombre"].ToString(),
                                Tipo = reader["Tipo"].ToString(),
                                Habilidad_Especial = reader["Habilidad_Especial"].ToString(),
                                Imagen_Url = reader["Imagen_Url"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los personajes: " + ex.Message);
                }
            }

            return personajes;
        }

        

        // INSERTAR PERSONAJE
        public bool InsertarPersonaje(DogManModel personaje)
        {
            using (SqlConnection conn = conexion.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Personajes (Nombre, Tipo, Habilidad_Especial, Imagen_Url)
                                     VALUES (@Nombre, @Tipo, @Habilidad_Especial, @Imagen_Url)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", personaje.Nombre ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Tipo", personaje.Tipo ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Habilidad_Especial", personaje.Habilidad_Especial ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Imagen_Url", personaje.Imagen_Url ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar el personaje: " + ex.Message);
                }
            }
        }



        // ELIMINAR PERSONAJE
        public bool EliminarPersonaje(int id)
        {
            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Personajes WHERE Id_Personaje = @Id_Personaje";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id_Personaje", id);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log del error (opcional)
                Console.WriteLine($"Error SQL al eliminar personaje: {ex.Message}");
                throw new Exception("Error al comunicarse con la base de datos. Por favor intente nuevamente.");
            }
            catch (Exception ex)
            {
                // Log del error (opcional)
                Console.WriteLine($"Error inesperado al eliminar personaje: {ex.Message}");
                throw new Exception("Ocurrió un error inesperado. Por favor intente nuevamente.");
            }
        }

        bool IControllerDogman.ActualizarPersonaje(int id, DogManModel personaje)
        {
            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE Personajes 
                                     SET Nombre = @Nombre, Tipo = @Tipo, Habilidad_Especial = @Habilidad_Especial, Imagen_Url = @Imagen_Url
                                     WHERE Id_Personaje = @Id_Personaje";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id_Personaje", id);
                        cmd.Parameters.AddWithValue("@Nombre", personaje.Nombre ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Tipo", personaje.Tipo ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Habilidad_Especial", personaje.Habilidad_Especial ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Imagen_Url", personaje.Imagen_Url ?? (object)DBNull.Value);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el personaje: " + ex.Message);
            }
        }
    }
}