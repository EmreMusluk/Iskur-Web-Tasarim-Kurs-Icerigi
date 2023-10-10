using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Session.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var s = JsonConvert.DeserializeObject<Student>(HttpContext.Session.GetString("User"));
            return View(s);
        }
    }
}
