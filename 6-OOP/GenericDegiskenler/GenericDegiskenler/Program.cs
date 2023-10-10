using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 40, 50 };
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

            ArrayList sayilar2 = new ArrayList() { 1, 2, 6, 5 };
            sayilar2.Add(1);
            sayilar2.Add("asds");

            foreach (var item in sayilar2)
            {
                Console.WriteLine(item);
            }

            List<int> sayilar3 = new List<int>();
            sayilar3.Add(1);
            sayilar3.Add(2);

            foreach (var item in sayilar3)
            {
                Console.WriteLine(item);
            }

            List<object> sayilar4 = new List<object>();
            sayilar4.Add(1);
            sayilar4.Add("dfdf");


            List<Personel> personelList = new List<Personel>();
            Personel p = new Personel();
            p.Ad = "Hilal";
            Personel personel2 = new Personel();
            p.Ad = "Gizem";
            personelList.Add(p);
            personelList.Add(personel2);
            foreach (var personel in personelList)
            {
                Console.WriteLine(personel.Ad);
            }

            Console.ReadLine();
        }
    }
}
