using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmOrnek
{
    internal class Silindir : BaseUrun
    {
        public double YariCap { get; set; }
        public override double TabanAlaniHesapla()
        {
            return Math.PI * Math.Pow(YariCap, 2);
        }
    }
}
