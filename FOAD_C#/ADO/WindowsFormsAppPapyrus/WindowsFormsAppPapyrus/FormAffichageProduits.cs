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
    public partial class FormAffichageProduits : Form
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommande;
        private SqlDataAdapter sqlAdapter;
        private DataSet dts;
        public FormAffichageProduits()
        {
            InitializeComponent();
        }
        private void FormAffichageProduits_Load(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection();
            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["papyrusConnectionString"];
            if (oConfig != null)
            {
                sqlConnect.ConnectionString = oConfig.ConnectionString;
            }
            try
            {
                sqlCommande = new SqlCommand();
                sqlCommande.Connection = sqlConnect;
                string strSql = "select * from produits";
                sqlCommande.CommandType = CommandType.Text;
                sqlCommande.CommandText = strSql;

                dts = new DataSet("Produits");
                sqlAdapter = new SqlDataAdapter(sqlCommande);
                sqlAdapter.Fill(dts, "produits");

                foreach (DataRow item in dts.Tables["produits"].Rows)
                {
                    this.listBoxListeProduit.Items.Add(item["produit_label"]);
                }

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

        }

        private void listBoxListeProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow dr = dts.Tables["produits"].Rows[listBoxListeProduit.SelectedIndex];

            this.textBoxCodeProduit.Text = dr.Field<int>("produit_id").ToString();
            this.textBoxLibelleProduit.Text = dr.Field<string>("produit_label");
            this.textBoxStockAlerteProduit.Text = dr.Field<int>("produit_stock_critique").ToString();
            this.textBoxStockPhysiqueProduit.Text = dr.Field<int>("produit_stock_reel").ToString();
            this.textBoxQuantiteAnnuelleProduit.Text = dr.Field<int>("produit_qt_annuel").ToString();
            this.textBoxUniteMesureProduit.Text = dr.Field<string>("produit_mesure");


        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
