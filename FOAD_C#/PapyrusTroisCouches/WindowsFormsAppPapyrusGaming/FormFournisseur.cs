using ClassLibraryMetierFournisseur;
using ClassLibraryVerifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPapyrusGaming
{
    public partial class FormFournisseur : Form
    {
        #region Champs
        Fournisseur fournisseurCourant;
        ModeInteractionBDD modeCourant;
        Dictionary<int, string> listeFournisseurs;
        #endregion

        #region Constructeurs
        public FormFournisseur()
        {
            InitializeComponent();
            listeFournisseurs = new Dictionary<int, string>();
            this.GetListBoxFournisseurs();
            modeCourant = ModeInteractionBDD.lecture;
        }
        public FormFournisseur(Fournisseur _fournisseurCourant)
        {
            InitializeComponent();
            listeFournisseurs = new Dictionary<int, string>();
            fournisseurCourant = _fournisseurCourant;
            this.AfficherInformationsFournisseur(_fournisseurCourant);
            this.GetListBoxFournisseurs();
            modeCourant = ModeInteractionBDD.lecture;
        }
        #endregion

        #region Afficher les informations du fournisseur selectionné
        private void AfficherInformationsFournisseur(Fournisseur _fournisseur)
        {
            this.textBoxCodeFournisseur.Text = _fournisseur.Id.ToString();
            this.textBoxNomFournisseur.Text = _fournisseur.Nom;
            this.textBoxAdresseFournisseur.Text = _fournisseur.Adresse;
            this.textBoxCpFournisseur.Text = _fournisseur.Cp;
            this.textBoxVilleFournisseur.Text = _fournisseur.Ville;
            this.textBoxContactFournisseur.Text = _fournisseur.Contact;
            this.textBoxSatisfactionFournisseur.Text = _fournisseur.Satisfaction.ToString();
        }
        #endregion

        #region Mettre à jour la liste des fournisseurs
        private void GetListBoxFournisseurs()
        {
            listeFournisseurs = Fournisseur.LoadAll();

            this.comboBoxListeFournisseurs.DisplayMember = "Value";
            this.comboBoxListeFournisseurs.ValueMember = "Key";

            this.comboBoxListeFournisseurs.DataSource = new BindingSource(listeFournisseurs, null);
            this.comboBoxListeFournisseurs.SelectedIndex = -1;
            this.textBoxCodeFournisseur.Clear();
        }
        #endregion

        #region Vider les champs texte informations du fournisseur
        private void ResetTextBoxes()
        {
            this.textBoxNomFournisseur.Clear();
            this.textBoxAdresseFournisseur.Clear();
            this.textBoxCpFournisseur.Clear();
            this.textBoxVilleFournisseur.Clear();
            this.textBoxContactFournisseur.Clear();
            this.textBoxSatisfactionFournisseur.Clear();
        }
        #endregion

        #region Selectionner un fournisseur par son nom ou son code
        private void comboBoxListeFournisseurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxListeFournisseurs.SelectedIndex >= 0 && modeCourant == ModeInteractionBDD.lecture)
            {
                fournisseurCourant = Fournisseur.Load((int)comboBoxListeFournisseurs.SelectedValue);
                this.AfficherInformationsFournisseur(fournisseurCourant);
                buttonModifier.Enabled = true;
                buttonSupprimer.Enabled = true;

            }
            else
            {
                this.ResetTextBoxes();
                buttonModifier.Enabled = false;
                buttonSupprimer.Enabled = false;

            }
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBoxCodeFournisseur.Text, out int result) && Fournisseur.Load(result).Id != -1)
            {
                fournisseurCourant = Fournisseur.Load(result);
                this.AfficherInformationsFournisseur(fournisseurCourant);
                buttonModifier.Enabled = true;
                buttonSupprimer.Enabled = true;
            }
            else
            {
                errorProviderFournisseur.SetError(buttonRechercher, "Fournisseur inexistant");
                this.ResetTextBoxes();
                buttonModifier.Enabled = false;
                buttonSupprimer.Enabled = false;

                comboBoxListeFournisseurs.SelectedIndex = -1;
            }

        }

        private void textBoxCodeFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderFournisseur.Clear();
            if (Int32.TryParse(textBoxCodeFournisseur.Text, out int result))
            {
                buttonRechercher.Enabled = true;
            }
            else
            {
                buttonRechercher.Enabled = false;
            }
        }
        #endregion

        #region Modifier un fournisseur
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            modeCourant = ModeInteractionBDD.modification;
            this.MiseAJourSelonMode();
        }
        #endregion

        #region Ajouter un fournisseur
        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            modeCourant = ModeInteractionBDD.ajout;
            this.ResetTextBoxes();
            textBoxCodeFournisseur.ResetText();
            this.MiseAJourSelonMode();

            //test
            this.SaisieJeuEssaiPourTest();
        }

        private void SaisieJeuEssaiPourTest()
        {
            textBoxNomFournisseur.Text = "Kitty";
            textBoxAdresseFournisseur.Text = "42 rue de la gouttiere";
            textBoxCpFournisseur.Text = "44444";
            textBoxVilleFournisseur.Text = "KitCat";
            textBoxContactFournisseur.Text = "Mr Moustache";
            textBoxSatisfactionFournisseur.Text = "3";
        }
        #endregion

        #region Mise à jour de l'IHM en fonction du mode courant
        private void MiseAJourSelonMode()
        {
            if (modeCourant == ModeInteractionBDD.lecture)
            {
                textBoxCodeFournisseur.ReadOnly = false;
                comboBoxListeFournisseurs.Enabled = true;
                buttonValider.Enabled = false;
                buttonModifier.Enabled = false;
                buttonAnnuler.Enabled = false;
                buttonRechercher.Enabled = true;
                buttonNouveau.Enabled = true;

                foreach (TextBox tb in panelFournisseur.Controls)
                {
                    tb.ReadOnly = true;
                }
                foreach (Control c in panelSelectionFournisseur.Controls)
                {
                    c.Visible = true;
                }
                buttonModifier.Visible = true;
                buttonSupprimer.Visible = true;
            }
            else if (modeCourant == ModeInteractionBDD.ajout || modeCourant == ModeInteractionBDD.modification)
            {
                if (modeCourant == ModeInteractionBDD.ajout)
                {
                    comboBoxListeFournisseurs.SelectedIndex = -1;
                }
                foreach (TextBox tb in panelFournisseur.Controls)
                {
                    tb.ReadOnly = false;
                }
                foreach (Control c in panelSelectionFournisseur.Controls)
                {
                    c.Visible = false;
                }
                textBoxCodeFournisseur.ReadOnly = true;
                comboBoxListeFournisseurs.Enabled = false;
                buttonValider.Enabled = true;
                buttonModifier.Enabled = false;
                buttonAnnuler.Enabled = true;
                buttonRechercher.Enabled = false;
                buttonNouveau.Enabled = false;
                buttonSupprimer.Enabled = false;
                buttonModifier.Visible = false;
                buttonSupprimer.Visible = false;

            }
        }
        #endregion

        #region Valider modification ou ajout
        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (this.SaisieValide())
            {
                string action = "";

                if (modeCourant == ModeInteractionBDD.modification)
                {
                    fournisseurCourant = new Fournisseur(Int32.Parse(this.textBoxCodeFournisseur.Text), this.textBoxNomFournisseur.Text, this.textBoxAdresseFournisseur.Text, this.textBoxCpFournisseur.Text, this.textBoxVilleFournisseur.Text, this.textBoxContactFournisseur.Text, byte.Parse(this.textBoxSatisfactionFournisseur.Text));
                    action = "modifié";
                }
                else if (modeCourant == ModeInteractionBDD.ajout)
                {
                    fournisseurCourant = new Fournisseur(this.textBoxNomFournisseur.Text, this.textBoxAdresseFournisseur.Text, this.textBoxCpFournisseur.Text, this.textBoxVilleFournisseur.Text, this.textBoxContactFournisseur.Text, byte.Parse(this.textBoxSatisfactionFournisseur.Text));
                    action = "ajouté";
                }

                fournisseurCourant.Save();
                MessageBox.Show("Fournisseur " + fournisseurCourant.Nom + " (code : " + fournisseurCourant.Id.ToString() + ") " + action + " avec succès !");

                this.GetListBoxFournisseurs();
                this.AfficherInformationsFournisseur(fournisseurCourant);
                modeCourant = ModeInteractionBDD.lecture;
                this.MiseAJourSelonMode();

                foreach (KeyValuePair<int, string> item in listeFournisseurs)
                {
                    if (item.Key == fournisseurCourant.Id)
                    {
                        comboBoxListeFournisseurs.SelectedItem = item;
                    }
                }
            }
        }
        #endregion

        #region Annuler saisie fournisseur modification ou ajout
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.modeCourant = ModeInteractionBDD.lecture;
            this.ResetTextBoxes();
            this.MiseAJourSelonMode();
            this.textBoxCodeFournisseur.ResetText();
            this.comboBoxListeFournisseurs.SelectedIndex = -1;
            errorProviderNom.Clear();
            errorProviderAdresse.Clear();
            errorProviderCP.Clear();
            errorProviderVille.Clear();
            errorProviderContact.Clear();
            errorProviderSatisfaction.Clear();
        }
        #endregion

        #region Supprimer un fournisseur
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (fournisseurCourant.Delete())
            {
                string informationsFournisseurSupprime = fournisseurCourant.Nom + " (code : " + fournisseurCourant.Id.ToString() + ")";
                fournisseurCourant.Delete();
                this.GetListBoxFournisseurs();
                MessageBox.Show("Fournisseur " + informationsFournisseurSupprime + " supprimé");
            }
            else
            {
                errorProviderFournisseur.SetError(buttonSupprimer, "Suppression impossible");
            }
        }
        #endregion

        #region Bouton QUITTER : fermeture de le fenetre
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Verification champs saisie informations fournisseur
        private void textBoxNomFournisseur_Validating(object sender, CancelEventArgs e)
        {
            if (!ClassVerifications.ValidNom(textBoxNomFournisseur.Text))
            {
                if (textBoxNomFournisseur.TextLength < 1)
                {
                    errorProviderNom.SetError(textBoxNomFournisseur, "Champ obligatoire");
                }
                else
                {
                    errorProviderNom.SetError(textBoxNomFournisseur, "Nom au format invalide");
                }
            }

        }

        private void textBoxNomFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderNom.Clear();
            if (modeCourant == ModeInteractionBDD.ajout || modeCourant == ModeInteractionBDD.modification)
            {
                buttonValider.Enabled = this.SaisieValide();
            }

        }

        private void textBoxAdresseFournisseur_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxAdresseFournisseur.TextLength < 1)
            {
                errorProviderAdresse.SetError(textBoxAdresseFournisseur, "Champ obligatoire");
            }
        }

        private void textBoxAdresseFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderAdresse.Clear();
            if (modeCourant == ModeInteractionBDD.ajout || modeCourant == ModeInteractionBDD.modification)
            {
                buttonValider.Enabled = this.SaisieValide();
            }

        }

        private void textBoxCpFournisseur_Validating(object sender, CancelEventArgs e)
        {
            if (!ClassVerifications.ValidCP(textBoxCpFournisseur.Text))
            {
                if (textBoxCpFournisseur.TextLength < 1)
                {
                    errorProviderCP.SetError(textBoxCpFournisseur, "Champ obligatoire");
                }
                else
                {
                    errorProviderCP.SetError(textBoxCpFournisseur, "Code postal invalide");
                }
            }
        }

        private void textBoxCpFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderCP.Clear();
            if (modeCourant == ModeInteractionBDD.ajout || modeCourant == ModeInteractionBDD.modification)
            {
                buttonValider.Enabled = this.SaisieValide();
            }

        }

        private void textBoxVilleFournisseur_Validating(object sender, CancelEventArgs e)
        {
            if (!ClassVerifications.ValidNom(textBoxVilleFournisseur.Text))
            {
                if (textBoxVilleFournisseur.TextLength < 1)
                {
                    errorProviderVille.SetError(textBoxVilleFournisseur, "Champ obligatoire");
                }
                else
                {
                    errorProviderVille.SetError(textBoxVilleFournisseur, "Nom de ville au format invalide");
                }
            }
        }

        private void textBoxVilleFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderVille.Clear();
            if (modeCourant == ModeInteractionBDD.ajout || modeCourant == ModeInteractionBDD.modification)
            {
                buttonValider.Enabled = this.SaisieValide();
            }

        }

        private void textBoxContactFournisseur_Validating(object sender, CancelEventArgs e)
        {
            if (!ClassVerifications.ValidNom(textBoxContactFournisseur.Text))
            {
                if (textBoxContactFournisseur.TextLength < 1)
                {
                    errorProviderContact.SetError(textBoxContactFournisseur, "Champ obligatoire");
                }
                else
                {
                    errorProviderContact.SetError(textBoxContactFournisseur, "Nom au format invalide");
                }
            }
        }

        private void textBoxContactFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderContact.Clear();
            if (modeCourant == ModeInteractionBDD.ajout || modeCourant == ModeInteractionBDD.modification)
            {
                buttonValider.Enabled = this.SaisieValide();
            }

        }

        private void textBoxSatisfactionFournisseur_Validating(object sender, CancelEventArgs e)
        {
            if (!ClassVerifications.ValidMontantInt(textBoxSatisfactionFournisseur.Text))
            {
                if (textBoxSatisfactionFournisseur.TextLength < 1)
                {
                    errorProviderSatisfaction.SetError(textBoxSatisfactionFournisseur, "Champ obligatoire");
                }
                else
                {
                    errorProviderSatisfaction.SetError(textBoxSatisfactionFournisseur, "Note invalide");
                }
            }
        }

        private void textBoxSatisfactionFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderSatisfaction.Clear();
            if (modeCourant == ModeInteractionBDD.ajout || modeCourant == ModeInteractionBDD.modification)
            {
                if (modeCourant == ModeInteractionBDD.ajout || modeCourant == ModeInteractionBDD.modification)
                {
                    buttonValider.Enabled = this.SaisieValide();
                }
            }

        }

        private bool SaisieValide()
        {
            string nom = textBoxNomFournisseur.Text;
            string adresse = textBoxAdresseFournisseur.Text;
            string cp = textBoxCpFournisseur.Text;
            string ville = textBoxVilleFournisseur.Text;
            string contact = textBoxContactFournisseur.Text;
            string satisfaction = textBoxSatisfactionFournisseur.Text;

            bool nomIsValid = ClassVerifications.ValidNom(nom);
            bool adresseIsValid = adresse.Length > 0;
            bool cPIsValid = ClassVerifications.ValidCP(cp);
            bool villeIsValid = ClassVerifications.ValidNom(ville);
            bool contactIsValid = ClassVerifications.ValidNom(contact);
            bool satisfactionIsValid = ClassVerifications.ValidMontantInt(satisfaction);

            return nomIsValid & adresseIsValid & cPIsValid & villeIsValid & contactIsValid & satisfactionIsValid;

        }
        #endregion
    }
}
