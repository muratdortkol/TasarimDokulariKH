using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fabrika f = new Fabrika();
            ICanli c1 = f.Uret(1);
            ICanli c2 = f.Uret(2);
            ICanli c3 = f.Uret(3);

            c1.Yasam();
            c2.Yasam();
            c3.Yasam();
        }
    }
}
