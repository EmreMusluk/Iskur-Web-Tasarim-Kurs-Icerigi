using Microsoft.AspNetCore.Mvc;
using ÖDEV.Models;
using System.Collections;
using System.Diagnostics;

namespace ÖDEV.Controllers
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
        public IActionResult PersonLıst()
        {
            var persons = new List<Person>
            {
                new Person { Id = 1, Ad = "Mehmet", Soyad = "Şefik", Bolum = "Satınalma" },
                new Person { Id = 2, Ad = "Ali", Soyad = "Eroğlu", Bolum = "Üretim" },
                new Person { Id = 3, Ad = "Aydın", Soyad = "Biçen", Bolum = "Kalite" },
                new Person { Id = 4, Ad = "Mahmut", Soyad = "Yıldırım", Bolum = "İnsan Kaynakları" }
            };
            return View(persons);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}