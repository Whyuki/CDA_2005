using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Composite
{
    public class Nombre : Expression
    {
        private int valeur;

        public Nombre(int valeur)
        {
            this.valeur = valeur;
        }

        public override int Evalue()
        {
            return valeur;
        }

        public override string FormateGauche()
        {
            return valeur.ToString();
        }

        public override string ToString()
        {
            return valeur.ToString();
        }
    }
}
