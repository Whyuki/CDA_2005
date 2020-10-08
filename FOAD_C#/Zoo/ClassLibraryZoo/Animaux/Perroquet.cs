using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public class Perroquet : AnimalDuZoo, IParlable, IDeplacable
    {
        public Perroquet(DateTime dateDeNaissance, bool estNeeAuZoo) : base(dateDeNaissance, estNeeAuZoo)
        {
        }

        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine(" (o>");
            Console.WriteLine("_(()_ Je vole!");
            Console.WriteLine(" ||   \n");
            return true;
        }
        public bool Parler()
        {
            Console.WriteLine("perroquet : Au feu les pompiers, y'a le zoo qui brûle !");
            return true;
        }
    }
}
