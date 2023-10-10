using IleriRepository.Data;
using IleriRepository.Models;
using IleriRepository.Repositories.Abstract;
using IleriRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;

namespace IleriRepository.Controllers
{
    public class DepartmentController : Controller
    {
        IUnit _uow;
        DepartmentModel _model;
        public DepartmentController(IUnit uow, DepartmentModel model)
        {
            _uow = uow;
            _model = model;
        }
        public IActionResult List()
        {
            return View(_uow._departmentRep.List());
        }
        public IActionResult Create()
        {
            _model.Head = "Yeni Giriş";
            _model.Text = "Kaydet";
            _model.Cls = "btn btn-primary";
            _model.Department = new Department();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(DepartmentModel model)
        {
            model.Department.CreatedDate = DateTime.Now;
            _uow._departmentRep.Add(model.Department);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            _model.Department = _uow._departmentRep.Find(id);
            _model.Head = "Guncelleme";
            _model.Text = "Guncelle";
            _model.Cls = "btn btn-primary";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Edit(DepartmentModel model)
        {
            model.Department.CreatedDate = DateTime.Now;
            _uow._departmentRep.Update(model.Department);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            _model.Department = _uow._departmentRep.Find(id);
            _model.Head = "Silme";
            _model.Text = "Sil";
            _model.Cls = "btn btn-danger";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(DepartmentModel model)
        {
            model.Department.CreatedDate = DateTime.Now;
            _uow._departmentRep.Delete(model.Department.Id);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
