using Dogman.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogman.Controller
{
    interface IControllerDogman
    {
        List<DogManModel> ObtenerPersonajes();
    }
}
