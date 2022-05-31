using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekillikDokusu
{
    public class TekilSinif
    {
        public static TekilSinif sinifinornegi;
        public String kontrol;

        private TekilSinif(String deger)
        {
            kontrol = deger;
        }

        public static TekilSinif CreateObject(String deger)
        {
            if (sinifinornegi == null)
            {
                sinifinornegi = new TekilSinif(deger);
            }
            return sinifinornegi;
        }
    }
}
