using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppToutEmbal
{
    public partial class FormAjouterProductionToutEmbal : Form
    {
        public delegate void DelegateAjouterProduction(string nom, int nbAProduire, int nbAProdParHeure, Form formSender);
        public event DelegateAjouterProduction AjouterProduction;

        public FormAjouterProductionToutEmbal()
        {
            InitializeComponent();
            this.AcceptButton = buttonAjouter;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            bool nbAproduireOK = Int32.TryParse(textBoxNbAProduire.Text, out int nbAproduire);
            bool nbAproduireParHeureOK = Int32.TryParse(textBoxNbAProduireParHeure.Text, out int nbAproduireParHeure);
            if (textBoxNom.TextLength > 0 && nbAproduireOK && nbAproduireParHeureOK && nbAproduire > 0 && nbAproduireParHeure > 0)
            {
                AjouterProduction(textBoxNom.Text, nbAproduire, Convert.ToInt32(textBoxNbAProduireParHeure.Text), this);
                textBoxNom.Focus();
            }
            else
            {
                if (!nbAproduireParHeureOK || nbAproduireParHeure <= 0)
                {
                    errorProviderAjout.SetError(textBoxNbAProduireParHeure, "Saisie incorrecte :\nVeuillez saisir un nombre positif");
                    textBoxNbAProduireParHeure.Focus();
                }
                if (!nbAproduireOK || nbAproduire <= 0)
                {
                    errorProviderAjout.SetError(textBoxNbAProduire, "Saisie incorrecte :\nVeuillez saisir un nombre positif");
                    textBoxNbAProduire.Focus();
                }
                if (textBoxNom.TextLength == 0)
                {
                    errorProviderAjout.SetError(textBoxNom, "Champ manquant :\nVeuillez saisir un nom de production");
                    textBoxNom.Focus();
                }

            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            errorProviderAjout.Clear();
        }

        private void textBoxNbAProduire_TextChanged(object sender, EventArgs e)
        {
            errorProviderAjout.Clear();

        }

        private void textBoxNbAProduireParHeure_TextChanged(object sender, EventArgs e)
        {
            errorProviderAjout.Clear();

        }
    }
}
