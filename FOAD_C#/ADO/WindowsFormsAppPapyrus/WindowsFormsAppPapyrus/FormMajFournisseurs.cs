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

        private SqlConnection sqlConnect;
        private SqlCommand sqlCommande;
        private SqlDataReader sqlReader;

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
        private void MajListBoxFournisseurs()
        {
            comboBoxListeFournisseurs.Items.Clear();
            try
            {
                // sqlConnect.Open();
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;
                string strSql = "select fournisseur_nom from fournisseurs";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        this.comboBoxListeFournisseurs.Items.Add(sqlReader.GetString(0));
                    }
                }

                sqlReader.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            //finally
            //{
            //    sqlConnect.Close();
            //}
        }

        private void ReintTextBoxes()
        {
            textBoxCodeFournisseur.ResetText();
            textBoxNomFournisseur.ResetText();
            textBoxAdresseFournisseur.ResetText();
            textBoxCpFournisseur.ResetText();
            textBoxVilleFournisseur.ResetText();
            textBoxContactFournisseur.ResetText();
            textBoxSatisfactionFournisseur.ResetText();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxListeFournisseurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxListeFournisseurs.SelectedIndex >= 0)
            {
                buttonModifier.Enabled = true;
                buttonSupprimer.Enabled = true;

                buttonAjouter.Enabled = false;
                buttonAnnuler.Enabled = false;

                textBoxCodeFournisseur.ReadOnly = false;

                errorProviderCodeFournisseur.Clear();

                //sqlConnect = new SqlConnection();
                //ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["papyrusConnectionString"];
                //if (oConfig != null)
                //{
                //    sqlConnect.ConnectionString = oConfig.ConnectionString;
                //}

                try
                {
                    //   sqlConnect.Open();
                    sqlCommande = new SqlCommand();
                    sqlCommande.Connection = sqlConnect;

                    SqlParameter sqlNomFournisseur = new SqlParameter("@nomFournisseur", DbType.String);
                    sqlNomFournisseur.Value = comboBoxListeFournisseurs.Text;
                    sqlCommande.Parameters.Add(sqlNomFournisseur);


                    string strSql = "Select * from fournisseurs where fournisseur_nom =@nomFournisseur";
                    sqlCommande.CommandType = CommandType.Text;
                    sqlCommande.CommandText = strSql;


                    sqlReader = sqlCommande.ExecuteReader();

                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            string idFournisseur = sqlReader.GetInt32(0).ToString();
                            string nomFournisseur = sqlReader.GetString(1);
                            string adresseFournisseur = sqlReader.GetString(2);
                            string cpFournisseur = sqlReader.GetString(3);
                            string villeFournisseur = sqlReader.GetString(4);
                            string contactFournisseur = sqlReader.GetString(5);
                            string satisfactionFournisseur = sqlReader.GetByte(6).ToString();

                            // textBoxCodeFournisseur.SelectAll();
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
                        //errorProver
                    }

                    sqlReader.Close();

                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
                //finally
                //{
                //    sqlConnect.Close();
                //}




            }

        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            //sqlConnect = new SqlConnection();
            //ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["papyrusConnectionString"];
            //if (oConfig != null)
            //{
            //    sqlConnect.ConnectionString = oConfig.ConnectionString;
            //}

            try
            {
                //   sqlConnect.Open();
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;

                SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.Int64);
                sqlCodeFournisseur.Value = textBoxCodeFournisseur.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);


                string strSql = "Select * from fournisseurs where fournisseur_id =@codeFournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                if (sqlReader.HasRows)
                {
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
                    errorProviderCodeFournisseur.SetError(textBoxCodeFournisseur, "Aucun fournisseur correspondant");
                    //  comboBoxListeFournisseurs.SelectedIndex = -1;
                    textBoxNomFournisseur.ResetText();
                    textBoxAdresseFournisseur.ResetText();
                    textBoxCpFournisseur.ResetText();
                    textBoxVilleFournisseur.ResetText();
                    textBoxContactFournisseur.ResetText();
                    textBoxSatisfactionFournisseur.ResetText();
                }

                sqlReader.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            //finally
            //{
            //    sqlConnect.Close();
            //}
            this.MajListBoxFournisseurs();

        }

        private void textBoxCodeFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderCodeFournisseur.Clear();
            buttonRechercher.Enabled = true;


        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            this.MajListBoxFournisseurs();

            buttonAjouter.Enabled = true;
            buttonAnnuler.Enabled = true;

            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;

            //   comboBoxListeFournisseurs.SelectedIndex = -1;

            textBoxCodeFournisseur.ResetText();
            textBoxNomFournisseur.ResetText();
            textBoxAdresseFournisseur.ResetText();
            textBoxCpFournisseur.ResetText();
            textBoxVilleFournisseur.ResetText();
            textBoxContactFournisseur.ResetText();
            textBoxSatisfactionFournisseur.ResetText();

            buttonRechercher.Enabled = false;
            textBoxCodeFournisseur.ReadOnly = true;
            textBoxNomFournisseur.ReadOnly = false;
            textBoxAdresseFournisseur.ReadOnly = false;
            textBoxCpFournisseur.ReadOnly = false;
            textBoxVilleFournisseur.ReadOnly = false;
            textBoxContactFournisseur.ReadOnly = false;
            textBoxSatisfactionFournisseur.ReadOnly = false;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            textBoxCodeFournisseur.ReadOnly = false;

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                //  sqlConnect.Open();
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

                }
                else
                {
                    MessageBox.Show("Ajout impossible");
                }

                //  sqlReader.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            //finally
            //{
            //    sqlConnect.Close();
            //}
            this.MajListBoxFournisseurs();

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                //  sqlConnect.Open();
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

                //  sqlReader.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            //finally
            //{
            //    sqlConnect.Close();
            //}
            this.MajListBoxFournisseurs();
            this.ReintTextBoxes();

        }

        private void FormMajFournisseurs_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnect.Close();
        }
    }
}
