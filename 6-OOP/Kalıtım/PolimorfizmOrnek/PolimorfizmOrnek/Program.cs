namespace PolimorfizmOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen d = new Dikdortgen();
            d.KisaKenar = 5;
            d.UzunKenar = 6;
            d.Yukseklik = 3;
            d.Id = 1;
            d.UrunAd = "Dikdörtgen";

            Yazdirma(d);

            Kup k = new Kup();
            k.Yukseklik = 5;
            k.Id = 2;
            k.UrunAd = "Küp";

            Yazdirma(k);

            Silindir s = new Silindir();
            s.Id = 3;
            s.YariCap = 7;
            s.UrunAd = "Silindir";
            s.Yukseklik = 9;

            Yazdirma(s);

            void Yazdirma(BaseUrun urun)
            {
                Console.WriteLine(urun.Id + " " + urun.UrunAd);
                Console.WriteLine("Taban Alanı :" + urun.TabanAlaniHesapla());
                Console.WriteLine("Hacim :" + urun.HacimHesapla());
                Console.WriteLine("Fire :" + urun.FireHesapla());
                Console.WriteLine("*********");
            }
        }
    }
}