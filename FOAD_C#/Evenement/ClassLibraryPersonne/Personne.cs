using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersonne
{
    public class Personne
    {
        private string name;
        private int age;

        public string Name { get => name; /*set => name = value;*/ }
        public int Age { get => age; /*set => age = value;*/ }

        public delegate void DelegateMajeur(Personne sender);
        public event DelegateMajeur JeViensDEtreMajeur;

        //rajouter un evenement RisqueCrise...
        public delegate void DelegateRisqueCrise(Personne sender, string typeDeCrise);
        public event DelegateRisqueCrise JeRisqueUneCrise;


        public Personne(string name)
        {
            this.name = name;
            age = 0;
        }

        public void VieillirDUnAn()
        {
            age++;
            if (age == 18)
            {
                if (JeViensDEtreMajeur != null) //verification que qq s'est enregistre
                {
                    JeViensDEtreMajeur(this);
                }
            }

            if (JeRisqueUneCrise != null) 
            {
                switch (this.age)
                {
                    case 2:
                        JeRisqueUneCrise(this, "crise de l'imitation");
                        break;
                    case 4:
                        JeRisqueUneCrise(this, "crise de poser beaucoup de questions");
                        break;
                    case 15:
                        JeRisqueUneCrise(this, "crise d'adolescence");
                        break;
                    case 20:
                        JeRisqueUneCrise(this, "crise financière");
                        break;
                    case 30:
                        JeRisqueUneCrise(this, "crise de la trentaine");
                        break;
                    case 40:
                        JeRisqueUneCrise(this, "crise de la quarantaine");
                        break;
                    case 50:
                        JeRisqueUneCrise(this, "crise de la cinquantaine");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
