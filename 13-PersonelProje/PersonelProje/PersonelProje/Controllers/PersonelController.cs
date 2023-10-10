using Dapper;
using Microsoft.AspNetCore.Mvc;
using PersonelProje.Data;
using PersonelProje.DTO;
using PersonelProje.Models;

namespace PersonelProje.Controllers
{
    public class PersonelController : BaseController
    {
        PersonelModel _model;
        public PersonelController(IConfiguration config, PersonelModel model) : base(config)
        {
            _model = model;
        }
        public IActionResult Liste()
        {
            string qry = "select p.Id, p.Ad + ' ' + p.Soyad AdSoyad, p.Maas, s.SehirAd SehirAd, u.UlkeAd UlkeAd from Personel p inner join Sehir s on p.SehirId = s.Id inner join Ulke u on p.UlkeId = u.Id";

            var personelList = Connect().Query<PersonelDTO>(qry).ToList();

            return View(personelList);
        }

        public Personel GetPersonel(int Id)
        {
            return Connect().Query<Personel>($"select*from Personel where Id='{Id}'").FirstOrDefault();
        }

        public List<Ulke> GetUlkeler()
        {
            return Connect().Query<Ulke>($"select*from Ulke").ToList();
        }
        public List<Sehir> GetSehirler()
        {
            return Connect().Query<Sehir>($"select*from Sehir").ToList();
        }

        public IActionResult Guncel(int Id)
        {
            _model.Personel = GetPersonel(Id);
            _model.Sehirler = GetSehirler();
            _model.Ulkeler = GetUlkeler();
            _model.Baslik = "Güncelleme İşlemi";
            _model.BtnText = "Güncelle";
            _model.BtnClass = "btn btn-success";
            return View("Genel", _model);
        }

        [HttpPost]
        //MultiModel birden fazla tip göndermek demek
        public IActionResult Guncel(Personel pModel)
        {
            var qry = $"Update personel set Ad = @Ad, Soyad = @Soyad, Maas = @Maas," +
                $"SehirId = @SehirId, UlkeId = @UlkeId where Id = @Id";
            Connect().ExecuteScalar<Personel>(qry, pModel);
            return RedirectToAction("Liste");
        }

        public IActionResult Ekle()
        {
            _model.Personel = new Personel();
            _model.Sehirler = GetSehirler();
            _model.Ulkeler = GetUlkeler();
            _model.Baslik = "Yeni Giriş";
            _model.BtnText = "Kaydet";
            _model.BtnClass = "btn btn-primary";

            return View("Genel", _model);
        }

        [HttpPost]
        public IActionResult Ekle(Personel pModel)
        {
            var qry = $"insert into Personel (Ad, Soyad, Maas, SehirId, UlkeId) values (@Ad, @Soyad, @Maas, @SehirId, @UlkeId)";
            Connect().ExecuteScalar<Personel>(qry, pModel);
            return RedirectToAction("Liste");
        }

        public IActionResult Sil(int Id)
        {
            _model.Personel = GetPersonel(Id);
            _model.Sehirler = GetSehirler();
            _model.Ulkeler = GetUlkeler();
            _model.Baslik = "Silme İşlemi";
            _model.BtnText = "Sil";
            _model.BtnClass = "btn btn-danger";

            return View("Genel", _model);
        }


        [HttpPost]
        public IActionResult Sil(Personel pModel)
        {
            var qry = $"Delete personel where Id = @Id";
            Connect().ExecuteScalar<int>(qry, pModel);
            return RedirectToAction("Liste");
        }
    }
}
