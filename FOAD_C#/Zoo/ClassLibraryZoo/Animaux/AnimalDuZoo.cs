using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Animaux
{
    public abstract class AnimalDuZoo: IComparable, IComparable<AnimalDuZoo>, IDeplacable
        //, IParlable
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


        public DateTime DateDeNaissance
        {
            get => dateDeNaissance;
            //set => dateDeNaissance = value; 
        }
        public bool EstNeeAuZoo
        {
            get => estNeeAuZoo;
            //set => estNeeAuZoo = value;
        }


        public int CompareTo(object obj)
        {
            AnimalDuZoo animalAComparer = obj as AnimalDuZoo;
            if (animalAComparer != null)
            {
               
                return this.dateDeNaissance.CompareTo(animalAComparer.dateDeNaissance);
            }
            else
            {

                throw new ArgumentException("Un objet de type AnimalDuZoo état attendu en argument", "obj");
            }
        }
        public int CompareTo(AnimalDuZoo other)
        {
            return this.dateDeNaissance.CompareTo(other.dateDeNaissance);
        }

        public abstract bool SeDeplacer();

        //public abstract bool Parler();
        
    }
}
