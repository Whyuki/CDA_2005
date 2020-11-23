using CALCULATRICE;
using controlesSaisie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppCheckBoxRadioButton;
using WindowsFormsAppDefilement;
using WindowsFormsAppEmprunt;
using WindowsFormsAppListBoxAndComboBox;
using WindowsFormsAppListBoxBases;

namespace WindowsFormsAppMenu
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            toolStripStatusLabelDate.Text = DateTime.Now.ToString("d");
        }

        private void Identification_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelDerniereOperation.Text = "S'identifier";
            MessageBox.Show("Bienvenue :)");
            toolStripMenuItemPhase1.Enabled = true;
            toolStripMenuItemPhase2.Enabled = true;
            toolStripMenuItemPhase3.Enabled = true;
            toolStripMenuItemFenetres.Enabled = true;
        }

        private void toolStripMenuItemAdditionneur_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelDerniereOperation.Text = "Additionneur";
            Calculatrice formCalculatrice = new Calculatrice();
            formCalculatrice.MdiParent = this;
            formCalculatrice.Show();
        }

        private void toolStripMenuItemControles_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelDerniereOperation.Text = "Controles de saisie";
            Controles formControles = new Controles();
            formControles.MdiParent = this;
            formControles.Show();
        }

        private void toolStripMenuItemCases_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelDerniereOperation.Text = "Cases";
          
            FormSaisie formSaisie = new FormSaisie();
            formSaisie.MdiParent = this;
            formSaisie.TexteSaisi += FormSaisie_TexteSaisi;
            formSaisie.Show();

        }

        private void FormSaisie_TexteSaisi(string texte, FormSaisie saisieSender)
        {
            saisieSender.Close();
            checkBoxAndRadioButton formck = new checkBoxAndRadioButton(texte);
            formck.MdiParent = this;
            formck.Show();
        }

        private void toolStripMenuItemListBox_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelDerniereOperation.Text = "ListBox";
            ListBoxBases formListBoxBases = new ListBoxBases();
            formListBoxBases.MdiParent = this;
            formListBoxBases.Show();

        }

        private void toolStripMenuItemComboBox_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelDerniereOperation.Text = "ComboBox";
            FormListBoxComboBox formListBoxComboBox = new FormListBoxComboBox();
            formListBoxComboBox.MdiParent = this;
            formListBoxComboBox.Show();
        }

        private void toolStripMenuItemDefilement_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelDerniereOperation.Text = "Defilement";
            Defilement formDefilement = new Defilement();
            formDefilement.MdiParent = this;
            formDefilement.Show();
        }

        private void toolStripMenuItemEmprunt_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelDerniereOperation.Text = "Emprunt";
            FormEmprunt formEmprunt = new FormEmprunt();
            formEmprunt.MdiParent = this;
            formEmprunt.Show();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
           ("Fin de l’application", "FIN",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void toolStripMenuItemCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItemHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void toolStripMenuItemVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }
    }
}
