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

        private void buttonValider_Click(object sender, EventArgs e)
        {
            TexteSaisi(textBoxVotreTexte.Text, this);
        }
    }
}
