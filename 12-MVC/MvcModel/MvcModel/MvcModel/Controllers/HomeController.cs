using Microsoft.AspNetCore.Mvc;
using MvcModel.Models;
using System.Diagnostics;

namespace MvcModel.Controllers
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
        public IActionResult Contact([FromServices] Webmaster _webmaster)
        {
            //1. yol A ViewBag
            //Webmaster wb= new Webmaster();
            _webmaster.Id = 1;
            _webmaster.Ad = "Emre";
            _webmaster.Soyad = "Musluk";
            _webmaster.Mail = "emremusluk9099@gmail.com";
            ViewBag.Id = _webmaster.Id;
            ViewBag.Ad = _webmaster.Ad;
            ViewBag.Soyad = _webmaster.Soyad;
            ViewBag.Mail = _webmaster.Mail;

            //1.yol B ViewBag
            ViewBag.Webmaster = _webmaster;

            return View();
        }

        //FromServices kaldırıldı yazmasakta olur.
        public IActionResult Contact2([FromServices] Webmaster _webmaster)
        {
            //Webmaster wb = new Webmaster();
            _webmaster.Id = 1;
            _webmaster.Ad = "Emre";
            _webmaster.Soyad = "Musluk";
            _webmaster.Mail = "emremusluk9099@gmail.com";
            ViewBag.Id = _webmaster.Id;
            ViewBag.Ad = _webmaster.Ad;
            ViewBag.Soyad = _webmaster.Soyad;
            ViewBag.Mail = _webmaster.Mail;
            return View(_webmaster);
        }
        public IActionResult PersonelListe(List<Webmaster> _webmasters, Webmaster _webmaster, Webmaster _webmaster1)
        {
            //List<Personel> list = new List<Personel>();
            //Personel p = new Personel();

            //Program.cs ye aşağıdakileri yazdığımız için otomatik newler.
            //builder.Services.AddScoped<Webmaster>();
            //builder.Services.AddScoped<List<Webmaster>>();
            _webmaster.Id = 1;
            _webmaster.Ad = "Emre";
            _webmaster.Soyad = "Musluk";
            _webmaster.Mail = "emremusluk9099@gmail.com";
            _webmasters.Add(_webmaster);

            _webmaster1.Id = 2;
            _webmaster1.Ad = "Hilal";
            _webmaster1.Soyad = "Arslan";
            _webmaster1.Mail = "sfsdfsf@gmail.com";
            _webmasters.Add(_webmaster1);

            ViewBag.Liste = _webmasters;

            //Bu şekilde yazdığımızda otomatik newlemez.Metoda parametre olarak vermemiz lazım.
            //Webmaster _webmaster2;
            //_webmaster2.Id = 3;

            return View(_webmasters);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}