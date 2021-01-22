using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Composite
{
    public class Addition : Binaire
    {
        public Addition(Expression op1, Expression op2) : base(op1, op2)
        {
        }

        public override int Evalue()
        {
            return operante1.Evalue() + operante2.Evalue();
        }

        public override string Formate()
        {
            return this.ToString()+"=" +this.Evalue().ToString();
        }

        public override string ToString()
        {
            return operante1.ToString() + "+" + operante2.ToString();
        }
    }
}
