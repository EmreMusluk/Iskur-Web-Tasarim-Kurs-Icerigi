namespace BasitKalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            o.Ad = "Sema";
            o.Adres.Cadde = "asad";

            foreach (var item in o.AdresAl())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}