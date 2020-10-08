using ClassLibraryZoo.Animaux;
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
            mesAnimauxDuZoo.Add(new Lapin());
            mesAnimauxDuZoo.Add(new Lapin());
            mesAnimauxDuZoo.Add(new Lion());
            mesAnimauxDuZoo.Add(new Perroquet());

            //le feu arrive, il faut deplacer tout le monde
            foreach(AnimalDuZoo a in mesAnimauxDuZoo)
            {
                a.SeDeplacer();
            }

            //il faut mettre un peu d'ordre dans l'evacuation...du plus vieux au plus jeune


            //mais que fait le gardien? il reste sur place?


            //et qui va appeller les secours? 
        }
    }
}
