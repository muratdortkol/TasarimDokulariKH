using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IGMenkul> daireler = new List<IGMenkul>();
            List<IGMenkul> arsalar = new List<IGMenkul>();
            List<IGMenkul> isyerleri = new List<IGMenkul>();


            daireler.Add(new Daire() { Fiyat = 100 });
            daireler.Add(new Daire() { Fiyat = 500 });


            arsalar.Add(new Arsa() { Fiyat = 1000 });
            arsalar.Add(new Arsa() { Fiyat = 10000 });


            isyerleri.Add(new IsYeri() { Fiyat = 5000 });
            isyerleri.Add(new IsYeri() { Fiyat = 50000 });


            Console.WriteLine("Daireler : ");
            ListeYazdir(daireler);
            Console.WriteLine("Arsalar: ");
            ListeYazdir(arsalar);
            Console.WriteLine("İş yerleri: ");
            ListeYazdir(isyerleri);



            List<IGMenkul> TumMenkuller = new List<IGMenkul>();
            TumMenkuller.AddRange(daireler);
            TumMenkuller.AddRange(isyerleri);
            TumMenkuller.AddRange(arsalar);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Tüm Menkuller");
            ListeYazdir(TumMenkuller);

        }


        public static void ListeYazdir(List<IGMenkul> _list)
        {

            for (int i = 0; i < _list.Count; i++)
            {
                Console.WriteLine("Menkulun Fiyatı : {0}", _list[i].Fiyat);
            }
        }



    }
}
