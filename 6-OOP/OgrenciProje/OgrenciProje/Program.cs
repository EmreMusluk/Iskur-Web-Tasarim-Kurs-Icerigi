using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciProje
{
    internal class Program
    {
        static List<Ogrenci> oList = new List<Ogrenci>();
        static void Main()
        {
            Console.Clear();
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("1-Liste Oluştur");
            Console.WriteLine("2-Liste Görüntüle");
            Console.WriteLine("3-Personel Sil");
            Console.WriteLine("4-Personel Güncelle");
            Console.WriteLine("5-Personel Ekle");
            Console.WriteLine("6-Personel Detay");


            string secim = Console.ReadLine();
            if (secim == "1")
            {
                ListeOlustur();
                Main();
            }
            else if (secim == "2")
            {
                PersonelListesi(oList);
                Console.ReadLine();
                Main();
            }
            else if (secim == "3")
            {
                PersonelSil();
                Console.ReadLine();
                Main();
            }
            else if (secim == "4")
            {
                PersonelGuncelle();
                Console.ReadLine();
                Main();
            }
            else if (secim == "5")
            {
                PersonelEkle();
                Console.ReadLine();
                Main();
            }
            else if (secim == "6")
            {
                PersonelDetay();
                Console.ReadLine();
                Main();
            }
        }

        static void PersonelDetay()
        {
            Console.WriteLine("Id ?");
            int id = Convert.ToInt32(Console.ReadLine());
            Ogrenci secilenOgrenci = oList.Where(o => o.Id == id).FirstOrDefault();
            Console.WriteLine("Personel Detay");
            foreach (var item in secilenOgrenci.AdresAl())
            {
                Console.WriteLine(item);
            }
        }

        static void PersonelGuncelle()
        {
            Console.WriteLine("Güncellemek istediğiniz id yi giriniz.");
            int guncellenecekId = Convert.ToInt32(Console.ReadLine());
            Ogrenci guncelogrenci = oList.Where(o => o.Id == guncellenecekId).FirstOrDefault();
            Console.WriteLine("Ad: ");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad: ");
            string soyad = Console.ReadLine();
            guncelogrenci.Ad = ad;
            guncelogrenci.Soyad = soyad;
            PersonelListesi(oList);
        }
        static void PersonelEkle() 
        {
            Ogrenci yeniOgrenci = new Ogrenci();
            Console.WriteLine("Güncellemek istediğiniz id yi giriniz.");
            Console.WriteLine("Ad: ");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyad: ");
            string soyad = Console.ReadLine();
            yeniOgrenci.Ad = ad;
            yeniOgrenci.Soyad = soyad;
            yeniOgrenci.Id = oList.Max(o => o.Id) + 1;
            oList.Add(yeniOgrenci);
            PersonelListesi(oList);
        }
        static void PersonelSil()
        {
            Console.WriteLine("Id ?");
            int SilinecekId = Convert.ToInt32(Console.ReadLine());
            Ogrenci silinecekogrenci = oList.Where(o => o.Id == SilinecekId).FirstOrDefault();
            PersonelListesi(oList);
        }
        static void PersonelListesi(List<Ogrenci> lst)
        {
            Console.WriteLine("Id  Ad  Soyad");
            foreach (var item in lst)
            {
                Console.WriteLine($"{item.Id} {item.Ad} {item.Soyad}");
            }
            ToplamAl(lst);
        }
        static void ToplamAl(List<Ogrenci> ls)
        {
            //1.yol
            //int toplamKisi=0;
            //int toplamKadın = 0;
            //int toplamErkek = 0;
            //int toplamMaas = 0;
            //int toplamErkekMaas=0;  
            //int toplamKadinMaas=0;  
            //double ortMaas=0;
            //double ortKadinMaas = 0;
            //double ortErkekMaas = 0;
            //foreach (var item in ls)
            //{
            //    toplamKisi++;
            //    toplamMaas +=item.Maas;
            //    if (item.Cinsiyet=="E")
            //    {
            //        toplamErkekMaas += item.Maas;
            //        toplamErkek++;
            //    }
            //    else
            //    {
            //        toplamKadinMaas += item.Maas;
            //        toplamKadin++;
            //    }
            //}
            //ortErkekMaas = toplamErkekMaas / toplamErkek;
            //ortKadınMaas = toplamKadinMaas / toplamKadin;
            //ortMaas = toplamMaas / toplamKisi;

            //2.Yol Lampda expression
            int toplamKisi = ls.Count();
            int toplamMaas = ls.Sum(x => x.Maas);
            int toplamKadın = ls.Where(x => x.Cinsiyet == "K").Count();
            int toplamErkek = ls.Where(x => x.Cinsiyet == "E").Count();
            int toplamKadinMaas = ls.Where(x => x.Cinsiyet == "K").Sum(x => x.Maas);
            int toplamErkekMaas = ls.Where(x => x.Cinsiyet == "E").Sum(x => x.Maas);
            double ortMaas = ls.Average(x => x.Maas);
            double ortErkekMaas = ls.Where(x => x.Cinsiyet == "E").Average(x => x.Maas);
            double ortKadinMaas = ls.Where(x => x.Cinsiyet == "K").Average(x => x.Maas);
            Console.WriteLine("Toplamlar");
            Console.WriteLine("------------------------");
            Console.WriteLine("Toplam Kişi " + toplamKisi);
            Console.WriteLine("Toplam Kadın " + toplamKadın);
            Console.WriteLine("Toplam Erkek " + toplamErkek);
            Console.WriteLine("Toplam Maaş " + toplamMaas);
            Console.WriteLine("Toplam Kadın Maaş " + toplamKadinMaas);
            Console.WriteLine("Toplam Erkek Maaş " + toplamErkekMaas);
            Console.WriteLine("Ortalama Maaş " + ortMaas);
            Console.WriteLine("Ortalama Erkek Maaş " + ortErkekMaas);
            Console.WriteLine("Ortalama Kadın Maaş " + ortKadinMaas);
            Console.WriteLine("-------------------------");
        }
        static void ListeOlustur()
        {
            Random random = new Random();
            for (int i = 1; i < 21; i++)
            {
                Ogrenci o = new Ogrenci();
                o.Maas = random.Next(4000, 20000);
                o.Ad = FakeData.NameData.GetFirstName();
                o.Cadde = FakeData.PlaceData.GetStreetName();
                int cns = random.Next(0, 2);
                if (cns == 0)
                {
                    o.Cinsiyet = "K";
                }
                else o.Cinsiyet = "E";

                int yas = random.Next(20, 50);
                o.Dogumtarihi = DateTime.Now.AddYears(yas * -1);
                o.Id = i;
                o.Ilce = FakeData.PlaceData.GetCounty();
                o.Sehir = FakeData.PlaceData.GetCity();
                o.Soyad = FakeData.NameData.GetSurname();
                o.KapiNo = random.Next(1, 220);
                oList.Add(o);
            }
        }
    }
}
