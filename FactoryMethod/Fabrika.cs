using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{


    public class Fabrika
    {
        
        public ICanli Uret(int tip) {
            switch (tip)
            {
                case 1:
                    return new Insan();
                    break;
                case 2:
                    return new Hayvan();
                    break;
                case 3:
                    return new Bitki();
                    break;
                default:
                    Console.WriteLine("Yanlış üretim değeri girildi.");
                    return null;
                    break;
            }

        }


    }
}
