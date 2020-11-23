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

        private static int compteurInstance;

        private Emprunt emprunt;

        private BindingList<Periodicite> listePeriodicites;

        public FormEmprunt()
        {
            InitializeComponent();
            compteurInstance++;
            this.Text += " n° " + compteurInstance.ToString();
            emprunt = new Emprunt();
            listePeriodicites = new BindingList<Periodicite>(Enum.GetValues(typeof(Periodicite)).OfType<Periodicite>().ToList());
            listBoxPeriodicite.DataSource = listePeriodicites;

            this.MiseAJourDeLaVue();
        }

        /// <summary>
        /// Mode modification
        /// </summary>
        /// <param name="_empruntAModifier"></param>
        public FormEmprunt(Emprunt _empruntAModifier)
        {
            InitializeComponent();
            emprunt = _empruntAModifier;
            listBoxPeriodicite.DataSource = new BindingList<Periodicite>(Enum.GetValues(typeof(Periodicite)).OfType<Periodicite>().ToList());
            this.MiseAJourDeLaVue();
        }

        /// <summary>
        /// Mise à jour de la fenêtre 
        /// </summary>
        public void MiseAJourDeLaVue()
        {
            int periodicite = Convert.ToInt32(emprunt.Periodicite);

            float actuelCapital = emprunt.CapitalEmprunte;
            float.TryParse(textBoxCapitalEmprunte.Text, out float prochainCapital);

            switch (emprunt.TauxEnPourcentage)
            {
                case 7:
                    radioButton7pourcent.Checked = true;
                    break;
                case 8:
                    radioButton8pourcent.Checked = true;
                    break;
                case 9:
                    radioButton9pourcent.Checked = true;
                    break;
                default:
                    radioButton7pourcent.Checked = true;
                    break;
            }

            switch (emprunt.Periodicite)
            {
                case Periodicite.Mensuellement:
                    listBoxPeriodicite.SetSelected(0, true);
                    break;
                case Periodicite.Bimestriellement:
                    listBoxPeriodicite.SetSelected(1, true);
                    break;
                case Periodicite.Trimestriellement:
                    listBoxPeriodicite.SetSelected(2, true);
                    break;
                case Periodicite.Semestriellement:
                    listBoxPeriodicite.SetSelected(3, true);
                    break;
                case Periodicite.Annuellement:
                    listBoxPeriodicite.SetSelected(4, true);
                    break;
                default:
                    listBoxPeriodicite.SetSelected(0, true);
                    break;
            }

            // Met à jour la durée de remboursement en mois en fonction de la périodicité 
            if (hScrollBarDuree.Value % periodicite == 0)
            {
                emprunt.DureeRemboursementEnMois = hScrollBarDuree.Value;
                labelDureeChoisie.Text = hScrollBarDuree.Value.ToString();
            }
            else
            {
                hScrollBarDuree.Value += 1;
            }

            hScrollBarDuree.Value = emprunt.DureeRemboursementEnMois;
            textBoxNom.Text = emprunt.NomClient;
            labelNbRemboursement.Text = emprunt.CalculNombreDeRemboursement().ToString();
            labelMontantRemboursement.Text = Math.Round(emprunt.CalculMontantEcheance(), 2).ToString() + " €";

            if (actuelCapital != prochainCapital)
            {
                textBoxCapitalEmprunte.Text = emprunt.CapitalEmprunte.ToString();
            }

        }

        /// <summary>
        /// Vérifie le format du nom du client saisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (ClassVerifications.ValidNom(textBoxNom.Text) || textBoxNom.TextLength == 0)
            {
                errorProviderNom.Clear();
                emprunt.NomClient = textBoxNom.Text;
            }
            else
            {
                emprunt.NomClient = "";
                errorProviderNom.SetError(textBoxNom, "Format invalide \nFormat attendu : lettres (deux au minimum), espaces et tirets uniquement");
            }
        }

        /// <summary>
        /// Modifie le capital emprunté
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCapitalEmprunte_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxCapitalEmprunte.Text, out float result) && result >= 0)
            {
                errorProviderCapital.Clear();
                emprunt.CapitalEmprunte = result;
            }
            else
            {
                emprunt.CapitalEmprunte = 0;

                if (textBoxCapitalEmprunte.Text == "")
                {
                    errorProviderCapital.Clear();
                }
                else
                {
                    errorProviderCapital.SetError(textBoxCapitalEmprunte, "Montant positif attendu : \nChiffres et sépareur décimal (,) uniquement");
                }
            }
            this.MiseAJourDeLaVue();
        }

        /// <summary>
        /// Modifie la durée de remboursement en mois en fonction de la périodicité sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBarDuree_ValueChanged(object sender, EventArgs e)
        {
            this.MiseAJourDeLaVue();
        }

        /// <summary>
        /// Redéfinit la barre de défilement en fonction de la périodicité sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPeriodicite_SelectedIndexChanged(object sender, EventArgs e)
        {
            Periodicite presentePeriodicite = emprunt.Periodicite;
            Periodicite prochainePeriodicite = emprunt.Periodicite;

            switch (listBoxPeriodicite.SelectedItem)
            {
                case Periodicite.Mensuellement:
                    prochainePeriodicite = Periodicite.Mensuellement;

                    break;
                case Periodicite.Bimestriellement:
                    prochainePeriodicite = Periodicite.Bimestriellement;

                    break;
                case Periodicite.Trimestriellement:
                    prochainePeriodicite = Periodicite.Trimestriellement;

                    break;
                case Periodicite.Semestriellement:
                    prochainePeriodicite = Periodicite.Semestriellement;

                    break;
                case Periodicite.Annuellement:
                    prochainePeriodicite = Periodicite.Annuellement;

                    break;
                default:
                    break;
            }

            if (presentePeriodicite != prochainePeriodicite)
            {
                emprunt.Periodicite = prochainePeriodicite;
                int nbMoisPeriodicite = Convert.ToInt32(emprunt.Periodicite);
                hScrollBarDuree.LargeChange = nbMoisPeriodicite;
                hScrollBarDuree.SmallChange = nbMoisPeriodicite;
                this.MiseAJourDeLaVue();
            }

        }

        /// <summary>
        /// Modifie le taux de l'emprunt en fonction du taux séléctionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Réinitialise le formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            emprunt = new Emprunt();
            this.MiseAJourDeLaVue();
            textBoxCapitalEmprunte.Clear();
            errorProviderNom.Clear();
            errorProviderCapital.Clear();

        }

        /// <summary>
        /// Bouton ok : confirme si le capital répond au format attendu, sinon affiche un message d'erreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (emprunt.CapitalEmprunte == 0)
            {
                MessageBox.Show("Veuillez saisir un montant valide");
            }
            else
            {
                if (textBoxNom.Text == "" || emprunt.NomClient != "")
                {
                    MessageBox.Show("Validé");
                }
                else
                {
                    MessageBox.Show("Nom au format invalide : Veuillez saisir un nom valide ou ne pas en saisir, celui-ci est facultatif");
                }
            }
        }

    }
}
