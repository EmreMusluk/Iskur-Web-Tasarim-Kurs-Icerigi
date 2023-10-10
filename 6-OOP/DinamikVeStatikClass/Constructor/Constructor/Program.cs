namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            o.Ad = "Selin";
            o.Soyad = "Günaydın";
            o.Id = 1;
            Console.WriteLine(o.Ad + " " + o.Soyad + " " + o.KayitTarih);
            Console.ReadLine();
        }
    }
}