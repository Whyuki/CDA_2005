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
            Console.WriteLine("____________________________________________");
            Console.WriteLine("TEST CERCLE");
            Cercle c1 = new Cercle(4, 3, 2);
            c1.SeDessiner();


            Console.WriteLine("____________________________________________");
            Console.WriteLine("TEST RECTANGLE");
            Rectangle r1 = new Rectangle(4, 3, 2, 1);
            r1.SeDessiner();
            Console.WriteLine("____________________________________________");

            Console.WriteLine("TEST FIGURES");
            Figures ensembleDeFigures = new Figures(4,3);
            Cercle c2 = new Cercle(5, 6, 7);
            Rectangle r2 = new Rectangle(8, 4, 3, 4);
            ensembleDeFigures.sesFigures.Add(c2);
            ensembleDeFigures.sesFigures.Add(r2);
            ensembleDeFigures.SeDessiner();

            Console.WriteLine("____________________________________________");
            Console.WriteLine("TEST FIGURES CONTENANT UN FIGURES");
            Figures ensembleDeFigures2 = new Figures(4, 3);
            Cercle c3 = new Cercle(2, 1, 5);
            Rectangle r3 = new Rectangle(3, 2, 7, 1);
            ensembleDeFigures2.sesFigures.Add(c3);
            ensembleDeFigures2.sesFigures.Add(r3);
            ensembleDeFigures.sesFigures.Add(ensembleDeFigures2);
            ensembleDeFigures.SeDessiner();

            Console.ReadLine();

        }
    }
}
