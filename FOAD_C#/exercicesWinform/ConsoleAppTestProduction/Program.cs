using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryProduction;

namespace ConsoleAppTestProduction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Production productionA = new Production(new CaisseTypeA());
            
            Console.WriteLine("A");
            Console.WriteLine(productionA.CaisseAProduire.NbCaissesAProduire);
            Console.WriteLine(productionA.CaisseAProduire.NbCaissesAProduireParHeure);
            
            Console.WriteLine(productionA.StatutDeLaProduction.ToString());
            productionA.DemarrerProduction();
            Console.WriteLine(productionA.StatutDeLaProduction.ToString());
            productionA.ArreterProduction();
            Console.WriteLine(productionA.StatutDeLaProduction.ToString());


            Production productionB = new Production(new CaisseTypeB());

            Console.WriteLine("B");
            Console.WriteLine(productionB.CaisseAProduire.NbCaissesAProduire);
            Console.WriteLine(productionB.CaisseAProduire.NbCaissesAProduireParHeure);

            Production productionC = new Production(new CaisseTypeC());


            Console.WriteLine("C");
            Console.WriteLine(productionC.CaisseAProduire.NbCaissesAProduire);
            Console.WriteLine(productionC.CaisseAProduire.NbCaissesAProduireParHeure);


            Console.ReadLine();

        }
    }
}
