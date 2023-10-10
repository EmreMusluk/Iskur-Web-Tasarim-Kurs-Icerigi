using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmOrnek
{
    internal class Dikdortgen : BaseUrun
    {
        public double KisaKenar { get; set; }
        public double UzunKenar { get; set; }

        public override double TabanAlaniHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }
}
