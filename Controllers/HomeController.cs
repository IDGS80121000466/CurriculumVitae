using Currículum_Vitae.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Currículum_Vitae.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var informacionPersonal = new InformacionPersonal
            {
                NombreCompleto = "Emmanuel Escobedo González",
                Direccion = "Pirulito #111, Los Veneros, Purísima del Rincón",
                Telefono = "(+52) 4761460361",
                Email = "emmanuelescobedogonzalez042@gmail.com",
                Sexo = "Hombre"
            };

            var model = new CurriculumViewModel
            {
                InformacionPersonal = informacionPersonal
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
