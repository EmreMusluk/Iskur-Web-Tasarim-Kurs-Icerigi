namespace HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("1-Çarp 2-Böl 3-Topla 4-Çıkar");
            string ?islem = Console.ReadLine();
            Console.WriteLine("Birinci sayıyı giriniz : ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Sonuç: " + Hesapla(sayi1, sayi2,  islem)); 
        }

        static decimal Hesapla(decimal sayi1, decimal sayi2, string islem)
        {
            decimal sonuc = 0;
            switch (islem)
            {
                case "3":
                    sonuc = sayi1 + sayi2;
                    break;
                case "1":
                    sonuc = sayi1 * sayi2;
                    break;
                case "2":
                    sonuc = sayi1 / sayi2;
                    break;
                case "4":
                    sonuc = sayi1 - sayi2;
                    break;
                default:
                    break;
            }
            return sonuc;
        }
    }
}