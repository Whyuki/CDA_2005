using ClassLibraryEmprunt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEmprunt
{
    public partial class FormSimulationEmprunt : Form
    {
        public FormSimulationEmprunt()
        {
            InitializeComponent();
        }

    

        private void buttonCreer_Click(object sender, EventArgs e)
        {
            FormEmprunt fenetreCreerEmprunt = new FormEmprunt();
            fenetreCreerEmprunt.ShowDialog();
            
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            Emprunt empruntAModifier = new Emprunt(150000, 120, Periodicite.Trimestriellement, 8, "Exemple");
            FormEmprunt fenetreModifierEmprunt = new FormEmprunt(empruntAModifier);
            fenetreModifierEmprunt.ShowDialog();
        }
    }
}
