using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForet
{
    public class Feuille
    {
        int nbNervures;
        EnumCouleur couleur;
        EnumFormeFeuille forme;

        public Feuille(int _nbNervures, EnumCouleur _couleur, EnumFormeFeuille _forme)
        {
            this.nbNervures = _nbNervures;
            this.couleur = _couleur;
            this.forme = _forme;
        }

        public int NbNervures
        {
            get => nbNervures;
            //set => nbNervures = value; 
        }

        public void Tomber()
        {
            Console.WriteLine("Je tombe");
        }

        public override string ToString()
        {
            return base.ToString() + "\nNombre de nervures : " + nbNervures + "\nCouleur : " + couleur + "\nForme : " + forme;
        }

        public void CouleursAutomne()
        {
            switch (couleur)
            {
                case EnumCouleur.Vert:
                    couleur = EnumCouleur.Jaune;
                    break;
                case EnumCouleur.Jaune:
                    couleur = EnumCouleur.Orange;
                    break;
                case EnumCouleur.Orange:
                    couleur = EnumCouleur.Rouge;
                    break;
                default:
                    couleur = EnumCouleur.Rouge;
                    break;
            }

        }

    }

}
