using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleriKalıtım
{
    internal class Ogrenci : Temel
    {
        public decimal Vize { get; set; }
        public decimal Final { get; set; }
        decimal NotHesaplama()
        {
            return (Final + Vize) / 2;
        }
    }
}
