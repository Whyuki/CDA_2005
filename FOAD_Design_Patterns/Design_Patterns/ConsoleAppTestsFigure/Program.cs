using ClassLibraryDesignPaternFigure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestsFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Cercle c1 = new Cercle(4, 3, 2);
            c1.SeDessiner();
           

            Rectangle r1 = new Rectangle(4, 3, 2, 1);
            r1.SeDessiner();

            Figures ensembleDeFigures = new Figures(4,3);
            Cercle c2 = new Cercle(5, 6, 7);
            Rectangle r2 = new Rectangle(8, 4, 3, 4);
            ensembleDeFigures.sesFigures.Add(c2);
            ensembleDeFigures.sesFigures.Add(r2);
            ensembleDeFigures.SeDessiner();

            Console.ReadLine();

        }
    }
}
