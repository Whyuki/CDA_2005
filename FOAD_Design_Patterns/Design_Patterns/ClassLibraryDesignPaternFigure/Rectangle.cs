using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDesignPaternFigure
{
    public class Rectangle : Figure
    {
        private int largeur;
        private int longueur;

        public Rectangle(int x, int y, int largeur, int longueur) : base(x, y)
        {
            this.largeur = largeur;
            this.longueur = longueur;
        }

        public override void SeDessiner()
        {
            Console.WriteLine("Je suis un rectangle de "
              + this.largeur.ToString() + "cm de largeur, et de " + this.longueur.ToString()+ "cm de longueur, à la position ("
              + this.x.ToString() + ","
              + this.y.ToString() + ")");
        }
    }
}
