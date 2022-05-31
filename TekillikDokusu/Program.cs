using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekillikDokusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TekilSinif o1 = TekilSinif.CreateObject("abc");
            TekilSinif o2 = TekilSinif.CreateObject("xyz");
            Console.WriteLine(o1.kontrol);
            Console.WriteLine(o2.kontrol);
            Console.WriteLine("nesne1: " + o1.GetHashCode());
            Console.WriteLine("nesne2: " + o2.GetHashCode());
        }
    }
}
