using Microsoft.AspNetCore.Mvc;

namespace MVCwithBoot.Controllers
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
