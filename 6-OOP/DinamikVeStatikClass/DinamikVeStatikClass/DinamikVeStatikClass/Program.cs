using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamikVeStatikClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data d1 = new Data();
            Data d2 = new Data();
            Data d3 = new Data();

            Console.WriteLine("Data1-Sayi2 " + d1.sayi2);
            Console.WriteLine("Data2-Sayi2 " + d2.sayi2);
            Console.WriteLine("Statik Sayi " + Data.statikSayi);

            d1.sayi2 = 3;
            Data.statikSayi = 4;

            Console.WriteLine("Data1-Sayi2 " + d1.sayi2);
            Console.WriteLine("Data2-Sayi2 " + d2.sayi2);
            Console.WriteLine("Statik Sayi " + Data.statikSayi);

            Console.ReadLine();
        }
    }

    class Data
    {
        public static int statikSayi = 1;
        public int sayi2 = 2;
    }




}
