using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public class Perroquet : AnimalDuZoo
    {
        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je vole!");
            return true;
        }
    }
}
