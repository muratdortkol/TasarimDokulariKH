using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Bitki:ICanli
    {
        public String BaslangicYili { get; set; }
        public void Yasam()
        {
            Console.WriteLine("Bitki yaşıyor...");
        }
    }
}
