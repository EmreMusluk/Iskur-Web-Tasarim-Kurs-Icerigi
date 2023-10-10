using Dapper;
using Microsoft.AspNetCore.Mvc;
using PersonelProje.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PersonelProje.Controllers
{
    public class UlkeController : BaseController
    {
        public UlkeController(IConfiguration config) : base(config)
        {

        }
        public IActionResult Liste()
        {
            var qry = "select * from Ulke";
            var ulkeler = Connect().Query<Ulke>(qry).ToList();

            return View(ulkeler);
        }

        [HttpGet]
        public Ulke UlkeSec(string Id)
        {
            var qry = $"select * from Ulke where Id = '{Id}'";
            //FirstOrDefault ilk kaydı getirir.
            return Connect().Query<Ulke>(qry).FirstOrDefault();
        }

        //Yazmasakta Default HttpGet'dir.
        [HttpGet]
        public IActionResult Guncelle(string Id)
        {
            return View(UlkeSec(Id));
        }

        //[HttpPost]
        //public IActionResult Guncelle(string Id, string UlkeAd)
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Guncelle(Ulke ulke)
        {
            var qry = $"Update Ulke set UlkeAd = @UlkeAd where Id = @Id";
            //1. Yol
            Connect().ExecuteScalar<int>(qry, ulke);

            //2. Yol Arka planda ExecuteScalar bu işi yapıyor.
            //DynamicParameters par = new DynamicParameters();
            //par.Add("@UlkeAd", ulke.UlkeAd);
            //par.Add("Id", ulke.Id);
            //con.ExecuteScalar<int>(qry, par);

            return RedirectToAction("Liste");
        }

        [HttpGet]
        public IActionResult Sil(string Id)
        {
            return View(UlkeSec(Id));
        }


        [HttpPost]
        public IActionResult Sil(Ulke ulke)
        {
            var qry = $"Delete Ulke where Id = @Id";
            Connect().ExecuteScalar<int>(qry, ulke);
            return RedirectToAction("Liste");
        }

        public IActionResult Ekle(Ulke yeniUlke)
        {
            return View(yeniUlke);
        }

        [HttpPost]
        public IActionResult Ekle(Ulke ulke, bool d)
        {
            var qry = $"insert into Ulke (Id, UlkeAd) Values(@Id, @UlkeAd)";
            Connect().ExecuteScalar<int>(qry, ulke);
            return RedirectToAction("Liste");
        }

    }
}
