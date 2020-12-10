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
    public partial class FormRechercheCommandes : Form
    {

        private SqlConnection sqlConnect;
        private SqlCommand sqlCommande;
        private SqlDataReader sqlReader;

        public FormRechercheCommandes()
        {
            InitializeComponent();
        }
        private void FormRechercheCommandes_Load(object sender, EventArgs e)
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
            finally
            {
                sqlConnect.Close();
            }

        }


        private void comboBoxListeFournisseurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBoxCommandesNum.Clear();
            this.richTextBoxCommandesDate.Clear();
            this.richTextBoxCommandesComment.Clear();
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

                SqlParameter sqlCodeFournisseur = new SqlParameter("@nomFournisseur", DbType.String);
                sqlCodeFournisseur.Value = comboBoxListeFournisseurs.Text;
                sqlCommande.Parameters.Add(sqlCodeFournisseur);


                string strSql = "Select * from commandes " +
                    "INNER JOIN lignes_commandes " +
                    "ON commandes.commande_id = lignes_commandes.commande_id " +
                    "INNER JOIN produits " +
                    "ON lignes_commandes.produit_id = produits.produit_id " +
                    "INNER JOIN fournisseurs " +
                    "ON produits.fournisseur_id = fournisseurs.fournisseur_id " +
                    "where fournisseur_nom =@nomFournisseur";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        string idCommande = sqlReader.GetInt32(0).ToString();
                        string dateCommande = sqlReader.GetDateTime(1).ToString("d");
                        string commentaireCommande = sqlReader.GetString(2);
                        this.richTextBoxCommandesNum.Text += idCommande + "\n";
                        this.richTextBoxCommandesDate.Text += dateCommande + "\n";
                        this.richTextBoxCommandesComment.Text += commentaireCommande + "\n";

                    }
                }
                else
                {
                    //  errorProviderCodeFournisseurIntrouvable.SetError(textBoxCodeFournisseur, "Aucun fournisseur trouvé");
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


    }
}
