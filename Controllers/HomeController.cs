using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio_01_Implementación_y_análisis_de_estructuras__lineales.Models;
using Laboratorio_01_Implementación_y_análisis_de_estructuras__lineales.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Laboratorio_01_Implementación_y_análisis_de_estructuras__lineales.Controllers
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
            return View();
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

        public ActionResult Listaartesanal()
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ListaC()
        {
            try
            {
                return RedirectToAction();
                
            }
            catch
            {
                return View();
            }
        }
    }
}
