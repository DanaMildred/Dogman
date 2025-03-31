using Dogman.Model;

namespace Dogman.Controller
{
    interface IControllerDogman
    {
        List<DogManModel> ObtenerPersonajes();
        bool InsertarPersonaje(DogManModel personaje);
        bool ActualizarPersonaje(int id, DogManModel personaje);
        bool EliminarPersonaje(int id);
    }
}
