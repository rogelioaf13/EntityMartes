using ProyectoApi_Martes.Entidades;
using System.Web.Http;

namespace ProyectoApi_Martes.Controllers
{
    public class InicioController : ApiController
    {
        [Route("inicio/Registrar")]
        [HttpPost]
        public void RegistrarUsuario(Usuario entidad)
        {
            //llamar a la bd
        }
    }
}
