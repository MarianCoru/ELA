using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Profesores.Models;

namespace Profesores.Controllers
{
    public class HomeController : Controller
    {
        List<Profesor> listado = new List<Profesor>();
        public HomeController()
        {
            listado
                .Add(new Profesor() { rut = 116465561, nombre = "Enrique Salazar Soto", titulo = "Pedagogía en Matemáticas", grado = "Técnico Superior"});
            listado
                .Add(new Profesor() { rut = 165644421, nombre = "Martina Gonzalez Toledo", titulo = "Ingeniero en Electrónica", grado = "Ingeniero"});
        }
        public IActionResult Mantenedor()
        {
            return View(new Profesor());
        }
        public IActionResult Listado()
        {
            return View(listado);
        }
        public IActionResult Ficha(int rut, string nombre, string titulo, string grado)
        {
            Profesor nueva = new Profesor();

            return View(nueva);
        }

    }
}
