using Currículum_Vitae.Models;
using Microsoft.AspNetCore.Mvc;

namespace Currículum_Vitae.Controllers
{
    public class ExperienciaProfesionalController : Controller
    {
        public IActionResult ExperienciaProfesional()
        {
            var informacionPersonal = new InformacionPersonal
            {
                NombreCompleto = "Emmanuel Escobedo González",
                Direccion = "Pirulito #111, Los Veneros, Purísima del Rincón",
                Telefono = "(+52) 4761460361",
                Email = "emmanuelescobedogonzalez042@gmail.com",
                Sexo = "Hombre"
            };

            var informacionExperienciaProfesional = new InformacionExperienciaProfesional
            {
                Titulo = "Desarrollador web",
                Empresa = "Comercializadora de suelas y avios ESRO S.A. de C.V.",
                Puesto = "Analista, Diseñador, Administrador de base de datos",
                Funciones = " Analizar la problemática del cliente para obtener los requerimientos funcionales y no funcionales, desarrollador web y administrador de base de datos para el proyecto 'Sistema de nómina'"
            };

            var model = new CurriculumViewModel
            {
                InformacionPersonal = informacionPersonal,
                InformacionExperienciaProfesional = informacionExperienciaProfesional
            };

            return View(model);
        }
    }
}
