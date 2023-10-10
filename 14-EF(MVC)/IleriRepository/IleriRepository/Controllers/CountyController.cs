using IleriRepository.Data;
using IleriRepository.Models;
using IleriRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;

namespace IleriRepository.Controllers
{
    public class CountyController : Controller
    {
        IUnit _uow;
        CountyModel _model;
        public CountyController(IUnit uow, CountyModel model)
        {
            _uow = uow;
            _model = model;
        }
        public IActionResult List()
        {
            return View(_uow._countyRep.GetCounties());
        }
        public IActionResult Create()
        {
            _model.Head = "Yeni Giriş";
            _model.Text = "Kaydet";
            _model.Cls = "btn btn-primary";
            _model.Cities = _uow._cityRep.List();
            _model.County = new County();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(CountyModel model)
        {
            model.County.CreatedDate = DateTime.Now;
            _uow._countyRep.Add(model.County);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int Id)
        {
            _model.County = _uow._countyRep.Find(Id);
            _model.Cities = _uow._cityRep.List();
            _model.Head = "Güncelleme";
            _model.Text = "Güncelle";
            _model.Cls = "btn btn-success";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(CountyModel model)
        {
            _uow._countyRep.Update(model.County);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int Id)
        {
            _model.Cities = _uow._cityRep.List();
            _model.County = _uow._countyRep.Find(Id);
            _model.Head = "Silme";
            _model.Text = "Sil";
            _model.Cls = "btn btn-danger";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(CountyModel model)
        {
            _uow._countyRep.Delete(model.County.Id);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
