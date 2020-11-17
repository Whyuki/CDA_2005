using ClassLibraryPersonne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestEvenementMajorite
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne("Robert");
            Personne p2 = new Personne("Berthe");

            p.JeViensDEtreMajeur += P_JeViensDEtreMajeur;
            p2.JeViensDEtreMajeur += P_JeViensDEtreMajeur;

            p.JeRisqueUneCrise += P_JeRisqueUneCrise;
            p2.JeRisqueUneCrise += P_JeRisqueUneCrise;

            for (int i = 0; i < 100; i++)
            {
                p.VieillirDUnAn();
                p2.VieillirDUnAn();
            }

            Console.ReadLine();
        }

        private static void P_JeRisqueUneCrise(Personne sender, string typeDeCrise)
        {
            Console.WriteLine(sender.Name + " risque de faire une " + typeDeCrise);
        }

        private static void P_JeViensDEtreMajeur(Personne sender)
        {
            // sender.Age--;
            Console.WriteLine("Ca y est " + sender.Name + " est majeur! Il peut se debrouiller par lui même");
        }
    }
}
