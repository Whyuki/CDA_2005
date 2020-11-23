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

        private static int compteurInstance;
        public Color CouleurChoisie { get => couleurChoisie; /*set => couleurChoisie = value;*/ }

        public Defilement()
        {
            InitializeComponent();
            compteurInstance++;
            this.Text += " n° " + compteurInstance.ToString();
            couleurChoisie = Color.FromArgb(0, 0, 0);
            MiseAJourDeLaVue();
        }

        /// <summary>
        /// Modifier une couleur selectionnée
        /// </summary>
        /// <param name="_couleurAModifier"></param>
        public Defilement(Color _couleurAModifier)
        {
            InitializeComponent();
            couleurChoisie = _couleurAModifier;
            MiseAJourDeLaVue();
        }

        /// <summary>
        /// Met à jour la vue en fonction de la couleur choisie
        /// </summary>
        public void MiseAJourDeLaVue()
        {
            this.hScrollBarRouge.Value = couleurChoisie.R;
            this.numericUpDownRouge.Value = couleurChoisie.R;
            this.textBoxRouge.BackColor = Color.FromArgb(couleurChoisie.R, 0, 0);

            this.hScrollBarVert.Value = couleurChoisie.G;
            this.numericUpDownVert.Value = couleurChoisie.G;
            this.textBoxVert.BackColor = Color.FromArgb(0, couleurChoisie.G, 0);

            this.hScrollBarBleu.Value = couleurChoisie.B;
            this.numericUpDownBleu.Value = couleurChoisie.B;
            this.textBoxBleu.BackColor = Color.FromArgb(0, 0, couleurChoisie.B);

            textBoxCouleurChoisie.BackColor = couleurChoisie;
        }


        /// <summary>
        /// Modifie la valeur du rouge de la couleur choisie en défilant la barre (synchronisation avec le controle numérique)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBarRouge_ValueChanged(object sender, EventArgs e)
        {
            //mise a jour du modele couleurChoisie
            couleurChoisie = Color.FromArgb(hScrollBarRouge.Value, couleurChoisie.G, couleurChoisie.B);
            //mise a jour de l'IHM a partir du modele
            MiseAJourDeLaVue();
        }

        /// <summary>
        /// Modifie la valeur du vert de la couleur choisie en défilant la barre (synchronisation avec le controle numérique)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBarVert_ValueChanged(object sender, EventArgs e)
        {
            couleurChoisie = Color.FromArgb(couleurChoisie.R, hScrollBarVert.Value, couleurChoisie.B);
            MiseAJourDeLaVue();
        }

        /// <summary>
        /// Modifie la valeur du bleu de la couleur choisie en défilant la barre (synchronisation avec le controle numérique)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBarBleu_ValueChanged(object sender, EventArgs e)
        {
            couleurChoisie = Color.FromArgb(couleurChoisie.R, couleurChoisie.G, hScrollBarBleu.Value);
            MiseAJourDeLaVue();
        }

        /// <summary>
        /// Modifie la valeur du rouge de la couleur choisie grace au controle numérique (synchronisation avec la barre de défilement)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownRouge_ValueChanged(object sender, EventArgs e)
        {

            couleurChoisie = Color.FromArgb((int)numericUpDownRouge.Value, couleurChoisie.G, couleurChoisie.B);
            MiseAJourDeLaVue();
        }

        /// <summary>
        /// Modifie la valeur du vert de la couleur choisie grace au controle numérique (synchronisation avec la barre de défilement)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownVert_ValueChanged(object sender, EventArgs e)
        {
            couleurChoisie = Color.FromArgb(couleurChoisie.R, (int)numericUpDownVert.Value, couleurChoisie.B);
            MiseAJourDeLaVue();
        }

        /// <summary>
        /// Modifie la valeur du bleu de la couleur choisie grace au controle numérique (synchronisation avec la barre de défilement)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownBleu_ValueChanged(object sender, EventArgs e)
        {
            couleurChoisie = Color.FromArgb(couleurChoisie.R, couleurChoisie.G, (int)numericUpDownBleu.Value);
            MiseAJourDeLaVue();
        }
    }
}
