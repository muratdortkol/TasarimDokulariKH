using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface ICanli
    {
        string BaslangicYili { get; set; }
        void Yasam();
    }
}
