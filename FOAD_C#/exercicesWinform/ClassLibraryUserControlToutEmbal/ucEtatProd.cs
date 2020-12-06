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
    public partial class ucEtatProd : UserControl
    {
        public ucEtatProd(string nom)
        {
            InitializeComponent();
            this.Name += nom;
            this.labelEtatNomProd.Text = "Caisse " + nom + " : ";
            this.textBoxEtat.Name += nom;
            this.textBoxEtat.Text += "Non démarré";
        }
    }
}
