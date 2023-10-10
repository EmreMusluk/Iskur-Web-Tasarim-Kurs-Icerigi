using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    public class CategoriesController : Controller
    {
        NorthwindContext _db;
        public CategoriesController(NorthwindContext db)
        {
            _db = db;
        }
        public JsonResult List()
        {
            var cList = _db.Set<Category>().ToList().Select(x => new CategoryDTO
            {
                Aciklama = x.Description,
                Ad = x.CategoryName,
                Id = x.CategoryId,
            });
            return (Json(cList));
        }

        public JsonResult Find(int id)
        {
            var cat = _db.Set<Category>().Find(id);
            var carDTO = new CategoryDTO();
            carDTO.Aciklama = cat.Description;
            carDTO.Ad = cat.CategoryName;
            carDTO.Id = cat.CategoryId;

            return (Json(carDTO));
        }
    }
}
