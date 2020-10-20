using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsAppCheckBoxRadioButton
{
    public partial class checkBoxAndRadioButton : Form
    {
        public checkBoxAndRadioButton()
        {
            InitializeComponent();
        }



        /// <summary>
        /// désactive tous les boutons radio d'une groupBox
        /// </summary>
        /// <param name="_groupBox"></param>
        private void Clear_RadioButton(GroupBox _groupBox)
        {
            foreach (RadioButton radio in _groupBox.Controls.OfType<RadioButton>().ToList())
            {
                radio.Checked = false;
            }
        }

        /// <summary>
        /// décoche tous les checkBox de la groupBox Choix
        /// </summary>
        private void Choix_reset()
        {
            checkBoxCouleurFond.Checked = false;
            checkBoxCouleurCaracteres.Checked = false;
            checkBoxCasse.Checked = false;

        }

        /// <summary>
        /// Rend invisible tous les options
        /// </summary>
        private void Hide_Fond_Cara_Casse()
        {
            groupBoxFond.Visible = false;
            groupBoxCaracteres.Visible = false;
            groupBoxCasse.Visible = false;
        }

        /// <summary>
        /// Reinitialise le format du texte
        /// </summary>
        private void Format_Reset()
        {
            labelTextModifie.BackColor = SystemColors.Control;
            labelTextModifie.ForeColor = SystemColors.ControlText;

        }


        //-------------------------------------------------------------------------------- events


        /// <summary>
        /// Lorsque le texte est modifié : active les choix si champs non vide
        /// retranscrit le texte dans le label (texte modifié)
        /// si champs vide : désactive les choix et cache les options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxVotreTexte_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonCasseMajuscules.Checked)
            {
                labelTextModifie.Text = textBox_votreTexte.Text.ToUpper();
            }
            else if (radioButtonCasseMinuscules.Checked)
            {
                labelTextModifie.Text = textBox_votreTexte.Text.ToLower();
            }
            else
            {
                labelTextModifie.Text = textBox_votreTexte.Text;
            }

            if (textBox_votreTexte.TextLength > 0)
            {
                groupBoxChoix.Enabled = true;
            }
            else
            {
                groupBoxChoix.Enabled = false;
                this.Choix_reset();
                this.Hide_Fond_Cara_Casse();
                this.Format_Reset();
                this.Clear_RadioButton(groupBoxFond);
                this.Clear_RadioButton(groupBoxCaracteres);
                this.Clear_RadioButton(groupBoxCasse);

            }

        }

        /// <summary>
        /// Cliquer sur un choix affiche les options correspondantes
        /// Si choix désactivé réinitialidation du label (texte modifié) et des boutons radio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_Click(object sender, EventArgs e)
        {
            this.Hide_Fond_Cara_Casse();

            if (checkBoxCouleurFond.Checked)
            {
                groupBoxFond.Visible = true;
            }
            else
            {
                labelTextModifie.BackColor = SystemColors.Control;
                this.Clear_RadioButton(groupBoxFond);
            }

            if (checkBoxCouleurCaracteres.Checked)
            {
                groupBoxCaracteres.Visible = true;
            }
            else
            {
                labelTextModifie.ForeColor = SystemColors.ControlText;
                this.Clear_RadioButton(groupBoxCaracteres);
            }

            if (checkBoxCasse.Checked)
            {
                groupBoxCasse.Visible = true;
            }
            else
            {
                labelTextModifie.Text = textBox_votreTexte.Text;
                this.Clear_RadioButton(groupBoxCasse);
            }

        }


        /// <summary>
        /// Colorie le fond du label (texte modifié) en fonction de l'option activée par clic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fond_Click(object sender, EventArgs e)
        {
            RadioButton radioButtonSend = (RadioButton)sender;
            switch (radioButtonSend.Tag.ToString())
            {
                case "fondRouge":
                    labelTextModifie.BackColor = Color.Red;
                    break;
                case "fondVert":
                    labelTextModifie.BackColor = Color.Green;
                    break;
                case "fondBleu":
                    labelTextModifie.BackColor = Color.Blue;
                    break;
                default:
                    labelTextModifie.BackColor = SystemColors.Control;
                    break;
            }
        }

        /// <summary>
        /// Colorie le texte du label (texte modifié) en fonction de l'option activée par clic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void caracteresCouleur_Click(object sender, EventArgs e)
        {
            RadioButton radioButtonSend = (RadioButton)sender;
            switch (radioButtonSend.Tag.ToString())
            {

                case "caraRouge":
                    labelTextModifie.ForeColor = Color.Red;
                    break;
                case "caraBlanc":
                    labelTextModifie.ForeColor = Color.White;
                    break;
                case "caraNoir":
                    labelTextModifie.ForeColor = Color.Black;
                    break;
                default:
                    labelTextModifie.ForeColor = SystemColors.ControlText;
                    break;
            }
        }

        /// <summary>
        /// Transforme le label (texte modifié) tout en minuscule ou tout en minuscule en fonction de l'option activée par clic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void casse_click(object sender, EventArgs e)
        {
            RadioButton radioButtonSend = (RadioButton)sender;
            switch (radioButtonSend.Tag.ToString())
            {

                case "minuscule":
                    labelTextModifie.Text = labelTextModifie.Text.ToLower();
                    break;
                case "majuscule":
                    labelTextModifie.Text = labelTextModifie.Text.ToUpper();
                    break;
                default:
                    labelTextModifie.Text = textBox_votreTexte.Text;
                    break;
            }
        }
    }
}
