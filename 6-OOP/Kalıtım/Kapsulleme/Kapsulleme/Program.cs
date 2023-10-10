namespace Kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.KartNo = "15135415165654643";
            Console.WriteLine(musteri.KartNo);

            Console.ReadLine();
        }
    }
}