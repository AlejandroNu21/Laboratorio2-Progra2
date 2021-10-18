using Laboratorio2Progra.Dominio;
using Laboratorio2Progra.Models;
using Laboratorio2Progra.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2Progra.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IEntidad ientidad;
        public HomeController(ILogger<HomeController> logger, IEntidad ientidad)
        {
            this.ientidad = ientidad;
            _logger = logger;
        }

        public IActionResult Index()
        {
            

            return View();
        }

        public IActionResult Guardado(Entidad E)
        {
            if (ModelState.IsValid)
            {
                ientidad.Save(E);
                return View();
            }
            else
            {
                return View("Guardado", E);
            }
        }

        public IActionResult ListaDatos()
        {
            return View();
        }
        
        public IActionResult GetAll()
        {
            var dfJson = ientidad.Listardatos();
            return Json(new { data = dfJson });
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
