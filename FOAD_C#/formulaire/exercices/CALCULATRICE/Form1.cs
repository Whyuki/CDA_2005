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

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button0_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Text += "0+";
            this.somme += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Text += "1+";
            this.somme += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Text += "2+";
            this.somme += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Text += "3+";
            this.somme += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Text += "4+";
            this.somme += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Text += "5+";
            this.somme += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Text += "6+";
            this.somme += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Text += "7+";
            this.somme += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Text += "8+";
            this.somme += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBoxAffichageCalcul.Text += "9+";
            this.somme += 9;
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
    }
}
