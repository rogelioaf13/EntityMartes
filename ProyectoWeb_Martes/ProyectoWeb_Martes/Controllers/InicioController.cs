using ProyectoWeb_Martes.Models;
using System.Web.Mvc;

namespace ProyectoWeb_Martes.Controllers
{
    public class InicioController : Controller
    {
        UsuarioModel modelo = new UsuarioModel();


        [HttpGet]
        public ActionResult IniciarSesion()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RegistrarUsuario()
        {
            return View();
        }

        [HttpGet]
        public ActionResult PantallaPrincipal()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RecuperarAcceso()
        {
            return View();
        }
    }
}