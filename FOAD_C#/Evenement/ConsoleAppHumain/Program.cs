using ClassLibraryTemp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHumain
{
    class Program
    {
        static void Main(string[] args)
        {
            //declencher rdv chez le medecin si l'evenement Fievre arrive
            Temperature temperatureDuCorps = new Temperature(37);

            temperatureDuCorps.Fievre += TemperatureDuCorps_Fievre;

            Console.WriteLine("Vous avez " + temperatureDuCorps.Degres + "°C");

            while (temperatureDuCorps.Degres < 38)
            {
                temperatureDuCorps.Monter();
            }

            while (temperatureDuCorps.Degres > 37)
            {
                temperatureDuCorps.Diminuer();
            }

            Console.WriteLine("Vous avez " + temperatureDuCorps.Degres + "°C");

            Console.ReadLine();
        }

        private static void TemperatureDuCorps_Fievre(Temperature sender)
        {
            Console.WriteLine("Vous avez " + sender.Degres + "°C : fièvre détectée, rendez vous chez le médecin programmé !");
        }

    }
}
