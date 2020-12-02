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
            Production prod1 = new Production("test", 10, 10000);

            prod1.ChangementNbCaisses += Prod1_ChangementNbCaisses;
            prod1.ChangementStatutProduction += Prod1_ChangementStatutProduction;
           
            prod1.DemarrerProduction();

            Console.ReadLine();

        }

        private static void Prod1_ChangementStatutProduction(Production prodSender, StatutProduction prodStatut)
        {
            Console.WriteLine(prodSender.StatutDeLaProduction.ToString());
        }

        private static void Prod1_ChangementNbCaisses(Production prodSender, StatutProduction prodStatut)
        {
            Console.WriteLine(prodSender.NbCaissesDepuisDemarrageTotal.ToString());
        }
    }
}
