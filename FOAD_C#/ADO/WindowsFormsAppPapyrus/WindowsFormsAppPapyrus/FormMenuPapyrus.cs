using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPapyrus
{
    public partial class FormMenuPapyrus : Form
    {

        public FormMenuPapyrus()
        {
            InitializeComponent();
        }

        private void toolStripButtonRechercheFournisseur_Click(object sender, EventArgs e)
        {
            FormRechercheFournisseur formRechercheFournisseur = new FormRechercheFournisseur();
            formRechercheFournisseur.RechercheFournisseur += FormRechercheFournisseur_RechercheFournisseur;
            formRechercheFournisseur.ShowDialog();
        }

        private void FormRechercheFournisseur_RechercheFournisseur(string nom, string adresse, string cp, string ville, string contact, string satisfaction, FormRechercheFournisseur formSender)
        {
            // formSender.Close();
            FormInformationsFournisseur formInfoFournisseur = new FormInformationsFournisseur(nom, adresse, cp, ville, contact, satisfaction);
            formInfoFournisseur.ShowDialog();
        }

        private void toolStripButtonConnexion_Click(object sender, EventArgs e)
        {
            FormConnexion formConnexion = new FormConnexion();
            formConnexion.ShowDialog();
        }



        private void toolStripButtonRechercheCommande_Click(object sender, EventArgs e)
        {
            FormRechercheCommandes formRechercheCommandes = new FormRechercheCommandes();
            formRechercheCommandes.ShowDialog();
        }

        private void toolStripButtonGestionFournisseurs_Click(object sender, EventArgs e)
        {
            FormMajFournisseurs formMajFournisseurs = new FormMajFournisseurs();
            formMajFournisseurs.ShowDialog();
        }

        private void toolStripButtonAfficherProduits_Click_1(object sender, EventArgs e)
        {
            FormAffichageProduits formAffichageProduits = new FormAffichageProduits();
            formAffichageProduits.ShowDialog();
        }
    }
}
