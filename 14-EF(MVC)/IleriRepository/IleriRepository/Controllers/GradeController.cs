using IleriRepository.Data;
using IleriRepository.Models;
using IleriRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;

namespace IleriRepository.Controllers
{
    public class GradeController : Controller
    {
        IUnit _uow;
        GradeModel _model;
        public GradeController(IUnit uow, GradeModel model)
        {
            _model = model;
            _uow = uow;
        }
        public IActionResult List()
        {
            return View(_uow._gradeRep.List());
        }
        public IActionResult Create()
        {
           _model.Grade = new Grade();
           _model.Text = "Kaydet";
           _model.Head = "Ekle";
           _model.Cls = "btn btn-primary";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(GradeModel model)
        {
            _uow._gradeRep.Add(model.Grade);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(string Id)
        {
            _model.Grade = _uow._gradeRep.Find(Id);
            _model.Head = "Güncelleme";
            _model.Text = "Güncelle";
            _model.Cls = "btn btn-success";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Edit(GradeModel model, string Id)
        {
            _uow._gradeRep.Delete(Id);
            _uow._gradeRep.Add(model.Grade);
            _uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(string Id)
        {
            _model.Grade = _uow._gradeRep.Find(Id);
            _model.Head = "Silme";
            _model.Text = "Sil";
            _model.Cls = "btn btn-danger";
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Delete(GradeModel model)
        {
            _uow._gradeRep.Delete(model.Grade.Id);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
