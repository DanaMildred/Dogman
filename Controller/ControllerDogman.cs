using Dogman.Context;
using Dogman.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogman.Controller
{
        public class ControllerDogman : IControllerDogman
        {
            private Conexion conexion = new Conexion();

            public List<DogManModel> ObtenerPersonajes()
            {
                List<DogManModel> personajes = new List<DogManModel>();

                using (SqlConnection conn = new SqlConnection(conexion.GetConnectionString()))
                {
                    string query = "SELECT * FROM Personajes";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DogManModel personaje = new DogManModel
                        {
                            Id_Personaje = Convert.ToInt32(reader["Id_Personaje"]),
                            Nombre = reader["Nombre"].ToString(),
                            Tipo = reader["Tipo"].ToString(),
                            Habilidad_Especial = reader["Habilidad_Especial"].ToString(),
                            Imagen_Url = reader["Imagen_URL"].ToString()
                        };
                        personajes.Add(personaje);
                    }

                    conn.Close();
                }

                return personajes;
            }
        }
    }

