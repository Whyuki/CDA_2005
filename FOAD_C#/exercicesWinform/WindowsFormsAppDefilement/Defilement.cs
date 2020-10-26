using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDefilement
{
    public partial class Defilement : Form
    {
        private Color couleurChoisie;

        public Defilement()
        {
            InitializeComponent();
            couleurChoisie = Color.FromArgb(0, 0, 0);
        }

        /// <summary>
        /// Applique la couleur choisie
        /// </summary>
        private void ChangeCouleur()
        {
            textBoxCouleurChoisie.BackColor = couleurChoisie;
        }

        /// <summary>
        /// Modifie la valeur du rouge de la couleur choisie en défilant la barre (synchronisation avec le controle numérique)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBarRouge_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownRouge.Value = hScrollBarRouge.Value;
            couleurChoisie = Color.FromArgb(hScrollBarRouge.Value, couleurChoisie.G, couleurChoisie.B);
            this.ChangeCouleur();
        }

        /// <summary>
        /// Modifie la valeur du vert de la couleur choisie en défilant la barre (synchronisation avec le controle numérique)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBarVert_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownVert.Value = hScrollBarVert.Value;
            couleurChoisie = Color.FromArgb(couleurChoisie.R, hScrollBarVert.Value, couleurChoisie.B);
            this.ChangeCouleur();
        }

        /// <summary>
        /// Modifie la valeur du bleu de la couleur choisie en défilant la barre (synchronisation avec le controle numérique)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBarBleu_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownBleu.Value = hScrollBarBleu.Value;
            couleurChoisie = Color.FromArgb(couleurChoisie.R, couleurChoisie.G, hScrollBarBleu.Value);
            this.ChangeCouleur();
        }

        /// <summary>
        /// Modifie la valeur du rouge de la couleur choisie grace au controle numérique (synchronisation avec la barre de défilement)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownRouge_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarRouge.Value = (int)numericUpDownRouge.Value;
        }

        /// <summary>
        /// Modifie la valeur du vert de la couleur choisie grace au controle numérique (synchronisation avec la barre de défilement)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownVert_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarVert.Value = (int)numericUpDownVert.Value;
        }

        /// <summary>
        /// Modifie la valeur du bleu de la couleur choisie grace au controle numérique (synchronisation avec la barre de défilement)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownBleu_ValueChanged(object sender, EventArgs e)
        {
            hScrollBarBleu.Value = (int)numericUpDownBleu.Value;
        }
    }
}
