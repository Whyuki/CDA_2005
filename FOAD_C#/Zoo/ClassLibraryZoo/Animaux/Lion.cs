using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public class Lion : AnimalDuZoo
    {

        public Lion(DateTime dateDeNaissance, bool estNeeAuZoo) : base(dateDeNaissance, estNeeAuZoo)
        {
        }
        public void Manger()
        {
            throw new System.NotImplementedException();
        }

  

        public override bool SeDeplacer()
        {
            Console.WriteLine(" /\\_/\\");
            Console.WriteLine("( o.o ) Je galope");
            Console.WriteLine(" > ^ <  \n");
            return true;
        }

   
    }
}
