using Currículum_Vitae.Models;
using Microsoft.AspNetCore.Mvc;

namespace Currículum_Vitae.Controllers
{
    public class FormacionAcademicaController : Controller
    {
        public IActionResult FormacionAcademica()
        {
            var informacionPersonal = new InformacionPersonal
            {
                NombreCompleto = "Emmanuel Escobedo González",
                Direccion = "Pirulito #111, Los Veneros, Purísima del Rincón",
                Telefono = "(+52) 4761460361",
                Email = "emmanuelescobedogonzalez042@gmail.com",
                Sexo = "Hombre"
            };

            var informacionFormacionAcademica = new InformacionFormacionAcademica
            {
                Carrera = "Ingeniería en Tecnologías de la Información, área Desarrollo y Gestión de Software",
                TSU = "Técnico en Tecnologías de la Información, área Desarrollo de Software Multiplataforma",
                Bachillerato = "Técnico en Soporte y Mantenimiento de Equipo de Cómputo"
            };

            var model = new CurriculumViewModel
            {
                InformacionPersonal = informacionPersonal,
                InformacionFormacionAcademica = informacionFormacionAcademica
            };

            return View(model);
        }
    }
}
