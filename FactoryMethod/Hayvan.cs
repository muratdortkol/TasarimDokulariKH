using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Hayvan:ICanli
    {
        public String BaslangicYili { get; set; }
        public void Yasam() {
            Console.WriteLine("Hayvan yaşıyor...");
        }
    }
}
