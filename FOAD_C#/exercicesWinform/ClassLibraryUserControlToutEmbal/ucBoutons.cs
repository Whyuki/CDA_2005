using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryUserControlToutEmbal
{
    public partial class ucBoutons : UserControl
    {
        public ucBoutons(string nom)
        {
            InitializeComponent();
            this.Name += nom;
            this.buttonDemarrer.Name += nom;
            this.buttonPause.Name += nom;
            this.buttonContinuer.Name += nom;
          
            this.textBoxBoutonsNomProd.Name += nom;
            this.textBoxBoutonsNomProd.Text += nom;
        }
    }
}
