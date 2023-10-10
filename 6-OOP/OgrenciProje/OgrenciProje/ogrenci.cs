using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciProje
{
    internal class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime Dogumtarihi { get; set; }
        public string Cadde { get; set; }
        public int KapiNo { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }
        public int Maas { get; set; }

        public string Unvan()
        {
            string unvan = " ";
            if (Cinsiyet == "E")
            {
                unvan = $"Sn Bay {Ad} {Soyad}";
            }
            else
            {
                unvan = $"Sn Bayan {Ad} {Soyad}";
            }
            return unvan;
        }
        public int Yas()
        {
            DateTime bugun = DateTime.Now;
            int yas = bugun.Year - Dogumtarihi.Year;
            DateTime dogumGun = DateTime.Now.AddYears(yas);
            if (dogumGun < bugun)
            {
                yas--;
            }
            return yas;
        }

        public List<string> AdresAl()
        {
            List<string> adres = new List<string>();
            adres.Add(Unvan());
            adres.Add(Cadde);
            adres.Add(KapiNo.ToString());
            adres.Add(Ilce + "/" + Sehir);
            return adres;
        }
    }
}
