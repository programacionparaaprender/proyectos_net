using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc4App2.Models;

namespace Mvc4App2.Controllers
{
    public class PersonaController : Controller
    {
        //
        // GET: /Persona/

        public ActionResult Index()
        {
            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona(123, "Jose", "Perez", "Fuentes"));
            lista.Add(new Persona(124, "Mario", "Mantilla", "Fuentes"));
            lista.Add(new Persona(125, "Pedro", "Martinez", "Fuentes"));
            return View(lista);
        }

    }
}
