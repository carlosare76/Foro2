using Foro2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Foro2.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: /Usuario/Index
        public IActionResult Index()
        {
            var usuario = new UsuarioViewModel
            {
                Nombre = "Ejemplo Usuario",
                CorreoElectronico = "usuario@example.com"
            };

            return View(usuario);
        }

        // GET: /Usuario/Agregar
        public IActionResult Agregar()
        {
            return View();
        }

        // POST: /Usuario/Agregar
        [HttpPost]
        public IActionResult Agregar(UsuarioViewModel usuario)
        {
            return RedirectToAction("Index");
        }
    }
}
