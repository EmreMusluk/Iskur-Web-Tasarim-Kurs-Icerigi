using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    public class RegionController : Controller
    {
        NorthwindContext _db;
        public RegionController(NorthwindContext db)
        {
            _db = db;
        }

        public IActionResult List()
        {
            var rList = _db.Set<Region>().ToList();
            return (Json(rList));
        }
    }
}
