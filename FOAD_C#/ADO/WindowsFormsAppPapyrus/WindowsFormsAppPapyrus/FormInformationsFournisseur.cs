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
    public partial class FormInformationsFournisseur : Form
    {

       
        public FormInformationsFournisseur(string nom, string adresse, string cp, string ville, string contact, byte satisfaction)
        {
            InitializeComponent();
            textBoxNomFournisseur.Text = nom;
            textBoxAdresseFournisseur.Text = adresse;
            textBoxCpFournisseur.Text = cp;
            textBoxVilleFournisseur.Text = ville;
            textBoxContactFournisseur.Text = contact;
            textBoxSatisfactionFournisseur.Text = satisfaction.ToString();
            this.AcceptButton = buttonRetour;
            this.CancelButton = buttonRetour;

        }


        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
