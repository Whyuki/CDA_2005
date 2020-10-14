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
        /// reset error alert
        /// </summary>
        private void clearError()
        {
            controlErrorProvider.SetError(textNom, null);
            controlErrorProvider.SetError(textDate, null);
            controlErrorProvider.SetError(textMontant, null);
            controlErrorProvider.SetError(textCP, null);
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

            this.clearError();
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
        /// check nom format
        /// </summary>
        /// <returns></returns>
        private bool ValidNom()
        {
            return Regex.IsMatch(textNom.Text, @"^[A-Za-z]+$");
        }

        /// <summary>
        /// check date format JJ/MM/AAAA
        /// </summary>
        /// <returns></returns>
        private bool ValidDate()
        {
            return Regex.IsMatch(textDate.Text, @"^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)\d{4}$");

        }

        /// <summary>
        /// check montant format
        /// </summary>
        /// <returns></returns>
        private bool ValidMontant()
        {
            return Regex.IsMatch(textMontant.Text, @"^[0-9]*.?[0-9][^-]*$");
        }

        /// <summary>
        /// check postal code format
        /// </summary>
        /// <returns></returns>
        private bool ValidCp()
        {
            return Regex.IsMatch(textCP.Text, @"^[0-9]{5}$");
        }


        /// <summary>
        /// click button "Valider" check format and show messageBox with inputs
        /// alerts the user of an input error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void valider_Click(object sender, EventArgs e)
        {

            // check format input
            bool nomIsOk = this.ValidNom();
            bool dateIsOk = this.ValidDate();
            bool montantIsOk = this.ValidMontant();
            bool cpIsOk = this.ValidCp();

            // get input
            string nom = textNom.Text;
            string date = textDate.Text;
            string montant = textMontant.Text;
            string cp = textCP.Text;

            // output confirmation
            string validOut = "Nom :  " + nom + "\nDate :   " + date + "\nMontant :   " + montant.ToString() + "\nCP :   " + cp.ToString();

            // reset error alert
            this.clearError();


            // alerts the user of an input error
            if (!cpIsOk)
            {
                textCP.Focus();
                controlErrorProvider.SetError(textCP, "Code postal invalide");
                SystemSounds.Exclamation.Play();
            }
            if (!montantIsOk)
            {
                textMontant.Focus();
                controlErrorProvider.SetError(textMontant, "Montant invalide");
                SystemSounds.Exclamation.Play();
            }
            if (!dateIsOk)
            {
                textDate.Focus();
                controlErrorProvider.SetError(textDate, "Date au format invalide");
                SystemSounds.Exclamation.Play();
            }
            else if (DateTime.Parse(textDate.Text) <= DateTime.Now)
            {
                dateIsOk = false;
                textDate.Focus();
                controlErrorProvider.SetError(textDate, "Date au format invalide : doit être postérieure à aujourd'hui ");
                SystemSounds.Exclamation.Play();
            }
            if (!nomIsOk)
            {
                textNom.Focus();
                controlErrorProvider.SetError(textNom, "Nom au format invalide");
                SystemSounds.Exclamation.Play();
            }


            // if everything is ok
            if (nomIsOk & montantIsOk & dateIsOk & cpIsOk)
            {
                MessageBox.Show(validOut, "Validation éffectuée");
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
