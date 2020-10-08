using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public abstract class AnimalDuZoo:IDeplacable
    {
        private DateTime dateDeNaissance;
        bool estNeeAuZoo;

        protected AnimalDuZoo():this(DateTime.Today,false)
        {
        }

        protected AnimalDuZoo(DateTime dateDeNaissance, bool estNeeAuZoo)
        {
            this.dateDeNaissance = dateDeNaissance;
            this.estNeeAuZoo = estNeeAuZoo;
        }


        public abstract bool SeDeplacer();
    }
}
