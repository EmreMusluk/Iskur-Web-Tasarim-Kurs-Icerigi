using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Ali", "Veli", "Ayşe" };
            int[] idler = { 10, 20, 30 };
            Console.WriteLine("Id giriniz: ");
            int index = Convert.ToInt32(Console.ReadLine());
            int indis = Array.IndexOf(idler, index);
            Console.WriteLine("İsim : " + isimler[indis]);
            Console.ReadLine();
        }
    }
}
