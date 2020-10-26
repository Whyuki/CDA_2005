using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryToolsVerifications;

namespace WindowsFormsAppListBoxAndComboBox
{
    public partial class FormListBoxComboBox : Form
    {
        public FormListBoxComboBox()
        {
            InitializeComponent();
            comboBoxSource.Items.Add("France");
            comboBoxSource.Items.Add("Belgique");
            comboBoxSource.Items.Add("Allemagne");
            comboBoxSource.Items.Add("Japon");
            comboBoxSource.Items.Add("Portugal");
            comboBoxSource.Items.Add("Grece");
            comboBoxSource.Items.Add("Bulgarie");
            comboBoxSource.Items.Add("Espagne");
        }


        /// <summary>
        /// Indique si la string est déjà contenue dans la listBox
        /// </summary>
        /// <param name="_str"></param>
        /// <returns>true si présente, false si absente</returns>
        private bool IsAlreadyInTheListBox(string _str, ListBox _listBox)
        {
            return _listBox.FindStringExact(_str) >= 0;
        }

        private bool IsAlreadyInTheComboBox(string _str, ComboBox _comboBox)
        {
            return _comboBox.FindStringExact(_str) >= 0;
        }

        /// <summary>
        /// Vérifie si la comboBox contient des éléments : si vide désactive le bouton tout déplacer
        /// </summary>
        public void ComboBoxToutEstDeplacable()
        {
            if (comboBoxSource.Items.Count == 0)
            {
                buttonAllToCible.Enabled = false;
                buttonSelectionToCible.Enabled = false;
            }
            else
            {
                buttonAllToCible.Enabled = true;
            }
        }

        /// <summary>
        /// Vérifie si la listBox contient des éléments : si vide désactive le bouton tout déplacer
        /// </summary>
        public void ListBoxToutEstDeplacable()
        {
            if (listBoxCible.Items.Count == 0)
            {
                buttonAllToSource.Enabled = false;
                buttonSelectionToSource.Enabled = false;
            }
            else
            {
                buttonAllToSource.Enabled = true;
            }
        }

        /// <summary>
        /// Active le bouton deplacer vers cible si un élément de la comboBox est séléctionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSource.SelectedIndex >= 0)
            {
                buttonSelectionToCible.Enabled = true;
            }
            errorProviderTextComboBox.Clear();
        }

        /// <summary>
        /// Active le bouton deplacer vers cible si l'utilisateur saisi du texte dans la comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSource_TextUpdate(object sender, EventArgs e)
        {
            errorProviderTextComboBox.Clear();
            if (comboBoxSource.Text != "")
            {
                buttonSelectionToCible.Enabled = true;
            }
            else
            {
                buttonSelectionToCible.Enabled = false;
            }
        }

        /// <summary>
        /// déplace l'élément source sélectionné ou ajoute le texte saisi dans la liste cible s'il n'existe pas déjà dans l'une des deux listes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSectionToCible_Click(object sender, EventArgs e)
        {
            buttonSelectionToCible.Enabled = false;

            if (IsAlreadyInTheListBox(comboBoxSource.Text, listBoxCible))
            {
                errorProviderTextComboBox.SetError(comboBoxSource, "Ajout impossible : cet élément est déjà présent dans une des deux listes");
            }
            else if (IsAlreadyInTheComboBox(comboBoxSource.Text, comboBoxSource))
            { // user firendly : selectionne l'élément saisi par l'utilisateur pour le déplacer dirrectement
                int indexElemSaisi = comboBoxSource.FindStringExact(comboBoxSource.Text);
                comboBoxSource.SelectedIndex = indexElemSaisi;
            }
            else
            {
                if (ClassVerifications.ValidPays(comboBoxSource.Text))
                {
                    listBoxCible.Items.Add(comboBoxSource.Text);
                    errorProviderTextComboBox.Clear();
                    comboBoxSource.ResetText();
                    listBoxCible.SetSelected(listBoxCible.Items.Count - 1, true);
                }
                else
                {
                    errorProviderTextComboBox.SetError(comboBoxSource, "Ajout impossible : Format invalide \nFormat attendu : lettres, espaces et tirets uniquement \nExemple :  Saint-Vincent-et-les Grenadines ");
                }

            }

            if (comboBoxSource.SelectedIndex >= 0)
            {
                listBoxCible.Items.Add(comboBoxSource.SelectedItem);
                comboBoxSource.Items.Remove(comboBoxSource.SelectedItem);
                listBoxCible.SetSelected(listBoxCible.Items.Count - 1, true);
            }

            this.ComboBoxToutEstDeplacable();
            this.ListBoxToutEstDeplacable();

        }

        /// <summary>
        /// déplace tous les éléments de la comboBox source vers la listBox cible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAllToCible_Click(object sender, EventArgs e)
        {
            foreach (string s in comboBoxSource.Items)
            {
                listBoxCible.Items.Add(s);
            }
            comboBoxSource.Items.Clear();
            this.ComboBoxToutEstDeplacable();
            this.ListBoxToutEstDeplacable();

            errorProviderTextComboBox.Clear();
            comboBoxSource.ResetText();
        }

        /// <summary>
        /// Active/desactive les boutons monter/descendre en f° de l'élement séléctionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCible.SelectedIndex >= 0)
            {
                buttonSelectionToSource.Enabled = true;

                buttonUp.Enabled = true;
                buttonDown.Enabled = true;

                if (listBoxCible.SelectedIndex == 0)
                {
                    buttonUp.Enabled = false;
                }
                if (listBoxCible.SelectedIndex == listBoxCible.Items.Count - 1)
                {
                    buttonDown.Enabled = false;
                }
            }
            else
            {
                buttonUp.Enabled = false;
                buttonDown.Enabled = false;
            }

            this.ListBoxToutEstDeplacable();

            errorProviderTextComboBox.Clear();
            comboBoxSource.ResetText();
        }

        /// <summary>
        /// déplace l'élément séléctionné de la listBox cible vers la comboBox source
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectionToSource_Click(object sender, EventArgs e)
        {
            buttonSelectionToSource.Enabled = false;

            int indexTemp = listBoxCible.SelectedIndex;
            comboBoxSource.Items.Add(listBoxCible.SelectedItem);
            listBoxCible.Items.Remove(listBoxCible.SelectedItem);

            if (indexTemp >= 0 && listBoxCible.Items.Count > 0)
            {
                if (indexTemp < listBoxCible.Items.Count)
                {
                    listBoxCible.SetSelected(indexTemp, true);
                }
                else
                {
                    listBoxCible.SetSelected(indexTemp - 1, true);
                }
            }

            buttonSelectionToSource.Focus();
            this.ComboBoxToutEstDeplacable();
            this.ListBoxToutEstDeplacable();

        }

        /// <summary>
        /// déplace tous les éléments de la listBox cible vers la comboBox source
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAllToSource_Click(object sender, EventArgs e)
        {
            foreach (string s in listBoxCible.Items)
            {
                comboBoxSource.Items.Add(s);
            }

            listBoxCible.Items.Clear();
            buttonDown.Enabled = false;
            buttonUp.Enabled = false;
            this.ComboBoxToutEstDeplacable();
            this.ListBoxToutEstDeplacable();

            errorProviderTextComboBox.Clear();
            comboBoxSource.ResetText();
        }

        /// <summary>
        /// déplace l'élément séléctionné vers le haut de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUp_Click(object sender, EventArgs e)
        {
            int indexTemp = listBoxCible.SelectedIndex;
            string sTemp = listBoxCible.SelectedItem.ToString();
            if (indexTemp > 0)
            {
                listBoxCible.Items.RemoveAt(indexTemp);

                listBoxCible.Items.Insert(indexTemp - 1, sTemp);
                listBoxCible.SetSelected(indexTemp - 1, true);
            }

            errorProviderTextComboBox.Clear();
            comboBoxSource.ResetText();
        }

        /// <summary>
        /// déplace l'élément séléctionné vers le bas de la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDown_Click(object sender, EventArgs e)
        {
            int indexTemp = listBoxCible.SelectedIndex;
            string sTemp = listBoxCible.SelectedItem.ToString();
            if (indexTemp >= 0)
            {
                listBoxCible.Items.RemoveAt(indexTemp);

                listBoxCible.Items.Insert(indexTemp + 1, sTemp);
                listBoxCible.SetSelected(indexTemp + 1, true);
            }

            errorProviderTextComboBox.Clear();
            comboBoxSource.ResetText();
        }
    }
}
