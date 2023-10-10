using FirstEF.Data;
using FirstEF.DTO;
using FirstEF.Models;
using FirstEF.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace FirstEF.Controllers
{
    public class ProductController : BaseController
    {
        //SalesContext _db = new SatisContext();
        ProductsModel model;
        public ProductController(SalesContext db, ProductsModel model) : base(db)
        {
            this.model = model;
        }

        public List<Category> GetCategories()
        {
            return db.Set<Category>().ToList();
        }

        public IActionResult List()
        {
            //Productsı okuyor, döngüye giriyor her kolonda bir productdto oluşturuyor. x Product temsil eder.
            //Set-Select-ToList
            var pList = db.Set<Product>().Select(x => new ProductDTO
            {
                Id = x.Id,
                Fiyat = x.Price,
                UrunAd = x.ProductName,
                KategoriAdi = x.Category.CategoryName
            }).OrderBy(x => x.KategoriAdi).ToList();
            return View(pList);
        }

        public IActionResult Create()
        {
            model.Product = new Product();
            model.Categories = GetCategories();
            model.Head = "Yeni Giriş";
            model.cls = "btn btn-primary";
            model.Text = "Kaydet";
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Create(ProductsModel model)
        {
            db.Set<Product>().Add(model.Product);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Edit(int id)
        {
            model.Categories = GetCategories();
            model.Product = db.Set<Product>().Find(id);
            model.Head = "Güncelleme";
            model.cls = "btn btn-success";
            model.Text = "Güncelle";
            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Edit(ProductsModel model)
        {
            db.Set<Product>().Update(model.Product);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            db.Set<Product>().Remove(db.Set<Product>().Find(id));
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
