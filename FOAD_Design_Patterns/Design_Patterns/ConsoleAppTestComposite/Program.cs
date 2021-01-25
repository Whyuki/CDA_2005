using Pattern_Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression exp1 = new Addition(new Nombre(33), new Nombre(33));
            int resultat1 = exp1.Evalue();
            string strResult1 = exp1.Formate();

            Expression exp2 = new Addition(new Nombre(33), new Addition(new Nombre(33), new Nombre(11)));
            int resultat2 = exp2.Evalue();
            string strResult2 = exp2.Formate();

            Expression exp3 = new Soustraction(new Nombre(3), new Nombre(6));
            int resultat3 = exp3.Evalue();
            string strResult3 = exp3.Formate();

            Expression exp4 = new Addition(new Soustraction(new Nombre(3), new Nombre(6)), new Nombre(7));
            int resultat4 = exp4.Evalue();
            string strResult4 = exp4.Formate();

            Expression exp5 = new Soustraction(new Nombre(3), new Addition(new Nombre(6), new Nombre(7)));
            int resultat5 = exp5.Evalue();
            string strResult5 = exp5.Formate();

            Expression exp6 = new Soustraction(new Addition(new Nombre(6), new Nombre(7)), new Nombre(3));
            int resultat6 = exp6.Evalue();
            string strResult6 = exp6.Formate();

            Expression exp7 = new Soustraction(new Soustraction(new Nombre(3), new Nombre(9)), new Nombre(6));
            int resultat7 = exp7.Evalue();
            string strResult7 = exp7.Formate();
        }
    }
}
