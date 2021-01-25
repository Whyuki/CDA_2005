using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Composite
{
    public abstract class Expression
    {
        protected Expression()
        { }

        public abstract int Evalue();
        public abstract string FormateGauche();
        public string Formate()
        {
            return this.FormateGauche() + "=" + this.Evalue().ToString();
        }

    }
}
