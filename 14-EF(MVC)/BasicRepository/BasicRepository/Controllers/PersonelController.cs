using BasicRepository.Context;
using BasicRepository.Data;
using BasicRepository.Models;
using BasicRepository.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BasicRepository.Controllers
{
    public class PersonelController : Controller
    {
        Repos<Personel> repos;
        PersonelModel model;

        //builder.Services.AddScoped<Repos<Personel>>();
        //Program.cs ye bu kodu yazdığımız için Repos<Personel> otomatik newlenir.
        public PersonelController(Repos<Personel> repos, PersonelModel model) 
        {
            this.repos = repos;
            this.model = model;
        }
        public IActionResult List()
        {
            return View(repos.List());
        }
        public IActionResult Create()
        {
            model.Head = "Create";
            model.Cls = "btn btn-primary";
            model.Text = "Kaydet";
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Create(PersonelModel m)
        {
            repos.Add(m.Personel);
            repos.Save();
            return RedirectToAction("List");
        }

        public IActionResult Edit(int Id)
        {
            model.Head = "Edit";
            model.Cls = "btn btn-primary";
            model.Text = "Edit";
            model.Personel = repos.Find(Id);
            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Edit(PersonelModel m)
        {
            repos.Update(m.Personel);
            repos.Save();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int Id)
        {
            model.Head = "Delete";
            model.Cls = "btn btn-primary";
            model.Text = "Delete";
            model.Personel = repos.Find(Id);
            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Delete(PersonelModel m)
        {
            repos.Delete(m.Personel);
            repos.Save();
            return RedirectToAction("List");
        }
    }
}
