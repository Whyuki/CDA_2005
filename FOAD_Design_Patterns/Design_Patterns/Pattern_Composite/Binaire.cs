using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Composite
{
    public abstract class Binaire : Expression
    {
        protected Expression operante1;
        protected Expression operante2;
        protected Binaire(Expression op1, Expression op2)
        {
            operante1 = op1;
            operante2 = op2;
        }
    }
}
