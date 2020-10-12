using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{
    public class Arbre
    {
        int hauteur;
        private List<Feuille> feuilles;

        public Arbre(int _hauteur)
        {
            this.hauteur = _hauteur;
            this.feuilles = new List<Feuille>();
        }

        public Arbre(int _hauteur, List<Feuille> _feuilles) //ouvre porte aggregation
        {
            this.hauteur = _hauteur;
            this.feuilles = _feuilles;
        }

        private void AddFeuille(Feuille f)
        {
            this.feuilles.Add(f);
        }

        public void AddFeuille(int _nbNervures, EnumCouleur _couleur, EnumFormeFeuille _forme)
        {
            this.AddFeuille(new Feuille(_nbNervures, _couleur, _forme));
        }

        public int Hauteur
        {
            get => hauteur;
            //set => hauteur = value; 
        }


        public void PassageAutomne()
        {
            foreach (Feuille f in feuilles)
            {
                f.CouleursAutomne();
            }
        }

        public void PerdreFeuilles()
        {
            foreach (Feuille f in feuilles)
            {
                f.Tomber();
            }
                feuilles.Clear();
        }

        public override string ToString()
        {
            string str = base.ToString() + "\nHauteur : " + hauteur + "cm";

            if (this.feuilles.Count() > 0)
            {
                str += "\nFeuilles :";
                foreach (Feuille f in feuilles)
                {
                    str += "\n" + f.ToString();
                }
            }
            else
            {
                str += "\nCet arbre n'a pas/plus de feuille !";
            }
            return str;
        }
    }
}
