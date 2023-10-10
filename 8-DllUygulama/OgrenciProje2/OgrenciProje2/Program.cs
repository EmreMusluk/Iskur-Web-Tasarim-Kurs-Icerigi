namespace OgrenciProje2
{
    using FakeData;
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Personel personel = new Personel();
                personel.Ad = FakeData.NameData.GetFirstName();
                personel.Soyad = FakeData.NameData.GetSurname();
                personel.City = FakeData.PlaceData.GetCity();
                personel.County = FakeData.PlaceData.GetCounty();
                Console.WriteLine($"{personel.Ad} {personel.Soyad} {personel.City}/{personel.County}");
            }

            Console.ReadLine();
        }
    }
}