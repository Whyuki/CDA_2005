using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDemoProxyEspace;

namespace ConsoleAppDemoProxyEspace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vaisseau spatial Faucon Millenium, piloté par Han Solo uniquement

            //sans proxy
            IVaisseauSpatial faucon = new FauconMillenium();
            faucon.Decoller();

            Console.WriteLine("_____________________________________________________________________________");


            //avec proxy

            Pilote piloteA = new Pilote("Nyan SoLow");
            IVaisseauSpatial faucon1 = new FauconMilleniumProxy(piloteA);
            faucon1.Decoller();

            Console.WriteLine("_____________________________________________________________________________");


            Pilote piloteB = new Pilote("Han Solo");
            IVaisseauSpatial faucon2 = new FauconMilleniumProxy(piloteB);
            faucon2.Decoller();

            Console.WriteLine("_____________________________________________________________________________");


            Pilote piloteC = new Pilote("R2D2");
            IVaisseauSpatial faucon3 = new FauconMilleniumProxy(piloteC);
            faucon3.Decoller();

            Console.WriteLine("_____________________________________________________________________________");


            Console.ReadLine();
        }
    }
}
