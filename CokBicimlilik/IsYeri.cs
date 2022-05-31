using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik
{
    internal class IsYeri : IGMenkul
    {
        public long Fiyat { get; set; }
        public float Alan { get; set; }
        public string Konum { get; set; }
        public byte Kat { get; set; }
        public bool DevrenMi { get; set; }
        public void AlSat(string islem)
        {
            Console.WriteLine("Yapılan işlem : {0}", islem);
        }
    }
}
