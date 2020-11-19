using ClassLibraryTemp;
using System;

namespace ConsoleAppMeteo
{
    class Program
    {
        static void Main(string[] args)
        {

            // je m'interresse au fait que la temperature de gel est là, et que mon jardin risque de gelee..
            Temperature temperatureExterieure = new Temperature(3);

            temperatureExterieure.Gel += TemperatureExterieur_Gel;

            while (temperatureExterieure.Degres > 0)
            {
                Console.WriteLine(temperatureExterieure.Degres + "°C");
                temperatureExterieure.Diminuer();
            }

            while (temperatureExterieure.Degres <= 0)
            {
                Console.WriteLine(temperatureExterieure.Degres + "°C");
                temperatureExterieure.Monter();
            }


            Console.ReadLine();
        }

        private static void TemperatureExterieur_Gel(Temperature sender)
        {
            Console.WriteLine("Il fait " + sender.Degres + "°C dehors : gel détecté, rentrez vos plantes !");
        }
    }
}
