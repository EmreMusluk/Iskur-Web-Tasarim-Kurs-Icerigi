using IleriRepository.Data;
using IleriRepository.Models;
using IleriRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;

namespace IleriRepository.Controllers
{
    public class CityController : Controller
    {
        CityModel _model;
        IUnit _uow;
        public CityController(IUnit uow, CityModel model)
        {
            _uow = uow; //uow açılımı unit of work tür.
            _model = model;
        }
        public IActionResult List()
        {
            var cList = _uow._cityRep.List();
            return View(cList);
        }

        public IActionResult Create()
        {
            _model.Head = "Yeni Giriş";
            _model.Text = "Kaydet";
            _model.Cls = "btn btn-primary";
            City city = new City();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(CityModel model)
        {
            model.City.CreatedDate = DateTime.Now;
            _uow._cityRep.Add(model.City);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            _model.City = _uow._cityRep.Find(id);
            _model.Head = "Silme";
            _model.Text = "Sil";
            _model.Cls = "btn btn-danger";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(CityModel model)
        {
            _uow._cityRep.Delete(model.City.Id);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            _model.City = _uow._cityRep.Find(id);
            _model.Head = "Güncelle";
            _model.Text = "Güncelle";
            _model.Cls = "btn btn-primary";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(CityModel model)
        {
            _uow._cityRep.Update(model.City);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
