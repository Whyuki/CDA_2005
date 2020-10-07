using ClassLibraryLepidoptere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestLepidoptere
{
    class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere l = new Lepidoptere(new DateTime(2020,01,01));
            l.SeDeplacer();
            l.SeMetamorphoser();
            l.SeDeplacer();
            l.SeMetamorphoser();
            l.SeDeplacer();
            l.SeMetamorphoser();
            l.SeDeplacer();
            l.SeMetamorphoser();
 
            Console.ReadLine();
        }
    }
}
