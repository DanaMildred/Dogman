using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogman.Model
{
    public class DogManModel
    {
        public DogManModel() { }

        public DogManModel(int id, string nombre, string tipo, string habilidadEspecial, string imagenUrl)
        {
            Id_Personaje = id;
            Nombre = nombre;
            Tipo = tipo;
            Habilidad_Especial = habilidadEspecial;
            Imagen_Url = imagenUrl;
        }

        public int Id_Personaje { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Habilidad_Especial { get; set; }
        public string Imagen_Url { get; set; }
    }

}
