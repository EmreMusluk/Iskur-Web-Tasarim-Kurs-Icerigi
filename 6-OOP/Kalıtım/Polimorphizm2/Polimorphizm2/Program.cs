using Polimorphizm2.Data;

namespace Polimorphizm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun();
            urun.Id = 1;
            urun.UrunAd = "Kola";
            urun.Fiyat = 15;

            //Normalde bu şekilde urun yazdığımızda C# kendi metodu olan ToString() çalışır urun classında tostring metodunu override ettik. 
            Console.WriteLine(urun);
            Console.ReadLine();
        }
    }
}