using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParRef
{
    class Program
    {

        static double AddSous(double d1, double d2, out double sous)
        {
            sous = d1 - d2;
            return d1 + d2;

        }

        static void Main(string[] args)
        {
            double d1 = 1.5;
            double d2 = 2.5;
            double resultSous;
            double resultAdd;

            resultAdd = AddSous(d1, d2, out resultSous);

        }
    }
}
