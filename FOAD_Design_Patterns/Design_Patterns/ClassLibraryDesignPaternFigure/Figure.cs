using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDesignPaternFigure
{
    public abstract class Figure
    {
        protected int x;
        protected int y;

        protected Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract void SeDessiner();
    }
}
