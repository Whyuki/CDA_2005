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
    public partial class FormConnexion : Form
    {
        private SqlConnection sqlConnect;
        public FormConnexion()
        {
            InitializeComponent();
        }
        private void FormConnexion_Load(object sender, EventArgs e)
        {
            sqlConnect = new SqlConnection();
            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["papyrusConnectionString"];
            if (oConfig != null)
            {
                sqlConnect.ConnectionString = oConfig.ConnectionString;
                textBoxServeur.Text = sqlConnect.DataSource;
                textBoxBdd.Text = sqlConnect.Database;
            }
        }
        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                richTextBoxMessageErreurConnexion.Visible = false;
                richTextBoxMessageErreurConnexion.Clear();
                buttonConnexion.Enabled = false;
                buttonDeconnexion.Enabled = true;
            }
            catch (SqlException se)
            {
                richTextBoxMessageErreurConnexion.Visible = true;
                for (int i = 0; i < se.Errors.Count; i++)
                {
                    richTextBoxMessageErreurConnexion.Text += "ERROR#" + i + "\n" +
                        "Message: " + se.Errors[i].Message + "\n" +
                        "Error Code: " + se.ErrorCode + "\n" +
                        "Error Number: " + se.Errors[i].Number + "\n";
                }
            }
            labelOpenClosed.Text = sqlConnect.State.ToString();

        }



        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            sqlConnect.Close();
            labelOpenClosed.Text = sqlConnect.State.ToString();
            buttonConnexion.Enabled = true;
            buttonDeconnexion.Enabled = false;

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaisieConnexion()
        {
            string dataSource = textBoxServeur.Text;
            string dataBase = textBoxBdd.Text;
            if (dataSource.Length > 0 && dataBase.Length > 0)
            {
                sqlConnect = new SqlConnection();

                sqlConnect.ConnectionString = "Data Source = " + dataSource + "; Initial Catalog = " + dataBase + "; Integrated Security = True";
                textBoxServeur.Text = sqlConnect.DataSource;
                textBoxBdd.Text = sqlConnect.Database;
            }

        }

        private void textBoxServeur_TextChanged(object sender, EventArgs e)
        {
            this.SaisieConnexion();
        }

        private void textBoxBdd_TextChanged(object sender, EventArgs e)
        {
            this.SaisieConnexion();

        }
    }
}
