using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        /// event effacer_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void effacer_Click(object sender, EventArgs e)
        {
            textBoxNom.Clear();
            textBoxMontant.Clear();
            textBoxDate.Clear();
            textBoxCP.Clear();
        }

        /// <summary>
        /// event textBox_TextChanged
        /// if all fields aren't empty enable button "Valider", else disable it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNom.Text.Length > 0 & textBoxDate.Text.Length > 0 & textBoxMontant.Text.Length > 0 & textBoxCP.Text.Length > 0)
            {
                valider.Enabled = true;
            }
            else
            {
                valider.Enabled = false;
            }
        }

        /// <summary>
        /// event valider_Click
        /// get input, check regex, if regex ok : parse date and check i'ts > now, if true : init & show validation form with inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void valider_Click(object sender, EventArgs e)
        {
            // get input
            string nom = textBoxNom.Text;
            string date = textBoxDate.Text;
            string montant = textBoxMontant.Text;
            string cp = textBoxCP.Text;

            // check regex
            bool nomIsOk = Regex.IsMatch(textBoxNom.Text, @"^[A-Za-z]+$");
            bool montantIsOk = Regex.IsMatch(textBoxMontant.Text, @"^[0-9]*.?[0-9][^-]*$");
            bool dateIsOk = Regex.IsMatch(textBoxDate.Text, @"^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)\d{4}$");
            bool cpIsOk = Regex.IsMatch(textBoxCP.Text, @"^[0-9]{5}$");

            // if regex ok
            if (nomIsOk & cpIsOk & montantIsOk & dateIsOk)
            {   
                //parse date
                var parseDate = DateTime.Parse(textBoxDate.Text);
                // if date > now
                if (parseDate > DateTime.Now)
                {
                // init & show validation form with inputs
                Validation validation = new Validation(nom, date, montant, cp);
                validation.Show();
                }
            }
          
        }
    }
}
