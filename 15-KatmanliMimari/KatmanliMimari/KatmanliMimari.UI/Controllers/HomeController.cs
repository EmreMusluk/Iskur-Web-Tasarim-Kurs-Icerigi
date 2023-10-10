using KatmanliMimari.Ent;
using KatmanliMimari.UI.Models;
using KatmanliMimari.Uow;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KatmanliMimari.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnit _uow;
        private readonly PersonelModel _model;
        public HomeController(ILogger<HomeController> logger, IUnit uow, PersonelModel model)
        {
            _logger = logger;
            _uow = uow;
            _model = model;
        }

        public IActionResult Index()
        {
            return View(_uow._personelRep.List());
        }
        public IActionResult Create()
        {
            _model.Personel  = new Personel();
            _model.Cls = "btn btn-primary";
            _model.Text = "Ekle";
            _model.Head = "Personel Ekleme";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(Personel personel)
        {
            _uow._personelRep.Add(personel);
            return RedirectToAction("Index");
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