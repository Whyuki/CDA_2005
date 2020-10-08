using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Employes
{
    public class Gardien:IDeplacable, IParlable
    {
        public Gardien()
        {
        }

        public bool SeDeplacer()
        {
            Console.WriteLine("Je prends mes jambes à mon cou \\o/ !!!! \n");
            return true;
        }
        public bool Parler()
        {
            Console.WriteLine("gardien : Au feu les pompiers.. le zoo a brûlé !");
            return true;
        }
    }
}