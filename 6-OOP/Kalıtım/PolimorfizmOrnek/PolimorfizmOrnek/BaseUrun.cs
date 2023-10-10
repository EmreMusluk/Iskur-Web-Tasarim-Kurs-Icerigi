using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmOrnek
{
    internal class BaseUrun : IUrun
    {
        public int Id { get; set; }
        public string UrunAd { get; set; }
        public double Yukseklik { get; set; }


        public double FireHesapla()
        {
            return (HacimHesapla() * .30);
        }

        public double HacimHesapla()
        {
            return TabanAlaniHesapla() * Yukseklik;
        }

        public virtual double TabanAlaniHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
