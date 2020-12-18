using ClassLibraryVerifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPapyrus
{
    public partial class FormMajFournisseurs : Form
    {
        #region Champs
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommande;
        private SqlDataReader sqlReader;
        Dictionary<int, string> listeFournisseurs;
        private ModeBDD mode;
        #endregion

        #region Constructeur
        public FormMajFournisseurs()
        {
            InitializeComponent();

            mode = ModeBDD.lecture;

            sqlConnect = new SqlConnection();
            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["papyrusConnectionString"];
            if (oConfig != null)
            {
                sqlConnect.ConnectionString = oConfig.ConnectionString;
            }
        }
        #endregion

        #region Connexion à l'initialisation de la fênetre
        private void FormMajFournisseurs_Load(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection();
            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["papyrusConnectionString"];
            if (oConfig != null)
            {
                sqlConnect.ConnectionString = oConfig.ConnectionString;
            }

            try
            {
                sqlConnect.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            this.MajListBoxFournisseurs();

            this.comboBoxListeFournisseurs.SelectedIndex = -1;
            this.textBoxCodeFournisseur.ResetText();
            this.ResetTextBoxes();
            this.buttonModifier.Enabled = false;
            this.buttonSupprimer.Enabled = false;

        }
        #endregion

        #region Mise à jour liste fournisseurs
        private void MajListBoxFournisseurs()
        {
            this.comboBoxListeFournisseurs.DisplayMember = "Value";
            this.comboBoxListeFournisseurs.ValueMember = "Key";
            listeFournisseurs = new Dictionary<int, string>();


            try
            {
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;
                string strSql = "select fournisseur_id, fournisseur_nom from fournisseurs";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();


                while (sqlReader.Read())
                {
                    listeFournisseurs.Add((int)sqlReader["fournisseur_id"], sqlReader["fournisseur_nom"].ToString());
                }

                sqlReader.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            this.comboBoxListeFournisseurs.DataSource = new BindingSource(listeFournisseurs, null);
            this.comboBoxListeFournisseurs.SelectedIndex = -1;

        }
        #endregion

        #region Selection d'un fournisseur dans la liste
        private void comboBoxListeFournisseurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxListeFournisseurs.SelectedIndex >= 0)
            {
                textBoxCodeFournisseur.ReadOnly = false;
                try
                {
                    sqlReader.Close();
                    sqlCommande = new SqlCommand();
                    sqlCommande.Connection = sqlConnect;

                    SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.Int32);
                    sqlCodeFournisseur.Value = comboBoxListeFournisseurs.SelectedValue;
                    sqlCommande.Parameters.Add(sqlCodeFournisseur);

                    int id = Int32.Parse(sqlCodeFournisseur.Value.ToString());

                    string strSql = "Select * from fournisseurs where fournisseur_id =@codeFournisseur";
                    sqlCommande.CommandType = CommandType.Text;
                    sqlCommande.CommandText = strSql;

                    sqlReader = sqlCommande.ExecuteReader();

                    if (sqlReader.Read() && ((int)sqlReader["fournisseur_id"]).Equals(id))
                    {
                        mode = ModeBDD.lecture;

                        buttonModifier.Enabled = true;
                        buttonSupprimer.Enabled = true;

                        string idFournisseur = sqlReader["fournisseur_id"].ToString();
                        string nomFournisseur = sqlReader["fournisseur_nom"].ToString();
                        string adresseFournisseur = sqlReader["fournisseur_adresse"].ToString();
                        string cpFournisseur = sqlReader["fournisseur_cp"].ToString();
                        string villeFournisseur = sqlReader["fournisseur_ville"].ToString();
                        string contactFournisseur = sqlReader["fournisseur_contact"].ToString();
                        string satisfactionFournisseur = sqlReader["fournisseur_satisfaction"].ToString();

                        textBoxCodeFournisseur.Text = idFournisseur;
                        textBoxNomFournisseur.Text = nomFournisseur;
                        textBoxAdresseFournisseur.Text = adresseFournisseur;
                        textBoxCpFournisseur.Text = cpFournisseur;
                        textBoxVilleFournisseur.Text = villeFournisseur;
                        textBoxContactFournisseur.Text = contactFournisseur;
                        textBoxSatisfactionFournisseur.Text = satisfactionFournisseur;

                    }
                    else
                    {
                        buttonModifier.Enabled = false;
                        buttonSupprimer.Enabled = false;
                    }

                    sqlReader.Close();

                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
                buttonRechercher.Enabled = false;
            }

        }
        #endregion

        #region Rechercher un fournisseur par son code
        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            mode = ModeBDD.lecture;

            try
            {
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;

                SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.Int32);
                sqlCodeFournisseur.Value = textBoxCodeFournisseur.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);

                int id = Int32.Parse(sqlCodeFournisseur.Value.ToString());

                string strSql = "Select * from fournisseurs where fournisseur_id =@codeFournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                if (sqlReader.Read() && ((int)sqlReader["fournisseur_id"]).Equals(id))
                {
                    buttonModifier.Enabled = true;
                    buttonSupprimer.Enabled = true;

                    string nomFournisseur = sqlReader["fournisseur_nom"].ToString();
                    string adresseFournisseur = sqlReader["fournisseur_adresse"].ToString();
                    string cpFournisseur = sqlReader["fournisseur_cp"].ToString();
                    string villeFournisseur = sqlReader["fournisseur_ville"].ToString();
                    string contactFournisseur = sqlReader["fournisseur_contact"].ToString();
                    string satisfactionFournisseur = sqlReader["fournisseur_satisfaction"].ToString();

                    textBoxNomFournisseur.Text = nomFournisseur;
                    textBoxAdresseFournisseur.Text = adresseFournisseur;
                    textBoxCpFournisseur.Text = cpFournisseur;
                    textBoxVilleFournisseur.Text = villeFournisseur;
                    textBoxContactFournisseur.Text = contactFournisseur;
                    textBoxSatisfactionFournisseur.Text = satisfactionFournisseur;

                }
                else
                {
                    buttonModifier.Enabled = false;
                    buttonSupprimer.Enabled = false;
                    errorProviderCodeFournisseur.SetError(textBoxCodeFournisseur, "Aucun fournisseur correspondant");

                    this.ResetTextBoxes();
                }

                foreach (KeyValuePair<int, string> item in listeFournisseurs)
                {
                    if (item.Key == Int32.Parse(sqlCodeFournisseur.Value.ToString()))
                    {
                        comboBoxListeFournisseurs.SelectedItem = item;
                    }
                }
                sqlReader.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

        }
        #endregion

        #region Saisie code fournisseur
        private void textBoxCodeFournisseur_TextChanged(object sender, EventArgs e)
        {
            mode = ModeBDD.lecture;

            if (textBoxCodeFournisseur.TextLength > 0)
            {
                buttonRechercher.Enabled = true;
            }
            else
            {
                buttonRechercher.Enabled = false;
                buttonModifier.Enabled = false;
                buttonSupprimer.Enabled = false;
            }
            ResetTextBoxes();

            if (comboBoxListeFournisseurs.SelectedIndex < 0)
            {
                buttonModifier.Enabled = false;
                buttonSupprimer.Enabled = false;
            }
        }
        private void textBoxCodeFournisseur_KeyPress(object sender, KeyPressEventArgs e)
        {
            mode = ModeBDD.lecture;

            comboBoxListeFournisseurs.SelectedIndex = -1;
        }

        #endregion

        #region Creer nouveau fournisseur
        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            mode = ModeBDD.ajout;
            this.MiseAjourControles();
            errorProviderSaisie.Clear();
            this.ResetTextBoxes();
            textBoxCodeFournisseur.ResetText();
            this.comboBoxListeFournisseurs.SelectedIndex = -1;
        }
        #endregion

        #region Annuler saisie nouveau fournisseur ou modification
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            mode = ModeBDD.lecture;
            errorProviderSaisie.Clear();

            comboBoxListeFournisseurs.SelectedIndex = -1;
            textBoxCodeFournisseur.ResetText();

            this.ResetTextBoxes();
            this.MiseAjourControles();

        }
        #endregion

        #region Ajouter un fournisseur 
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            mode = ModeBDD.lecture;

            errorProviderSaisie.Clear();

            if (SaisieValide())
            {
                try
                {
                    sqlCommande = new SqlCommand();
                    sqlCommande.Connection = sqlConnect;

                    sqlCommande.CommandType = CommandType.StoredProcedure;
                    sqlCommande.CommandText = "ajoutFournisseur";

                    SqlParameter sqlNomFournisseur = new SqlParameter("@nomFournisseur", SqlDbType.VarChar, 50);
                    sqlNomFournisseur.Value = textBoxNomFournisseur.Text;
                    SqlParameter sqlAdresseFournisseur = new SqlParameter("@adresseFournisseur", SqlDbType.VarChar, 100);
                    sqlAdresseFournisseur.Value = textBoxAdresseFournisseur.Text;
                    SqlParameter sqlCpFournisseur = new SqlParameter("@cpFournisseur", SqlDbType.VarChar, 5);
                    sqlCpFournisseur.Value = textBoxCpFournisseur.Text;
                    SqlParameter sqlVilleFournisseur = new SqlParameter("@villeFournisseur", SqlDbType.VarChar, 50);
                    sqlVilleFournisseur.Value = textBoxVilleFournisseur.Text;
                    SqlParameter sqlContactFournisseur = new SqlParameter("@contactFournisseur", SqlDbType.VarChar, 50);
                    sqlContactFournisseur.Value = textBoxContactFournisseur.Text;
                    SqlParameter sqlSatisfactionFournisseur = new SqlParameter("@satisfactionFournisseur", SqlDbType.TinyInt);
                    sqlSatisfactionFournisseur.Value = textBoxSatisfactionFournisseur.Text;

                    SqlParameter pIdOut = new SqlParameter("@idFournisseur", SqlDbType.Int);
                    pIdOut.Direction = ParameterDirection.Output;

                    SqlParameter[] sqlParams = new SqlParameter[] { sqlNomFournisseur, sqlAdresseFournisseur, sqlCpFournisseur, sqlVilleFournisseur, sqlContactFournisseur, sqlSatisfactionFournisseur, pIdOut };

                    sqlCommande.Parameters.AddRange(sqlParams);


                    int sqlNbLignesAffectees = sqlCommande.ExecuteNonQuery();

                    if (sqlNbLignesAffectees == 1)
                    {
                        MessageBox.Show("Fournisseur ajouté avec succes\nID :" + pIdOut.Value);
                        this.MajListBoxFournisseurs();

                        this.MiseAjourControles();
                        foreach (KeyValuePair<int, string> item in listeFournisseurs)
                        {
                            if (item.Key == Int32.Parse(pIdOut.Value.ToString()))
                            {
                                comboBoxListeFournisseurs.SelectedItem = item;
                            }
                        }
                    }
                }
                catch (SqlException se)
                {
                    MessageBox.Show("Ajout impossible");
                    MessageBox.Show(se.Message);
                }

            }
            else
            {
                errorProviderSaisie.SetError(buttonAjouter, "Ajout impossible, saisie incorrecte");
            }

        }
        #endregion

        #region supprimer un fournisseur
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            mode = ModeBDD.lecture;

            try
            {
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;

                SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.Int64);
                sqlCodeFournisseur.Value = textBoxCodeFournisseur.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);


                string strSql = "DELETE from fournisseurs where fournisseur_id =@codeFournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                int sqlNbLignesAffectees = sqlCommande.ExecuteNonQuery();

                if (sqlNbLignesAffectees == 1)
                {
                    MessageBox.Show("Suppression effectuée");

                }
                else
                {
                    MessageBox.Show("Suppression impossible");

                }

                this.MajListBoxFournisseurs();
                this.ResetTextBoxes();
                textBoxCodeFournisseur.ResetText();
            }
            catch (SqlException se)
            {
                //  MessageBox.Show(se.Message);
                errorProviderSuppression.SetError(buttonSupprimer, "Impossible de supprimer un fournisseur pour lequel il existe une commande ou vente");

            }
        }
        #endregion

        #region Vider champs texte
        private void ResetTextBoxes()
        {
            textBoxNomFournisseur.ResetText();
            textBoxAdresseFournisseur.ResetText();
            textBoxCpFournisseur.ResetText();
            textBoxVilleFournisseur.ResetText();
            textBoxContactFournisseur.ResetText();
            textBoxSatisfactionFournisseur.ResetText();
        }
        #endregion

        #region Modifier un fournisseur
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            mode = ModeBDD.modification;

            this.MiseAjourControles();

        }
        #endregion

        #region Activation/Desactivation des boutons et champs en fonction du mode en cours
        private void MiseAjourControles()
        {
            errorProviderSuppression.Clear();
            errorProviderCodeFournisseur.Clear();
            switch (mode)
            {
                case ModeBDD.lecture:
                    buttonAjouter.Enabled = false;
                    buttonAnnuler.Enabled = false;
                    buttonAjouter.Visible = false;
                    buttonAnnuler.Visible = false;
                    buttonNouveau.Enabled = true;
                    buttonValider.Enabled = false;
                    buttonValider.Visible = false;
                    comboBoxListeFournisseurs.Enabled = true;
                    textBoxCodeFournisseur.ReadOnly = false;
                    textBoxCodeFournisseur.Enabled = true;
                    foreach (TextBox tB in panelTBFournisseur.Controls)
                    {
                        tB.ReadOnly = true;
                    }
                    foreach (Control c in panelSelectFournisseur.Controls)
                    {
                        c.Visible = true;
                    }
                    break;
                case ModeBDD.ajout:
                    buttonAjouter.Enabled = true;
                    buttonAnnuler.Enabled = true;
                    buttonAjouter.Visible = true;
                    buttonAnnuler.Visible = true;
                    buttonValider.Enabled = false;
                    buttonValider.Visible = false;
                    buttonNouveau.Enabled = false;
                    foreach (Control c in panelSelectFournisseur.Controls)
                    {
                        c.Visible = false;
                    }
                    foreach (TextBox tB in panelTBFournisseur.Controls)
                    {
                        tB.ReadOnly = false;
                    }
                    break;
                case ModeBDD.modification:
                    buttonValider.Enabled = true;
                    buttonAnnuler.Enabled = true;
                    buttonValider.Visible = true;
                    buttonAnnuler.Visible = true;
                    buttonSupprimer.Enabled = false;
                    buttonNouveau.Enabled = false;
                    buttonModifier.Enabled = false;
                    textBoxCodeFournisseur.ReadOnly = true;
                    textBoxCodeFournisseur.Enabled = false;
                    comboBoxListeFournisseurs.Enabled = false;
                    foreach (TextBox tB in panelTBFournisseur.Controls)
                    {
                        tB.ReadOnly = false;
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region Valider modification fournisseur
        private void buttonValider_Click(object sender, EventArgs e)
        {
            mode = ModeBDD.lecture;

            if (SaisieValide())
            {
                try
                {
                    sqlCommande = new SqlCommand();
                    sqlCommande.Connection = sqlConnect;

                    SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.Int32);
                    sqlCodeFournisseur.Value = textBoxCodeFournisseur.Text;
                    SqlParameter sqlNomFournisseur = new SqlParameter("@nomFournisseur", DbType.String);
                    sqlNomFournisseur.Value = textBoxNomFournisseur.Text;
                    SqlParameter sqlAdresseFournisseur = new SqlParameter("@adresseFournisseur", DbType.String);
                    sqlAdresseFournisseur.Value = textBoxAdresseFournisseur.Text;
                    SqlParameter sqlCpFournisseur = new SqlParameter("@cpFournisseur", DbType.String);
                    sqlCpFournisseur.Value = textBoxCpFournisseur.Text;
                    SqlParameter sqlVilleFournisseur = new SqlParameter("@villeFournisseur", DbType.String);
                    sqlVilleFournisseur.Value = textBoxVilleFournisseur.Text;
                    SqlParameter sqlContactFournisseur = new SqlParameter("@contactFournisseur", DbType.String);
                    sqlContactFournisseur.Value = textBoxContactFournisseur.Text;
                    SqlParameter sqlSatisfactionFournisseur = new SqlParameter("@satisfactionFournisseur", DbType.Int16);
                    sqlSatisfactionFournisseur.Value = textBoxSatisfactionFournisseur.Text;

                    SqlParameter[] sqlParams = new SqlParameter[] { sqlCodeFournisseur, sqlNomFournisseur, sqlAdresseFournisseur,
                    sqlCpFournisseur, sqlVilleFournisseur, sqlContactFournisseur, sqlSatisfactionFournisseur };

                    sqlCommande.Parameters.AddRange(sqlParams);

                    string strSql = "UPDATE fournisseurs " +
                        "SET fournisseur_nom =@nomFournisseur, " +
                        "fournisseur_adresse=@adresseFournisseur, " +
                        "fournisseur_cp=@cpFournisseur, " +
                        "fournisseur_ville=@villeFournisseur, " +
                        "fournisseur_contact=@contactFournisseur, " +
                        "fournisseur_satisfaction=@satisfactionFournisseur " +
                        "WHERE fournisseur_id =@codeFournisseur ";
                    sqlCommande.CommandType = CommandType.Text;
                    sqlCommande.CommandText = strSql;
                    int sqlNbLignesAffectees = sqlCommande.ExecuteNonQuery();

                    if (sqlNbLignesAffectees == 1)
                    {
                        MessageBox.Show("Modification effectuée");

                        textBoxCodeFournisseur.ReadOnly = false;
                        textBoxCodeFournisseur.Enabled = true;

                        foreach (KeyValuePair<int, string> item in listeFournisseurs)
                        {
                            if (item.Key == Int32.Parse(sqlCodeFournisseur.Value.ToString()))
                            {
                                comboBoxListeFournisseurs.SelectedItem = item;
                            }
                        }
                    }
                }
                catch (SqlException se)
                {
                    MessageBox.Show("Modification impossible");
                    MessageBox.Show(se.Message);
                }

                foreach (TextBox tB in panelTBFournisseur.Controls)
                {
                    tB.ReadOnly = true;

                }
                buttonValider.Enabled = false;
                buttonAnnuler.Enabled = false;
                buttonValider.Visible = false;
                buttonAnnuler.Visible = false;
                comboBoxListeFournisseurs.Enabled = true;
                buttonNouveau.Enabled = true;

                buttonSupprimer.Enabled = true;
                buttonModifier.Enabled = true;
            }
            else
            {
                errorProviderSaisie.SetError(buttonValider, "Modification impossible : saisie incorrecte");
            }
        }
        #endregion

        #region validation saisie ajout/modification fournisseur
        private void textBoxNomFournisseur_Validating(object sender, CancelEventArgs e)
        {
            if (!ClassVerifications.ValidNom(textBoxNomFournisseur.Text))
            {
                if (textBoxNomFournisseur.TextLength < 1)
                {
                    errorProviderSaisie.SetError(textBoxNomFournisseur, "Champ obligatoire");
                }
                else
                {
                    errorProviderSaisie.SetError(textBoxNomFournisseur, "Nom au format invalide");
                }
            }

        }

        private void textBoxAdresseFournisseur_Validating(object sender, CancelEventArgs e)
        {

            if (textBoxAdresseFournisseur.TextLength < 1)
            {
                errorProviderSaisie.SetError(textBoxAdresseFournisseur, "Champ obligatoire");
            }

        }

        private void textBoxCpFournisseur_Validating(object sender, CancelEventArgs e)
        {
            if (!ClassVerifications.ValidCP(textBoxCpFournisseur.Text))
            {
                if (textBoxCpFournisseur.TextLength < 1)
                {
                    errorProviderSaisie.SetError(textBoxCpFournisseur, "Champ obligatoire");
                }
                else
                {
                    errorProviderSaisie.SetError(textBoxCpFournisseur, "Code postal invalide");
                }
            }
        }

        private void textBoxVilleFournisseur_Validating(object sender, CancelEventArgs e)
        {
            if (!ClassVerifications.ValidNom(textBoxVilleFournisseur.Text))
            {
                if (textBoxVilleFournisseur.TextLength < 1)
                {
                    errorProviderSaisie.SetError(textBoxVilleFournisseur, "Champ obligatoire");
                }
                else
                {
                    errorProviderSaisie.SetError(textBoxVilleFournisseur, "Nom de ville au format invalide");
                }
            }
        }

        private void textBoxContactFournisseur_Validating(object sender, CancelEventArgs e)
        {
            if (!ClassVerifications.ValidNom(textBoxContactFournisseur.Text))
            {
                if (textBoxContactFournisseur.TextLength < 1)
                {
                    errorProviderSaisie.SetError(textBoxContactFournisseur, "Champ obligatoire");
                }
                else
                {
                    errorProviderSaisie.SetError(textBoxContactFournisseur, "Nom au format invalide");
                }
            }
        }

        private void textBoxSatisfactionFournisseur_Validating(object sender, CancelEventArgs e)
        {
            if (!ClassVerifications.ValidMontantInt(textBoxSatisfactionFournisseur.Text))
            {
                if (textBoxSatisfactionFournisseur.TextLength < 1)
                {
                    errorProviderSaisie.SetError(textBoxSatisfactionFournisseur, "Champ obligatoire");
                }
                else
                {
                    errorProviderSaisie.SetError(textBoxSatisfactionFournisseur, "Note invalide");
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

        private void textBoxNomFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderSaisie.Clear();
        }

        private void textBoxAdresseFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderSaisie.Clear();

        }

        private void textBoxCpFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderSaisie.Clear();

        }

        private void textBoxVilleFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderSaisie.Clear();

        }

        private void textBoxContactFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderSaisie.Clear();

        }

        private void textBoxSatisfactionFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderSaisie.Clear();

        }
        #endregion

        #region Fermeture de la fenetre
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormMajFournisseurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnect.Close();
        }
        #endregion
    }
}
