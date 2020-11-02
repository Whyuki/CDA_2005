using ClassLibraryEmprunt;
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

        private Emprunt emprunt;


        public FormEmprunt()
        {
            InitializeComponent();
            this.ResetLaVue();
            this.MiseAJourDeLaVue();

        }

        public void MiseAJourDeLaVue()
        {
            textBoxNom.Text = emprunt.NomClient;

            if (emprunt.CapitalEmprunte > 0)
            {
                textBoxCapitalEmprunte.Text = emprunt.CapitalEmprunte.ToString();
            }
            else
            {
                textBoxCapitalEmprunte.Clear();
            }

            labelNbRemboursement.Text = emprunt.CalculNombreDeRemboursement().ToString();
            labelMontantRemboursement.Text = Math.Round(emprunt.CalculMontantEcheance(), 2).ToString() + " €";
        }

        public void ResetLaVue()
        {
            emprunt = new Emprunt();
            this.MiseAJourDeLaVue();
            errorProviderNom.Clear();
            errorProviderCapital.Clear();
            hScrollBarDuree.Value = 1;
            listBoxPeriodicite.SetSelected(0, true);
            radioButton7pourcent.Checked = true;
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (ClassVerifications.ValidNom(textBoxNom.Text) || textBoxNom.TextLength == 0) // facultatif !!!
            {
                buttonOk.Enabled = true;
                errorProviderNom.Clear();
                emprunt.NomClient = textBoxNom.Text;
            }
            else
            {
                errorProviderNom.SetError(textBoxNom, "Format invalide \nFormat attendu : lettres (deux au minimum), espaces et tirets uniquement");
            }
        }

        private void textBoxCapitalEmprunte_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxCapitalEmprunte.Text, out float result))
            {
                if (result == 0)
                {
                    errorProviderCapital.Clear();
                    emprunt.CapitalEmprunte = 0;
                }
                if (result > 0)
                {
                    errorProviderCapital.Clear();
                    emprunt.CapitalEmprunte = float.Parse(textBoxCapitalEmprunte.Text);
                    this.MiseAJourDeLaVue();
                }
                else
                {
                    emprunt.CapitalEmprunte = 0;
                    errorProviderCapital.SetError(textBoxCapitalEmprunte, "Saisir un montant supérieur à zéro");
                }

            }
            else
            {
                emprunt.CapitalEmprunte = 0;
                errorProviderCapital.SetError(textBoxCapitalEmprunte, "Chiffre uniquement");

            }

        }

        private void hScrollBarDuree_ValueChanged(object sender, EventArgs e)
        {
            int periodicite = Convert.ToInt32(emprunt.Periodicite);

            if (hScrollBarDuree.Value % periodicite == 0)
            {
                labelDureeChoisie.Text = hScrollBarDuree.Value.ToString();
                emprunt.DureeRemboursementEnMois = hScrollBarDuree.Value;
            }
            else
            {
                hScrollBarDuree.Value = hScrollBarDuree.Value + 1;
            }

            this.MiseAJourDeLaVue();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.ResetLaVue();
        }

        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxPeriodicite.SelectedItem)
            {
                case "Mensuelle":
                    emprunt.Periodicite = Periodicite.Mensuellement;
                    hScrollBarDuree.LargeChange = 1;
                    hScrollBarDuree.SmallChange = 1;
                    hScrollBarDuree.Value = 1;
                    break;
                case "Bimestrielle":
                    emprunt.Periodicite = Periodicite.Bimestriellement;
                    hScrollBarDuree.LargeChange = 2;
                    hScrollBarDuree.SmallChange = 2;
                    hScrollBarDuree.Value = 2;

                    break;
                case "Trimestrielle":
                    emprunt.Periodicite = Periodicite.Trimestriellement;
                    hScrollBarDuree.LargeChange = 3;
                    hScrollBarDuree.SmallChange = 3;
                    hScrollBarDuree.Value = 3;

                    break;
                case "Semestrielle":
                    emprunt.Periodicite = Periodicite.Semestriellement;
                    hScrollBarDuree.LargeChange = 6;
                    hScrollBarDuree.SmallChange = 6;
                    hScrollBarDuree.Value = 6;

                    break;
                case "Annuelle":
                    emprunt.Periodicite = Periodicite.Annuellement;
                    hScrollBarDuree.LargeChange = 12;
                    hScrollBarDuree.SmallChange = 12;
                    hScrollBarDuree.Value = 12;

                    break;
                default:
                    break;
            }

            this.MiseAJourDeLaVue();

        }

        private void radioButtonTaux_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7pourcent.Checked)
            {
                emprunt.TauxEnPourcentage = 7;
            }
            if (radioButton8pourcent.Checked)
            {
                emprunt.TauxEnPourcentage = 8;
            }
            if (radioButton9pourcent.Checked)
            {
                emprunt.TauxEnPourcentage = 9;
            }

            this.MiseAJourDeLaVue();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (emprunt.CapitalEmprunte == 0)
            {
                MessageBox.Show("Aucun montant saisi !");
            }
            else
            {
                MessageBox.Show("Ok !");
            }
        }
    }
}
