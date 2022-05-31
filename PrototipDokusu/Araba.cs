using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipDokusu
{
    public class Araba
    {
        public int tekerSayisi;
        public String marka;
        public ArabaTip arabaTipi;

        public Araba(int tSayisi, string marka) {
            this.tekerSayisi = tSayisi;
            this.marka = marka;        
        }

        public Araba ShallowCopy() {
            return (Araba)this.MemberwiseClone();        
        }

        public Araba DeepCopy() {
            Araba clone = (Araba)this.MemberwiseClone();
            clone.arabaTipi = new ArabaTip(this.arabaTipi.tip);
            clone.marka = this.marka;
            return clone;        
        }


    }
}
