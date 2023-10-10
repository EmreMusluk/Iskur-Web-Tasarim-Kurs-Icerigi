using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    internal class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        private string KartNo1;
        public string KartNo
        {
            get => KartNo1;
            set => KartNo1 = value.Substring(0, 2) + "*****" + value.Substring(value.Length - 4);
        }
    }
}
