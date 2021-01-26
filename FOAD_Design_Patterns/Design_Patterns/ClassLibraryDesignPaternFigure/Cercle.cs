using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDesignPaternFigure
{
    public class Cercle : Figure
    {
        private int rayon;

        public Cercle(int x, int y, int rayon) : base(x, y)
        {
            this.rayon = rayon;
        }

        public override void SeDessiner()
        {
            Console.WriteLine("Je suis un cercle de " 
                + this.rayon.ToString() + "cm de rayon, à la position ("
                + this.x.ToString() + "," 
                + this.y.ToString() + ")");
        }
    }
}
