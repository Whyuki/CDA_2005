using ClassLibraryFacture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlesSaisie
{
    public partial class FormFacture : Form
    {
        public FormFacture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controles fenetreControle = new Controles();
            fenetreControle.ShowDialog();
            Facture result = fenetreControle.FactureActuelle;
        }
    }
}
