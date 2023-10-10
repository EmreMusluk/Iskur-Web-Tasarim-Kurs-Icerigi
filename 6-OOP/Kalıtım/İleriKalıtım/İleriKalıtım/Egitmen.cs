using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleriKalıtım
{
    internal class Egitmen : Temel
    {
        public int Maas { get; set; }
        public string Unvan { get; set; }
        public int MaasHesapla()
        {
            return Convert.ToInt32(Maas * .70);
        }

        //Temel classımızda Fullname metodumuz var ve bu methodu virtual yaparız.
        //Virtual yaptığımız metodu Temel classından kalıtım alan classlarda Fullname metodunun içeriğini değiştirerek kullanabilriz.
        public override string FullName()
        {
            return $"Sn {Unvan} {Ad} {Soyad}";
        }
    }
}
