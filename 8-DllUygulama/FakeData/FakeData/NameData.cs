using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FakeData
{
    public static class NameData
    {
        static Random rnd = new Random();
        public static string[] Isimler = { "Ali", "Veli", "Hilal", "Emre", "Sevgi", "Suzan", "Gizem", "Arzu" };
        public static string[] SoyIsimler = { "Arslan", "Seven", "Ay", "Biçen", "Sayar", "Musluk" };

        public static string GetFirstName()
        {
            return Isimler[rnd.Next(0, Isimler.Length)];
        }
        public static string GetSurname()
        {
            return SoyIsimler[rnd.Next(0, SoyIsimler.Length)];
        }
    }
}
