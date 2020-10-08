using ClassLibraryZoo.Animaux;
using ClassLibraryZoo.Contrats;
using ClassLibraryZoo.Employes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnimalDuZoo> mesAnimauxDuZoo = new List<AnimalDuZoo>();
            mesAnimauxDuZoo.Add(new Lapin(new DateTime(1994, 07, 21), true));
            mesAnimauxDuZoo.Add(new Lapin(new DateTime(1990, 07, 20), true));
            mesAnimauxDuZoo.Add(new Lion(new DateTime(1991, 06, 08), true));
            mesAnimauxDuZoo.Add(new Perroquet(new DateTime(2019, 03, 25), true));

            Gardien georges = new Gardien();

            //le feu arrive, il faut deplacer tout le monde

            Console.WriteLine("Le feu arrive :");
            Console.WriteLine("            .  '   .   '  .  '  .");
            Console.WriteLine("   (    , )       (.   )  (   ',    )");
            Console.WriteLine("    .' ) ( . )    ,  ( ,     )   ( .");
            Console.WriteLine(" ). , ( .   (  ) ( , ')  .' (  ,    )");
            Console.WriteLine("(_,) . ), ) _) _,')  (, ) '. )  ,. (' )");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

            foreach (AnimalDuZoo a in mesAnimauxDuZoo)
            {
                a.SeDeplacer();
            }

            //il faut mettre un peu d'ordre dans l'evacuation...du plus vieux au plus jeune

            Console.WriteLine("Du plus vieux au plus jeune :");
            mesAnimauxDuZoo.Sort();

            foreach (AnimalDuZoo a in mesAnimauxDuZoo)
            {
                a.SeDeplacer();
            }
          
            //mais que fait le gardien? il reste sur place?

            // liste IDeplacable contenant les IDeplacables : les animaux du zoo et le gardien
            List<IDeplacable> mesIdeplacables = new List<IDeplacable>();
            mesIdeplacables.Add(georges);
            mesIdeplacables.AddRange(mesAnimauxDuZoo);

            Console.WriteLine("Mais que fait le gardien ?");
            //deplace les animaux et le gardien
            foreach (IDeplacable d in mesIdeplacables)
            {
                d.SeDeplacer();
            }

            //et qui va appeller les secours? 

            // liste IParlable contenant les Iparlables : le perroquet et le gardien
            Console.WriteLine("Et qui va appeller les secours ?");
            List<IParlable> mesIparlables = new List<IParlable>();

            foreach (AnimalDuZoo a in mesAnimauxDuZoo)
            {
                if (a is IParlable) // si l'animal est IParlable
                {
                    mesIparlables.Add((IParlable)a);
                }

            }
            mesIparlables.Add(georges);
            // demande aux Iparlables d'appeller les secours
            foreach (IParlable p in mesIparlables)
            {
                p.Parler();
            }

            Console.WriteLine("Tous le monde est sauvé :D");
            Console.ReadLine();
        }
    }
}
