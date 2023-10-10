namespace CuzdanHesapla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Basla();
        }

        public static void Basla()
        {
            Console.WriteLine("Kaç Tl'n var?");
            decimal tlTut = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Kaç Dolar'ın var?");
            decimal dolTut = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Kaç Euro'n var?");
            decimal euroTut = Convert.ToDecimal(Console.ReadLine());
            ToplamParaHesapla(tlTut, dolTut, euroTut);
        }

        public static void ToplamParaHesapla(decimal tl, decimal dol, decimal euro)
        {
            Console.WriteLine("Dolar Kuru ? ");
            decimal dolKur = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Dolar Kuru ? ");
            decimal euroKur = Convert.ToDecimal(Console.ReadLine());
            dol = dolKur * dol;
            euro = euroKur * euro;
            decimal toplam = dol + euro + tl;
            Console.WriteLine("Toplam Para : " + toplam);
        }

    }
}