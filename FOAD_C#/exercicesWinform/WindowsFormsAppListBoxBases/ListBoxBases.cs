using ClassLibraryToolsVerifications;
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

namespace WindowsFormsAppListBoxBases
{
    public partial class ListBoxBases : Form
    {

        private static int compteurInstance;
        public ListBoxBases()
        {
            InitializeComponent();

            compteurInstance++;
            this.Text += " n° " + compteurInstance.ToString();
        }

        /// <summary>
        /// Ajoute un élément à la listBox s'il répond au format attendu et qu'il n'y apparait pas déjà 
        /// </summary>
        private void AjoutListe()
        {
            // v1 methode defensive : return;
            /*
            textBoxNouvelElement.Focus();

            if (IsAlreadyInTheList(textBoxNouvelElement.Text, listBoxLstListe))
            {
                errorProviderAjoutListe.SetError(textBoxNouvelElement, "Cet element existe deja dans la liste !");
                return;
            }

            if (ClassVerifications.ValidNom(textBoxNouvelElement.Text))
            {
                listBoxLstListe.Items.Add(textBoxNouvelElement.Text);
                textBoxNouvelElement.Clear();
                errorProviderAjoutListe.Clear();
                buttonViderListe.Enabled = true;
            }

            textBoxItemsCount.Text = listBoxLstListe.Items.Count.ToString(); */

            // v2 methode sans return;     
            textBoxNouvelElement.Focus();

            if (ClassVerifications.ValidNom(textBoxNouvelElement.Text))
            {
                if (IsAlreadyInTheList(textBoxNouvelElement.Text, listBoxLstListe))
                {
                    errorProviderAjoutListe.SetError(textBoxNouvelElement, "Cet element existe deja dans la liste !");
                }
                else
                {
                    listBoxLstListe.Items.Add(textBoxNouvelElement.Text);
                    textBoxNouvelElement.Clear();
                    errorProviderAjoutListe.Clear();
                    buttonViderListe.Enabled = true;
                    buttonAjoutListe.Enabled = false;
                }
            }
            textBoxItemsCount.Text = listBoxLstListe.Items.Count.ToString();
        }


        /// <summary>
        /// Indique si la string est déjà contenue dans la listBox
        /// </summary>
        /// <param name="_str"></param>
        /// <returns>true si présente, false si absente</returns>
        private bool IsAlreadyInTheList(string _str, ListBox _listBox)
        {
            return _listBox.FindStringExact(_str) >= 0;
        }

        /// <summary>
        /// Indique si l'index a le bon format et s'il existe dans la listBox
        /// </summary>
        /// <param name="_index"></param>
        /// <returns>true si format valide et index existant / false si format invalide ou index inexistant</returns>
        private bool IndexIsOk(string _index, ListBox _listBox)
        {
            string regexIndex = "^[1-9]*[0-9]*$";

            bool isok = int.TryParse(_index, out int result)
                & result < _listBox.Items.Count
                & result >= 0
                & Regex.IsMatch(_index, regexIndex);

            return isok;
        }

        //----------------------------------------------------------------------------------- events

        /// <summary>
        /// Active ou Desactive le bouton Ajout Liste si l'element repond au format attendu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNouvelElement_TextChanged(object sender, EventArgs e)
        {
            errorProviderIndex.Clear();
            textBoxIndexElement.Clear();

            if (ClassVerifications.ValidNom(textBoxNouvelElement.Text))
            {
                buttonAjoutListe.Enabled = true;
                errorProviderAjoutListe.Clear();
            }
            else if (textBoxNouvelElement.TextLength == 0)
            {
                errorProviderAjoutListe.Clear();
            }
            else
            {
                errorProviderAjoutListe.SetError(textBoxNouvelElement, "Ne peut contenir que des lettres : deux au minimum !");
                buttonAjoutListe.Enabled = false;
            }
        }


        /// <summary>
        /// Ajoute un élément à la listBox s'il répond au format attendu et qu'il n'y apparait pas déjà (au pressage du bouton Ajout Liste)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjoutListe_Click(object sender, EventArgs e)
        {
            this.AjoutListe();
        }


        /// <summary>
        /// Active ou desactive le bouton Selectionner si l'index repond au format et existe dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxIndexElement_TextChanged(object sender, EventArgs e)
        {
            buttonSelectionner.Enabled = false;

            if (IndexIsOk(textBoxIndexElement.Text, listBoxLstListe))
            {
                buttonSelectionner.Enabled = true;
            }
            else if (textBoxIndexElement.TextLength == 0)
            {
                errorProviderIndex.Clear();
            }
            else
            {
                errorProviderIndex.SetError(textBoxIndexElement, "Aucun élément ne correspond à cet index");
            }
        }

        /// <summary>
        /// Affiche les informations de l'element selectionné (index et text) dans les textBoxes prevues à cet effet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLstListe.SelectedIndex == -1)
            {
                listBoxLstListe.ClearSelected();
            }
            else
            {
                textBoxSelectedIndex.Text = listBoxLstListe.SelectedIndex.ToString();
                textBoxSelectedText.Text = listBoxLstListe.SelectedItem.ToString();
            }
        }

        /// <summary>
        /// Selectionne l'element à l'index demandé (au pressage du bouton Selectionner)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            listBoxLstListe.SetSelected(int.Parse(textBoxIndexElement.Text), true);
        }

        /// <summary>
        /// Vide la listBox, réinitialise toutes les textBoxes (et erreurs liées) et désactive tous les boutons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonViderListe_Click(object sender, EventArgs e)
        {
            listBoxLstListe.Items.Clear();

            textBoxItemsCount.Clear();
            textBoxIndexElement.Clear();
            textBoxSelectedIndex.Clear();
            textBoxSelectedText.Clear();
            textBoxNouvelElement.Clear();

            buttonViderListe.Enabled = false;
        }

        //------- bonus : touche enter pour ajout liste et selectionner


        /// <summary>
        /// Ajoute un élément à la listBox s'il répond au format attendu et qu'il n'y apparait pas déjà (à l'appui de la touche ENTRER)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNouvelElement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.AjoutListe();
            }
        }

        /// <summary>
        /// Selectionne l'element à l'index demandé (à l'appui de la toucher ENTER)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxIndexElement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (buttonSelectionner.Enabled & e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                listBoxLstListe.SetSelected(int.Parse(textBoxIndexElement.Text), true);
            }

        }
    }
}
