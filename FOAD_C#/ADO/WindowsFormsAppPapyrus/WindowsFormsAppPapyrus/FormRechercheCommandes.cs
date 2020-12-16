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
            comboBoxListeFournisseurs.DisplayMember = "Text";
            comboBoxListeFournisseurs.ValueMember = "Value";
            Dictionary<int, string> listeFournisseurs = new Dictionary<int, string>();

            listeFournisseurs.Add(0, "Tous");


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
                string strSql = "select fournisseur_nom, fournisseur_id from fournisseurs";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;
                sqlReader = sqlCommande.ExecuteReader();

                
                    while (sqlReader.Read())
                    {
                        listeFournisseurs.Add(sqlReader.GetInt32(1), sqlReader.GetString(0));
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


        private void comboBoxListeFournisseurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetListeCommandes();
            if (this.comboBoxListeFournisseurs.SelectedIndex >= 0)
            {

                labelCommandes.Visible = true;
                listViewCommandes.Visible = true;

                try
                {
                    sqlCommande = new SqlCommand();
                    sqlCommande.Connection = sqlConnect;

                    if (((KeyValuePair<int, string>)comboBoxListeFournisseurs.SelectedItem).Value == "Tous")
                    {
                        string strSql = "Select * from commandes " +
                        "INNER JOIN lignes_commandes " +
                        "ON commandes.commande_id = lignes_commandes.commande_id " +
                        "INNER JOIN produits " +
                        "ON lignes_commandes.produit_id = produits.produit_id " +
                        "INNER JOIN fournisseurs " +
                        "ON produits.fournisseur_id = fournisseurs.fournisseur_id ";
               
                        sqlCommande.CommandType = CommandType.Text;
                        sqlCommande.CommandText = strSql;
                    }
                    else
                    {
                        sqlCommande.CommandType = CommandType.StoredProcedure;
                        sqlCommande.CommandText = "GetCommandesParFournisseur";

                        SqlParameter sqlCodeFournisseur = new SqlParameter("@codeFournisseur", DbType.Int32);
                        sqlCodeFournisseur.Value = comboBoxListeFournisseurs.SelectedValue;
                        sqlCommande.Parameters.Add(sqlCodeFournisseur);

                    }

                    sqlReader = sqlCommande.ExecuteReader();

                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            string idCommande = sqlReader.GetInt32(0).ToString();
                            string dateCommande = sqlReader.GetDateTime(1).ToString("d");
                            string commentaireCommande = sqlReader.GetString(2);

                            string[] infoCommande = new string[3];
                            infoCommande[0] = idCommande;
                            infoCommande[1] = dateCommande;
                            infoCommande[2] = commentaireCommande;
                            ListViewItem item = new ListViewItem(infoCommande);
                            listViewCommandes.Items.Add(item);

                        }
                    }
                    else
                    {
                        errorProviderCommandes.SetError(labelCommandes, "Aucune commande passée à ce fournisseur");
                    }

                    sqlReader.Close();

                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
               
            }
        }

        private void ResetListeCommandes()
        {
            listViewCommandes.Items.Clear();
            labelCommandes.Visible = false;
            listViewCommandes.Visible = false;
            errorProviderCommandes.Clear();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxListeFournisseurs_TextChanged(object sender, EventArgs e)
        {
            this.ResetListeCommandes();
        }

        private void FormRechercheCommandes_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnect.Close();
        }
    }
}

