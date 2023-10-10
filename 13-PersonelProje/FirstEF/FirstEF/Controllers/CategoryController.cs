using FirstEF.Data;
using FirstEF.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstEF.Controllers
{
    public class CategoryController : BaseController
    {
        public CategoryController(SalesContext db) : base(db)
        {

        }
        public IActionResult List()
        {
            //Kategoriye ait tüm ürünleri listeler.
            return View(db.Set<Category>().ToList());
        }
        public IActionResult Detail(int id)
        {
            var p = db.Set<Category>().Include(x => x.Products).Where(x => x.Id == id).FirstOrDefault();

            return View(p);
        }
        public IActionResult Create(Category cat)
        {
            return View("Crud", cat);
        }

        [HttpPost]
        public IActionResult Create(Category cat, bool value)
        {
            db.Set<Category>().Add(cat);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        //id yi araştır
        public IActionResult Edit(int id)
        {
            var category = db.Set<Category>().Find(id);
            return View("Crud", category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            db.Set<Category>().Update(category);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            Category cat = db.Set<Category>().Find(id);
            return View("Crud", cat);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            db.Set<Category>().Remove(category);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
