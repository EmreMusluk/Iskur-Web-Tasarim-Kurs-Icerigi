using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverloading
{
    internal class Hesaplama
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }
        public decimal Topla(decimal a, decimal b)
        {
            return a + b;
        }
        public decimal Topla(decimal a, int b)
        {
            return b + a;
        }
        public string Topla(string a, string b)
        {
            return a + b;
        }
        public int Topla(int a, int b, int c)
        {
            return a + b + c;
        }
        public static int Topla(int[] d)
        {
            int top = 0;
            foreach (var item in d)
            {
                top += item;
            }
            return top;
        }

    }
}
