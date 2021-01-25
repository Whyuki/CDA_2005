using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Composite
{
    public abstract class Binaire : Expression
    {
        protected Expression operande1;
        protected Expression operande2;
        protected Binaire(Expression op1, Expression op2)
        {
            operande1 = op1;
            operande2 = op2;
        }
    }
}
