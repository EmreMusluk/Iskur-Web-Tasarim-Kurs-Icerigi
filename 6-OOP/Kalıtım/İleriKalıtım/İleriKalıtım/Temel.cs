using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleriKalıtım
{
    internal class Temel : IInsan, IAdres
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public char Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cadde { get; set; }
        public string Il { get; set; }


        public List<string> AdresAl()
        {
            List<string> adres = new List<string>();
            adres.Add(FullName());
            adres.Add(Cadde);
            adres.Add(Il);
            return adres;
        }

        public virtual string FullName()
        {
            if (Cinsiyet == 'E')
            {
                return $"Sn Bay {Ad} {Soyad}";
            }
            else
                return $"Sn Bayan {Ad} {Soyad}";
        }

        public int YasHesapla()
        {
            return DateTime.Now.Year - DogumTarihi.Year;
        }
    }
}
