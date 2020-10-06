using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATRICE
{
    public partial class Calculatrice : Form
    {
        private int somme = 0;

        public Calculatrice()
        {
            InitializeComponent();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button buttonNumber = (Button)sender;
            int buttonValue = Int32.Parse(buttonNumber.Text);
            this.textBoxAffichageCalcul.Text += buttonValue + "+";
            this.somme += buttonValue ;
        }

        private void vider_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Clear();
            this.somme = 0;
        }

        private void calculer_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Text += "=" + this.somme.ToString() + "+";

        }

        private void Calculatrice_Load(object sender, EventArgs e)
        {

        }
    }
}
