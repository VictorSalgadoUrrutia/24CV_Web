using _24CV_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace _24CV_Web.Controllers
{
    public class EjemplosController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            Persona persona = new Persona();
            persona.Nombre = "Victor";
            persona.Apellidos = "Salgado";
            persona.FechaNacimiento = new DateTime(2003, 02, 22);

            return View(persona);
        }


    }
}
