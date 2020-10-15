using ClassLibraryFacture;
using ClassLibraryToolsVerifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlesSaisie
{
    public partial class Controles : Form
    {
        public Controles()
        {
            InitializeComponent();
        }


        /// <summary>
        /// button "effacer" clear text boxes and error icones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void effacer_Click(object sender, EventArgs e)
        {
            textNom.Clear();
            textMontant.Clear();
            textDate.Clear();
            textCP.Clear();

            controlErrorProvider.Clear();
        }


        /// <summary>
        /// button "Valider" disabled if a text box is empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textNom.Text.Length > 0 & textDate.Text.Length > 0 & textMontant.Text.Length > 0 & textCP.Text.Length > 0)
            {
                valider.Enabled = true;
            }
            else
            {
                valider.Enabled = false;
            }
        }



        /// <summary>
        /// click button "Valider" check format and show messageBox with inputs
        /// and alerts the user of an input error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void valider_Click(object sender, EventArgs e)
        {

            // get input
            string nom = textNom.Text;
            string date = textDate.Text;
            string montant = textMontant.Text;
            string cp = textCP.Text;

            // check format input
            bool nomIsOk = ClassVerifications.ValidNom(nom);
            bool dateIsOk = ClassVerifications.ValidDate(date);
            bool montantIsOk = ClassVerifications.ValidMontant(montant);
            bool cpIsOk = ClassVerifications.ValidCP(cp);


            // output confirmation
            string validOut = "Nom :  " + nom + "\nDate :   " + date + "\nMontant :   " + montant.ToString() + "\nCP :   " + cp.ToString();

            // reset error alert
            controlErrorProvider.Clear();


            // alerts the user of an input error
            if (!cpIsOk)
            {
                if (textCP.TextLength < 1)
                {
                    controlErrorProvider.SetError(textCP, "Champ obligatoire");
                }
                else
                {
                    controlErrorProvider.SetError(textCP, "Code postal invalide");
                    SystemSounds.Exclamation.Play();
                }
            }
            if (!montantIsOk)
            {
                if (textMontant.TextLength < 1)
                {
                    controlErrorProvider.SetError(textMontant, "Champ obligatoire");
                }
                else
                {
                    controlErrorProvider.SetError(textMontant, "Montant invalide");
                    SystemSounds.Exclamation.Play();
                }
            }
            if (!dateIsOk)
            {
                if (textDate.TextLength < 1)
                {
                    controlErrorProvider.SetError(textDate, "Champ obligatoire");
                }
                else
                {
                    controlErrorProvider.SetError(textDate, "Format de date invalide");
                    SystemSounds.Exclamation.Play();
                }
            }
            else if (DateTime.Parse(textDate.Text) <= DateTime.Now)
            {
                dateIsOk = false;
                controlErrorProvider.SetError(textDate, "La date doit être postérieure à aujourd'hui ");
                SystemSounds.Exclamation.Play();
            }



            if (!nomIsOk)
            {
                if (textNom.TextLength < 1)
                {
                    controlErrorProvider.SetError(textNom, "Champ obligatoire");
                }
                else
                {
                    controlErrorProvider.SetError(textNom, "Nom au format invalide");
                    SystemSounds.Exclamation.Play();
                }
            }


            // if everything is ok
            if (nomIsOk & montantIsOk & dateIsOk & cpIsOk)
            {
                MessageBox.Show(validOut, "Validation éffectuée");
                new Facture(nom, DateTime.Parse(date), float.Parse(montant), cp);
            }

        }


        /// <summary>
        /// Asks the user to confirm closing the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void controle_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
            ("Fin de l’application", "FIN",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }
    }
}
