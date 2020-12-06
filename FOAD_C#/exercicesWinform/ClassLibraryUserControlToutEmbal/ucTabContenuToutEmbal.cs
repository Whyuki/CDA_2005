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
    public partial class ucTabContenuToutEmbal : UserControl
    {
        public ucTabContenuToutEmbal(string nom)
        {
            InitializeComponent();
            this.textBoxNbCaisseDepuisDemarrage.Name += nom;
            this.textBoxTauxDefautHeure.Name += nom;
            this.textBoxTauxDefautDepuisDemarrage.Name += nom;
            this.labelNbCaisseDepuisDemarrage.Name += nom;
            this.labelTauxDefautHeure.Name += nom;
            this.labelTauxDefautDepuisDemarrage.Name += nom;
        }
    }
}
