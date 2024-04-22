using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb_Martes.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult IniciarSesion()
        {
            return View();
        }

        public ActionResult RegistrarUsuario()
        {
            return View();
        }

        public ActionResult PantallaPrincipal()
        {
            return View();
        }
    }
}