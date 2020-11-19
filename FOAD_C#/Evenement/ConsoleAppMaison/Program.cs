using ClassLibraryTemp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMaison
{
    class Program
    {
        static void Main(string[] args)
        {

            // je m'interresse au fait que la temperature interieure atteint une des temperatures d'alerte definies
            float[] tempAlerte = { 13, 16, 19, 22 };
            Temperature temperatureInterieure = new Temperature(10, tempAlerte);

            temperatureInterieure.Alerte += TemperatureInterieur_Alerte;

            while (temperatureInterieure.Degres < 22)
            {
                Console.WriteLine( temperatureInterieure.Degres + "°C");
                temperatureInterieure.Monter();
            }

            if (temperatureInterieure.Degres > 22)
            {
                Console.WriteLine(temperatureInterieure.Degres + "°C");
                temperatureInterieure.Diminuer();
            }
            

            Console.ReadLine();
        }

        private static void TemperatureInterieur_Alerte(Temperature sender)
        {
            Console.WriteLine("Alerte : il fait " + sender.Degres + "°C à l'interieur");
        }
    }
}
