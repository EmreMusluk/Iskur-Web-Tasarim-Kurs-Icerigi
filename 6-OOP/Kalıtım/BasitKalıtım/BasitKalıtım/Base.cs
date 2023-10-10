using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitKalıtım
{
    internal class Base
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Adres Adres { get; set; }
        public Base()
        {
            Adres = new Adres();
        }
        public string FullName()
        {
            return Ad + Soyad; 
        }

        public List<string> AdresAl()
        {
           List<string> adres = new List<string>();
            adres.Add(FullName());
            adres.Add(Adres.Cadde);
            adres.Add(Adres.Sokak);
            return adres;
        }
}
}
