using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FakeData
{
    public static class PlaceData
    {
        static Random rnd = new Random();
        static string[] city = { "İstanbul", "Trabzon", "Kayseri", "Aydın", "Kastamonu" };
        static string[] county = { "Esenler", "Çapa" };

        public static string GetCity()
        {
            return city[rnd.Next(0, city.Length)];
        }

        public static string GetCounty()
        {
            return county[rnd.Next(0, county.Length)];
        }
    }
}
