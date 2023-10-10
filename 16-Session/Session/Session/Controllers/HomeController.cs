using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Session.Models;
using System.Diagnostics;

namespace Session.Controllers
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
            var s = new Student() { Id = 1, Email = "s@gmail.com", Name = "Şamil" };
            //Kayıt
            //HttpContext.Session.SetString dediğimiz zaman s nesnesini Json tipine döndürür ve tarayacıya kayıt eder.
            HttpContext.Session.SetString("User", JsonConvert.SerializeObject(s));
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
    }
}