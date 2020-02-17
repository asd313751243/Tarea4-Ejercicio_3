using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio_3.Models;

namespace Ejercicio_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly Listado _listado;

        public HomeController()
        {
            _listado = new Listado();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Carro Notengo)
        {
            if (ModelState.IsValid)
            {
                _listado.Carros.Add(Notengo);
                return RedirectToAction("Quiero", Notengo);
            }
            return View(Notengo);
        }

        public IActionResult Quiero(Carro Notengo)
        {

            return View(_listado);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}