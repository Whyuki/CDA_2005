using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Composite
{
    public class Soustraction : Binaire
    {
        public Soustraction(Expression op1, Expression op2) : base(op1, op2)
        {
        }

        public override int Evalue()
        {
            return operande1.Evalue() - operande2.Evalue();
        }

        public override string Formate()
        {
            return operande1.ToString() + "-(" + operande2.ToString() + ")" + "=" + this.Evalue().ToString();

        }

        public override string ToString()
        {
            return operande1.ToString() + "-(" + operande2.ToString() + ")";

        }
    }
}
