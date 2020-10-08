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

        public Lapin(DateTime dateDeNaissance, bool estNeeAuZoo) :base( dateDeNaissance, estNeeAuZoo)
        {
            this.lgOreilleEnCm = 10;
        }

        public void Manger()
        {
            throw new System.NotImplementedException();
        }


        public override bool SeDeplacer()
        {
            Console.WriteLine("( )_( )");
            Console.WriteLine("(='.'=) Je saute");
            Console.WriteLine("(°)_(°)  \n");
            return true;
        }

     
    }
}
