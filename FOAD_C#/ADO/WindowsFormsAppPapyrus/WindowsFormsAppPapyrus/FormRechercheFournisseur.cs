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
    public partial class FormRechercheFournisseur : Form
    {
        public delegate void DelegateFournisseur(string nom, string adresse, string cp, string ville, string contact, string satisfaction, FormRechercheFournisseur formSender);
        public event DelegateFournisseur RechercheFournisseur;

        private SqlConnection sqlConnect;
        private SqlCommand sqlCommande;
        private SqlDataReader sqlReader;


        public FormRechercheFournisseur()
        {
            InitializeComponent();
            this.AcceptButton = buttonValider;
            this.CancelButton = buttonQuitter;
        }

        private void buttonValider_Click(object sender, EventArgs e)
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
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;

                SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.Int64);
                sqlCodeFournisseur.Value = textBoxCodeFournisseur.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);

                int id = Int32.Parse(sqlCodeFournisseur.Value.ToString());

                string strSql = "Select * from fournisseurs where fournisseur_id =@codeFournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();


                if (sqlReader.Read() && ((int)sqlReader["fournisseur_id"]).Equals(id))
                {
                    string nomFournisseur = sqlReader["fournisseur_nom"].ToString();
                    string adresseFournisseur = sqlReader["fournisseur_adresse"].ToString();
                    string cpFournisseur = sqlReader["fournisseur_cp"].ToString();
                    string villeFournisseur = sqlReader["fournisseur_ville"].ToString();
                    string contactFournisseur = sqlReader["fournisseur_contact"].ToString();
                    string satisfactionFournisseur = sqlReader["fournisseur_satisfaction"].ToString();

                    textBoxCodeFournisseur.SelectAll();
                    RechercheFournisseur(nomFournisseur, adresseFournisseur, cpFournisseur, villeFournisseur, contactFournisseur, satisfactionFournisseur, this);
                }
                else
                {
                    errorProviderCodeFournisseurIntrouvable.SetError(textBoxCodeFournisseur, "Aucun fournisseur trouvé");
                }

                sqlReader.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                sqlConnect.Close();
            }

        }

        private void textBoxFournisseur_TextChanged(object sender, EventArgs e)
        {
            errorProviderCodeFournisseurIntrouvable.Clear();

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelCodeFournisseur_Click(object sender, EventArgs e)
        {

        }
    }
}
