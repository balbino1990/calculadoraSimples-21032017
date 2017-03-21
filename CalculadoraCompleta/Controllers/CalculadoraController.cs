using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraCompleta.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: Calculadora
        public ActionResult Index()
        {
            return View();
        }

        // POST: Calculadora
        [HttpPost]
        public ActionResult Index(string bt)
        {
            return View();
        }
    }
}