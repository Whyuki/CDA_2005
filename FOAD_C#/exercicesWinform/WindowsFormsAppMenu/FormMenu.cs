using CALCULATRICE;
using controlesSaisie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            menuStripMain.MdiWindowListItem = toolStripMenuItemFenetres;
            toolStripStatusLabelDate.Text = DateTime.Now.ToString();
            timerDate.Start();
            
        }

        private void Identification_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelDerniereOperation.Text = "S'identifier";
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (formLogin.LoginIsOk)
            {
                toolStripMenuItemPhase1.Enabled = true;
                toolStripMenuItemPhase2.Enabled = true;
                toolStripMenuItemPhase3.Enabled = true;
                toolStripSplitButtonPhase3.Enabled = true;
                toolStripMenuItemFenetres.Enabled = true;
                toolStripMenuItemIdentification.Enabled = false;
                toolStripButtonIdentification.Enabled = false;
            }
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

        private void Cases_Click()
        {
            toolStripStatusLabelDerniereOperation.Text = "Cases";

            FormSaisie formSaisie = new FormSaisie();
            formSaisie.MdiParent = this;
            formSaisie.TexteSaisi += FormSaisie_TexteSaisi;
            formSaisie.Show();

        }

        private void toolStripMenuItemCases_Click(object sender, EventArgs e)
        {
            this.Cases_Click();
        }
        private void toolStripOutilsMenuItemCases_Click(object sender, EventArgs e)
        {
            this.Cases_Click();
        }


        private void FormSaisie_TexteSaisi(string texte, FormSaisie saisieSender)
        {
            saisieSender.Close();
            checkBoxAndRadioButton formck = new checkBoxAndRadioButton(texte);
            formck.MdiParent = this;
            formck.Show();
        }

        private void ListBoxOpening()
        {
            toolStripStatusLabelDerniereOperation.Text = "ListBox";
            ListBoxBases formListBoxBases = new ListBoxBases();
            formListBoxBases.MdiParent = this;
            formListBoxBases.Show();
        }

        private void toolStripMenuItemListBox_Click(object sender, EventArgs e)
        {
            this.ListBoxOpening();

        }

        private void toolStripOutilsMenuItemListBox_Click(object sender, EventArgs e)
        {
            this.ListBoxOpening();
        }

        private void ComboBoxOpening()
        {
            toolStripStatusLabelDerniereOperation.Text = "ComboBox";
            FormListBoxComboBox formListBoxComboBox = new FormListBoxComboBox();
            formListBoxComboBox.MdiParent = this;
            formListBoxComboBox.Show();
        }

        private void toolStripMenuItemComboBox_Click(object sender, EventArgs e)
        {
            this.ComboBoxOpening();
        }

        private void toolStripOutilsMenuItemComboBox_Click(object sender, EventArgs e)
        {
            this.ComboBoxOpening();
        }

        private void DefilementOpening()
        {
            toolStripStatusLabelDerniereOperation.Text = "Defilement";
            Defilement formDefilement = new Defilement();
            formDefilement.MdiParent = this;
            formDefilement.Show();
        }

        private void toolStripMenuItemDefilement_Click(object sender, EventArgs e)
        {
            this.DefilementOpening();
        }

        private void toolStripOutilsMenuItemDefilement_Click(object sender, EventArgs e)
        {
            this.DefilementOpening();
        }

        private void EmpruntOpening()
        {
            toolStripStatusLabelDerniereOperation.Text = "Emprunt";
            FormEmprunt formEmprunt = new FormEmprunt();
            formEmprunt.MdiParent = this;
            formEmprunt.Show();
        }

        private void toolStripMenuItemEmprunt_Click(object sender, EventArgs e)
        {
            this.EmpruntOpening();
        }

        private void toolStripOutilsMenuItemEmprunt_Click(object sender, EventArgs e)
        {
            this.EmpruntOpening();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show
           ("Fin de l’application", "Quitter",
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

        private void toolStripMenuItemQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDate.Text = DateTime.Now.ToString();
        }

        private void toolStripSplitButtonPhase3_ButtonClick(object sender, EventArgs e)
        {
            toolStripSplitButtonPhase3.ShowDropDown();
        }
    }
}
