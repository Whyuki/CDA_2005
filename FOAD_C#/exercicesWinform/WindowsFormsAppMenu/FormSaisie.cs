using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMenu
{
    public partial class FormSaisie : Form
    {
        private static int compteurInstance;

        public delegate void DelegateSaisie(string texte, FormSaisie saisieSender);
        public event DelegateSaisie TexteSaisi;

        public FormSaisie()
        {
            InitializeComponent();
            compteurInstance++;
            this.Text += " n° " + compteurInstance.ToString();
        }

        private void ValiderSaisie()
        {
            if (textBoxVotreTexte.Text.Length > 0)
            {
                TexteSaisi(textBoxVotreTexte.Text, this);
            }
            else
            {
                errorProviderSaisie.SetError(buttonValider, "Veuillez saisir un texte");
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            this.ValiderSaisie();
        }

        private void textBoxVotreTexte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.ValiderSaisie();
            }
        }

        private void textBoxVotreTexte_TextChanged(object sender, EventArgs e)
        {
            errorProviderSaisie.Clear();
        }
    }
}
