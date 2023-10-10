using Microsoft.AspNetCore.Mvc;

namespace MvcwithBs.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Manage()
        {
            return View();
        }
        public IActionResult Mail()
        {
            return View();
        }
    }
}
