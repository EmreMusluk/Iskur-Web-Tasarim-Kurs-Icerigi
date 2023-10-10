using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Ali", "Veli", "Ayşe" };
            int[] idler = { 10, 20, 30 };
            Console.WriteLine("Id giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (id == 10)
            {
                Console.WriteLine("ismi: " + "Ali");
            }
            else if (id == 20)
            {
                Console.WriteLine("ismi: " + "Veli");
            }
            else if (id == 30)
            {
                Console.WriteLine("ismi: " + "Ayşe");
            }
            else
            {
                Console.WriteLine("Yanlış id");
            }
        }
    }
}
