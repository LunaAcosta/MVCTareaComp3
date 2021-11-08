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
            personales.nombre="Luna";
            personales.Apellidos="Acosta";
            personales.Edad=19;
            return View(personales);
        }

    }
}
