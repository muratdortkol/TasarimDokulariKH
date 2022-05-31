using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik
{
    internal interface IGMenkul
    {
        public long Fiyat { get; set; }
        public float Alan { get; set; }
        public string Konum { get; set; }
        public void AlSat(string islem);

    }
}
