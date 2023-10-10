using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernOOP
{
    internal class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public string Cadde { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }
        public int KapiNo { get; set; }
        public string Unvan()
        {
            if (Cinsiyet == "E")
            {
                return "Sn Bay " + Ad + " " + Soyad;
            }
            else
            {
                return "Sn Bayan " + Ad + " " + Soyad;
            }
        }
    }
}
