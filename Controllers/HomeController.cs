using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03___Music_StoreBrasburgUrquizo.Models;

namespace TP03___Music_StoreBrasburgUrquizo.Controllers
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
            Catalogo.inicializarCatalogo();
            ViewBag.VBIndex = Catalogo.DicDiscos;
            return View();
        }
        public IActionResult SelectDisco(int Id)
        {
            if (Catalogo.DicDiscos.ContainsKey(Id))
            {
                ViewBag.VBDisco = Catalogo.DicDiscos[Id];

            }
            return View("Canciones");

        }

     
    }


}
