using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public class Lapin : AnimalDuZoo
    {
        int lgOreilleEnCm;

        public Lapin():base()
        {
            this.lgOreilleEnCm = 10;
        }

        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je saute");
            return true;
        }
    }
}
