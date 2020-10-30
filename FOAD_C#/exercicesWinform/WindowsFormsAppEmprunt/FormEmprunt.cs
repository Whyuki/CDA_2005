using ClassLibraryToolsVerifications;
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
    public partial class FormEmprunt : Form
    {
        public FormEmprunt()
        {
            InitializeComponent();
        }


        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (ClassVerifications.ValidNom(textBoxNom.Text) || textBoxNom.TextLength == 0) // facultatif !!!
            {
                buttonOk.Enabled = true;
                errorProviderNom.Clear();
            }
            else
            {
                errorProviderNom.SetError(textBoxNom, "Format invalide \nFormat attendu : lettres (deux au minimum), espaces et tirets uniquement");
            }
        }

        private void textBoxCapitalEmprunte_TextChanged(object sender, EventArgs e)
        {

            int.TryParse(textBoxCapitalEmprunte.Text, out int result);
            if (result > 0)
            {
                buttonOk.Enabled = true;
                errorProviderCapital.Clear();
            }
            else
            {
                errorProviderCapital.SetError(textBoxCapitalEmprunte, "Montant invalide");
            }
        }

        private void hScrollBarDuree_ValueChanged(object sender, EventArgs e)
        {
            labelDureeChoisie.Text = hScrollBarDuree.Value.ToString();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            textBoxNom.Clear();
            textBoxCapitalEmprunte.Clear();
            radioButton7pourcent.Checked = false;
            radioButton8pourcent.Checked = false;
            radioButton9pourcent.Checked = false;
            errorProviderNom.Clear();
            errorProviderCapital.Clear();
        }

        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxPeriodicite.SelectedItem)
            {
                case "Mensuelle":
                    hScrollBarDuree.LargeChange = 1;
                    hScrollBarDuree.SmallChange = 1;
                    hScrollBarDuree.Value = 1;
                    break;
                case "Bimestrielle":
                   
                    hScrollBarDuree.LargeChange = 2;
                    hScrollBarDuree.SmallChange = 2;
                    hScrollBarDuree.Value = 2;
                 
                    break;
                case "Trimestrielle":
                    
                    hScrollBarDuree.LargeChange = 3;
                    hScrollBarDuree.SmallChange = 3;
                    hScrollBarDuree.Value = 3;
                    
                    break;

                default:
                    break;
            }

        }
    }
}
