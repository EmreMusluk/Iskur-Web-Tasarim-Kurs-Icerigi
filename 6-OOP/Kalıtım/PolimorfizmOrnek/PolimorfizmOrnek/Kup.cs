using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmOrnek
{
    internal class Kup : BaseUrun
    {
        public double KenarUzunlugu { get; set; }
        public override double TabanAlaniHesapla()
        {
            return Math.Pow(KenarUzunlugu, 2);
        }
    }
}
