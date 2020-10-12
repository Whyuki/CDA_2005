using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryForet;

namespace ConsoleAppTestForet
{
    class Program
    {
        static void Main(string[] args)
        {

            // creer un arbre du printemps
            //afficher l'etat de l'arbre avec un ToString

            //ajouter un comportement passer en automne (feuille jaune ou rouge)
            //afficher l'état de l'arbre

            Arbre a = new Arbre(800);

     
            a.AddFeuille(15, EnumCouleur.Vert, EnumFormeFeuille.ovale);
            a.AddFeuille(18, EnumCouleur.Vert, EnumFormeFeuille.ovale);


            Console.WriteLine(a.ToString());

            // test arbre sans feuille

            Arbre a2 = new Arbre(1500);
            Console.WriteLine(a2.ToString());

            // passage automne 

            Console.WriteLine("C'est le début de l'automne");
            a.PassageAutomne();
            Console.WriteLine(a.ToString());

            Console.WriteLine("L'automne continue");
            a.PassageAutomne();
            Console.WriteLine(a.ToString());

            Console.WriteLine("L'automne toujours l'automne");
            a.PassageAutomne();
            Console.WriteLine(a.ToString());

            Console.WriteLine("L'automne toujours l'automne");
            a.PassageAutomne();
            Console.WriteLine(a.ToString());

            // test arbre

            a.PerdreFeuilles();
            Console.WriteLine(a.ToString());

           


            Console.ReadLine();
        }
    }
}
