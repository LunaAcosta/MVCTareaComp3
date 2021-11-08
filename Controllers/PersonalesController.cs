using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCTarea.Models;

namespace MVCTarea.Controllers
{
    public class PersonalesController : Controller
    {
        public IActionResult Index()
        {
            Personales personales = new Personales();
            personales.nombre="Kevin Alexander";
            personales.Apellidos="Luna Acosta";
            personales.Edad=19;
            personales.ce="lunaacosta300@gmail.com";
            personales.num=78633435;
            personales.direc="Municipio de Meanguera, Departamento de Morazan, El salvador";
            return View(personales);
        }

    }
}
