using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "Hilal";
            o1.Soyad = "Arshil";
            o1.Sehir = "İstanbul";
            o1.Cadde = "Fatih";

            Ogrenci o2 = new Ogrenci();
            o2.Ad = "Omer";
            o2.Soyad = "Bulanık";
            o2.Sehir = "İstanbul";
            o2.Cadde = "Beylikdüzü";
             
            Ogrenci[] ogrenciler = new Ogrenci[] { o1, o2 };
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci.Unvan());
            }
            Console.ReadLine();
        }
    }
}
