using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDesignPaternFigure
{
    public class Figures : Figure
    {
        public Figures(int x, int y) : base(x, y)
        {
            sesFigures = new List<Figure>();
        }

        private List<Figure> sesFigures;

        public void AjouterFigure(Figure f)
        {
            this.sesFigures.Add(f);
        }

        public override void SeDessiner()
        {
            Console.WriteLine("*************************************************************\n" +
                "Je suis un ensemble de figures, voici mes figures :");
            foreach (Figure figure in sesFigures)
            {
                figure.SeDessiner();
            }
        }
    }
}
