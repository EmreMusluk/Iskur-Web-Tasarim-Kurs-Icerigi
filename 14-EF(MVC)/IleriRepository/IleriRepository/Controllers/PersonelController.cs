using IleriRepository.Data;
using IleriRepository.Models;
using IleriRepository.UnitofWork;
using Microsoft.AspNetCore.Mvc;

namespace IleriRepository.Controllers
{
    public class PersonelController : Controller
    {
        IUnit _uow;
        PersonelModel _model;

        public PersonelController(IUnit uow, PersonelModel model)
        {
            _uow = uow;
            _model = model;
        }
        public IActionResult ListbyGrade()
        {
            return View(_uow._personelRep.ListByGrades());
        }
        public IActionResult Details(int Id)
        {
            //Eager Load - Bağlantılar boş gelir.
            //Lazy bağlantılar dolu gelir, performans düştüğü için bu tercih edilmez.
            //en iyi kullanım yolu Eager Load ve gerekli yerde include --> istediği bağlantıyı alır.
            //Personel p = _uow._personelRep.Find(Id); hata verdiği için bu kod yerine yeni FindDetails diye metot oluşturduk.
            Personel p = _uow._personelRep.FindDetail(Id);
            return View(p);
        }
    }
}
