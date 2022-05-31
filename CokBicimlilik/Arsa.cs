using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik
{
    internal class Arsa : IGMenkul
    {

        public long Fiyat { get; set; }
        public float Alan { get; set; }
        public string Konum { get; set; }
        public bool Imarli { get; set; }
        public void AlSat(string islem)
        {
            Console.WriteLine("Yapılan işlem : {0}", islem);
        }



    }
}
