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

        public int Denominator { get => denominator; set => denominator = value; }

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
                throw new ZeroDenominatorImpossibleException("Division impossible : le denominateur est egal a zero");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(int numerator) : this(numerator, 1)
        {

        }


        // afinir: y a t il une exception? si oui, a coder...
        /// <summary>
        /// Exception : 
        /// ConsoleAppCreationDUneException.ExceptionOfFraction.ImpossibleDInverserLaFraction : Impossible d'inverser la fraction lorsque le numerateur est egal à zero
        /// </summary>
        public void Inverser()
        {
            if (numerator == 0)
            {
                throw new ImpossibleDInverserLaFraction("Inversion impossible : le numérateur est egal a zero");
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
                r = numerator / denominator;
                return r;
            }
            catch (DivideByZeroException e)
            {
                throw new ImpossibleEvaluationOfFraction("Evaluation impossible: le denominateur est egal a zero", e);
            }

        }

    }
}
