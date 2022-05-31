

namespace PrototipDokusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba a1 = new Araba(3, "Ford");
            a1.arabaTipi = new ArabaTip(1);
            Araba a2 = a1.ShallowCopy();//referans taşır
            Araba a3 = a1.DeepCopy();//referansı yeni bir nesne taşınır

            OzellikGoster(a1);
            //OzellikGoster(a2);
            OzellikGoster(a3);

            a1.arabaTipi.tip = 2;
            //a3.arabaTipi.tip = 5;
            OzellikGoster(a1);
            OzellikGoster(a2);
            OzellikGoster(a3);

        }



        public static void OzellikGoster(Araba _a) {

            Console.WriteLine("**************************");
            Console.WriteLine("Teker Sayısı : {0}",_a.tekerSayisi);
            Console.WriteLine("Marka        : {0}",_a.marka);
            Console.WriteLine("Tip          : {0}", _a.arabaTipi.tip);    
            Console.WriteLine("**************************");
        
        }

    }

}
