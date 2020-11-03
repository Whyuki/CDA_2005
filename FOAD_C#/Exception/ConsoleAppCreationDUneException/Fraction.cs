using ConsoleAppCreationDUneException.ExceptionOfFraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCreationDUneException
{
    class Fraction
    {
        
        int numerator;
        int denominator;

        /// <summary>
        /// // Exceptions :
        /// denominator: ZeroDenominatorImpossibleException
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ZeroDenominatorImpossibleException("Le denominateur est egale a zero");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(int numerator)
        {
            this.numerator = numerator;
        }


        // afinir: y a t il une exception? si oui, a coder...
        public void Inverser()
        {
            if (this.denominator == 0)
            {
                throw new UndefinedDenominatorException("Le denominateur n'est pas défini");
            }
            int temps = numerator;
            this.numerator = denominator;
            this.denominator = temps;
        }

        /// <summary>
        /// // Exceptions :
        /// ConsoleAppCreationDUneException.ExceptionOfFraction.ImpossibleEvaluationOfFraction: Le denominator ne doit pas etre egal a zero dans une fraction 
        /// </summary>
        /// <returns></returns>
        public double Evaluer()
        {
            int r;
            try
            {
                r=  numerator / denominator;
                return r;
            }
            catch(DivideByZeroException e)
            {
                throw new ImpossibleEvaluationOfFraction("Le denominateur vaut zero",e);
            }
            
        }

    }
}
