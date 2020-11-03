﻿using ClassLibraryEmprunt;
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

        private Emprunt emprunt = new Emprunt();


        public FormEmprunt()
        {
            InitializeComponent();
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
            textBoxCapitalEmprunte.Text = emprunt.CapitalEmprunte.ToString();
            this.MiseAJourDeLaVue();
        }

        /// <summary>
        /// Mise à jour de la fenêtre 
        /// </summary>
        public void MiseAJourDeLaVue()
        {
            textBoxNom.Text = emprunt.NomClient;
            labelNbRemboursement.Text = emprunt.CalculNombreDeRemboursement().ToString();
            labelMontantRemboursement.Text = Math.Round(emprunt.CalculMontantEcheance(), 2).ToString() + " €";

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

            hScrollBarDuree.Value = emprunt.DureeRemboursementEnMois;

        }

        /// <summary>
        /// Met à jour la durée de remboursement en mois en fonciton de la périodicité 
        /// </summary>
        private void MiseAjourDeLaDureeSelonPeriodicite()
        {
            int periodicite = Convert.ToInt32(emprunt.Periodicite);

            if (hScrollBarDuree.Value % periodicite == 0)
            {
                labelDureeChoisie.Text = hScrollBarDuree.Value.ToString();
                emprunt.DureeRemboursementEnMois = hScrollBarDuree.Value;
            }
            else
            {
                hScrollBarDuree.Value += 1;
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
                buttonOk.Enabled = true;
                errorProviderNom.Clear();
                emprunt.NomClient = textBoxNom.Text;
            }
            else
            {
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
            this.MiseAjourDeLaDureeSelonPeriodicite();
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
                case "Mensuelle":
                    prochainePeriodicite = Periodicite.Mensuellement;

                    break;
                case "Bimestrielle":
                    prochainePeriodicite = Periodicite.Bimestriellement;

                    break;
                case "Trimestrielle":
                    prochainePeriodicite = Periodicite.Trimestriellement;

                    break;
                case "Semestrielle":
                    prochainePeriodicite = Periodicite.Semestriellement;

                    break;
                case "Annuelle":
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
                // hScrollBarDuree.Value = nbMoisPeriodicite;
                this.MiseAjourDeLaDureeSelonPeriodicite();
                hScrollBarDuree.Value = emprunt.DureeRemboursementEnMois;
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
            hScrollBarDuree.Value = 1;
            listBoxPeriodicite.SetSelected(0, true);
            radioButton7pourcent.Checked = true;
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
                MessageBox.Show("Validé");
            }
        }
    }
}
