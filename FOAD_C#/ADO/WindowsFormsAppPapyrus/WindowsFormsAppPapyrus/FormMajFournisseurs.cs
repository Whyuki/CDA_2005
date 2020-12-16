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
        #endregion

        #region Constructeur
        public FormMajFournisseurs()
        {
            InitializeComponent();
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
            try
            {
                sqlConnect.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            this.MajListBoxFournisseurs();
        }
        #endregion

        #region Mise à jour liste fournisseurs

        private void MajListBoxFournisseurs()
        {
            errorProviderSuppression.Clear();

            comboBoxListeFournisseurs.DisplayMember = "Text";
            comboBoxListeFournisseurs.ValueMember = "Value";
            listeFournisseurs = new Dictionary<int, string>();

            sqlConnect = new SqlConnection();
            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["papyrusConnectionString"];
            if (oConfig != null)
            {
                sqlConnect.ConnectionString = oConfig.ConnectionString;
            }
            try
            {
                sqlConnect.Open();
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;
                string strSql = "select  fournisseur_id, fournisseur_nom from fournisseurs";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();


                while (sqlReader.Read())
                {
                    listeFournisseurs.Add(sqlReader.GetInt32(0), sqlReader.GetString(1));
                }

                sqlReader.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }


            this.comboBoxListeFournisseurs.DataSource = new BindingSource(listeFournisseurs, null);
            this.comboBoxListeFournisseurs.DisplayMember = "Value";
            this.comboBoxListeFournisseurs.ValueMember = "Key";

            this.comboBoxListeFournisseurs.SelectedIndex = -1;
        }
        #endregion

        #region Selection d'un fournisseur dans la liste
        private void comboBoxListeFournisseurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderSuppression.Clear();
            if (comboBoxListeFournisseurs.SelectedIndex >= 0)
            {
                textBoxCodeFournisseur.ReadOnly = false;

                try
                {
                    sqlReader.Close();
                    sqlCommande = new SqlCommand();
                    sqlCommande.Connection = sqlConnect;

                    SqlParameter sqlNomFournisseur = new SqlParameter("@codeFournisseur", DbType.Int32);
                    sqlNomFournisseur.Value = comboBoxListeFournisseurs.SelectedValue;
                    sqlCommande.Parameters.Add(sqlNomFournisseur);


                    string strSql = "Select * from fournisseurs where fournisseur_id =@codeFournisseur";
                    sqlCommande.CommandType = CommandType.Text;
                    sqlCommande.CommandText = strSql;

                    sqlReader = sqlCommande.ExecuteReader();

                    if (sqlReader.HasRows)
                    {
                        buttonModifier.Enabled = true;
                        buttonSupprimer.Enabled = true;
                        while (sqlReader.Read())
                        {
                            string idFournisseur = sqlReader.GetInt32(0).ToString();
                            string nomFournisseur = sqlReader.GetString(1);
                            string adresseFournisseur = sqlReader.GetString(2);
                            string cpFournisseur = sqlReader.GetString(3);
                            string villeFournisseur = sqlReader.GetString(4);
                            string contactFournisseur = sqlReader.GetString(5);
                            string satisfactionFournisseur = sqlReader.GetByte(6).ToString();

                            textBoxCodeFournisseur.Text = idFournisseur;
                            textBoxNomFournisseur.Text = nomFournisseur;
                            textBoxAdresseFournisseur.Text = adresseFournisseur;
                            textBoxCpFournisseur.Text = cpFournisseur;
                            textBoxVilleFournisseur.Text = villeFournisseur;
                            textBoxContactFournisseur.Text = contactFournisseur;
                            textBoxSatisfactionFournisseur.Text = satisfactionFournisseur;

                        }
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
            try
            {
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;

                SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.Int32);
                sqlCodeFournisseur.Value = textBoxCodeFournisseur.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);


                string strSql = "Select * from fournisseurs where fournisseur_id =@codeFournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    buttonModifier.Enabled = true;
                    buttonSupprimer.Enabled = true;

                    while (sqlReader.Read())
                    {
                        string nomFournisseur = sqlReader.GetString(1);
                        string adresseFournisseur = sqlReader.GetString(2);
                        string cpFournisseur = sqlReader.GetString(3);
                        string villeFournisseur = sqlReader.GetString(4);
                        string contactFournisseur = sqlReader.GetString(5);
                        string satisfactionFournisseur = sqlReader.GetByte(6).ToString();

                        // textBoxCodeFournisseur.SelectAll();
                        textBoxNomFournisseur.Text = nomFournisseur;
                        textBoxAdresseFournisseur.Text = adresseFournisseur;
                        textBoxCpFournisseur.Text = cpFournisseur;
                        textBoxVilleFournisseur.Text = villeFournisseur;
                        textBoxContactFournisseur.Text = contactFournisseur;
                        textBoxSatisfactionFournisseur.Text = satisfactionFournisseur;
                    }
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
                    if (item.Key == Int32.Parse(textBoxCodeFournisseur.Text))
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
            errorProviderSuppression.Clear();

            errorProviderCodeFournisseur.Clear();
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
            errorProviderCodeFournisseur.Clear();
            if (comboBoxListeFournisseurs.SelectedIndex < 0)
            {
                buttonModifier.Enabled = false;
                buttonSupprimer.Enabled = false;
            }
        }
        private void textBoxCodeFournisseur_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxListeFournisseurs.SelectedIndex = -1;
        }

        #endregion

        #region Creer nouveau fournisseur
        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            errorProviderSuppression.Clear();

            this.MajListBoxFournisseurs();

            foreach (Control c in panelSelectFournisseur.Controls)
            {
                c.Visible = false;
            }

            buttonAjouter.Enabled = true;
            buttonAnnuler.Enabled = true;
            buttonAjouter.Visible = true;
            buttonAnnuler.Visible = true;
            buttonValider.Enabled = false;
            buttonValider.Visible = false;

            this.ResetTextBoxes();
            textBoxCodeFournisseur.ResetText();


            foreach (TextBox tB in panelTBFournisseur.Controls)
            {
                tB.ReadOnly = false;
            }

            buttonNouveau.Enabled = false;

        }
        #endregion

        #region Annuler saisie nouveau fournisseur ou modification
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            errorProviderSuppression.Clear();
            textBoxCodeFournisseur.ResetText();
            textBoxCodeFournisseur.ReadOnly = false;
            comboBoxListeFournisseurs.SelectedIndex = -1;
            foreach (Control c in panelSelectFournisseur.Controls)
            {
                c.Visible = true;
            }

            foreach (TextBox tB in panelTBFournisseur.Controls)
            {
                tB.ReadOnly = true;
            }
            this.ResetTextBoxes();

            buttonAjouter.Enabled = false;
            buttonAnnuler.Enabled = false;
            buttonAjouter.Visible = false;
            buttonAnnuler.Visible = false;
            buttonValider.Enabled = false;
            buttonValider.Visible = false;

            buttonNouveau.Enabled = true;

            comboBoxListeFournisseurs.Enabled = true;

        }
        #endregion

        #region Ajouter un fournisseur 
        //to-do : verif champs, methode ajout
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;

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

                SqlParameter[] sqlParams = new SqlParameter[] { sqlNomFournisseur, sqlAdresseFournisseur, sqlCpFournisseur, sqlVilleFournisseur, sqlContactFournisseur, sqlSatisfactionFournisseur };

                sqlCommande.Parameters.AddRange(sqlParams);


                string strSql = "INSERT INTO fournisseurs (fournisseur_nom, fournisseur_adresse, fournisseur_cp, fournisseur_ville, fournisseur_contact, fournisseur_satisfaction) " +
                    "VALUES(@nomFournisseur, @adresseFournisseur, @cpFournisseur, @villeFournisseur, @contactFournisseur, @satisfactionFournisseur) ";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                int sqlNbLignesAffectees = sqlCommande.ExecuteNonQuery();

                if (sqlNbLignesAffectees > 0)
                {
                    MessageBox.Show("Ajout effectué");
                    this.MajListBoxFournisseurs();

                    comboBoxListeFournisseurs.SelectedIndex = comboBoxListeFournisseurs.Items.Count - 1;
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("Ajout impossible");
                MessageBox.Show(se.Message);
            }



            foreach (Control c in panelSelectFournisseur.Controls)
            {
                c.Visible = true;
            }

            buttonAjouter.Enabled = false;
            buttonAnnuler.Enabled = false;
            buttonAjouter.Visible = false;
            buttonAnnuler.Visible = false;

            buttonNouveau.Enabled = true;

        
        }
        #endregion

        #region supprimer un fournisseur
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
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

                if (sqlNbLignesAffectees > 0)
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

        #region Modifier un fournisseur
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            errorProviderSuppression.Clear();

            foreach (TextBox tB in panelTBFournisseur.Controls)
            {
                tB.ReadOnly = false;

            }

            buttonValider.Enabled = true;
            buttonAnnuler.Enabled = true;
            buttonValider.Visible = true;
            buttonAnnuler.Visible = true;

            textBoxCodeFournisseur.ReadOnly = true;
            comboBoxListeFournisseurs.Enabled = false;
        }
        #endregion

        #region Valider modification fournisseur
        private void buttonValider_Click(object sender, EventArgs e)
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

                if (sqlNbLignesAffectees > 0)
                {
                    MessageBox.Show("Modification effectuée");
           
                    textBoxCodeFournisseur.ReadOnly = false;
                    foreach (KeyValuePair<int, string> item in listeFournisseurs)
                    {
                        if (item.Key == Int32.Parse(textBoxCodeFournisseur.Text))
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

        }
        #endregion
    }
}
