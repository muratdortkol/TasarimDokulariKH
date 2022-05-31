using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik
{
    public class Daire : IGMenkul
    {

        public long Fiyat { get; set; }
        public float Alan { get; set; }
        public string Konum { get; set; }
        public byte Yas { get; set; }
        public byte Kat { get; set; }
        public byte OdaSayisi { get; set; }
        public void AlSat(string islem)
        {
            Console.WriteLine("Yapılan işlem : {0}", islem);

        }
    }
}
