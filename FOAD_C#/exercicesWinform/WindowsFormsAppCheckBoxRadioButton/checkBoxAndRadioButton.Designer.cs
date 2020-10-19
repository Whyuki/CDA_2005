namespace WindowsFormsAppCheckBoxRadioButton
{
    partial class checkBoxAndRadioButton
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tapez_votre_texte = new System.Windows.Forms.Label();
            this.textBox_votreTexte = new System.Windows.Forms.TextBox();
            this.groupBoxChoix = new System.Windows.Forms.GroupBox();
            this.checkBoxCasse = new System.Windows.Forms.CheckBox();
            this.checkBoxCouleurCaracteres = new System.Windows.Forms.CheckBox();
            this.checkBoxCouleurFond = new System.Windows.Forms.CheckBox();
            this.groupBoxFond = new System.Windows.Forms.GroupBox();
            this.radioButtonFondBleu = new System.Windows.Forms.RadioButton();
            this.radioButtonFondVert = new System.Windows.Forms.RadioButton();
            this.radioButtonFondRouge = new System.Windows.Forms.RadioButton();
            this.groupBoxCaracteres = new System.Windows.Forms.GroupBox();
            this.radioButtonCaraNoir = new System.Windows.Forms.RadioButton();
            this.radioButtonCaraBlanc = new System.Windows.Forms.RadioButton();
            this.radioButtonCaraRouge = new System.Windows.Forms.RadioButton();
            this.groupBoxCasse = new System.Windows.Forms.GroupBox();
            this.radioButtonCasseMajuscules = new System.Windows.Forms.RadioButton();
            this.radioButtonCasseMinuscules = new System.Windows.Forms.RadioButton();
            this.labelTextModifie = new System.Windows.Forms.Label();
            this.groupBoxChoix.SuspendLayout();
            this.groupBoxFond.SuspendLayout();
            this.groupBoxCaracteres.SuspendLayout();
            this.groupBoxCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tapez_votre_texte
            // 
            this.tapez_votre_texte.AutoSize = true;
            this.tapez_votre_texte.Location = new System.Drawing.Point(18, 21);
            this.tapez_votre_texte.Name = "tapez_votre_texte";
            this.tapez_votre_texte.Size = new System.Drawing.Size(90, 13);
            this.tapez_votre_texte.TabIndex = 0;
            this.tapez_votre_texte.Text = "Tapez votre texte";
            // 
            // textBox_votreTexte
            // 
            this.textBox_votreTexte.Location = new System.Drawing.Point(21, 40);
            this.textBox_votreTexte.Name = "textBox_votreTexte";
            this.textBox_votreTexte.Size = new System.Drawing.Size(214, 20);
            this.textBox_votreTexte.TabIndex = 1;
            this.textBox_votreTexte.TextChanged += new System.EventHandler(this.textBoxVotreTexte_TextChanged);
            // 
            // groupBoxChoix
            // 
            this.groupBoxChoix.Controls.Add(this.checkBoxCasse);
            this.groupBoxChoix.Controls.Add(this.checkBoxCouleurCaracteres);
            this.groupBoxChoix.Controls.Add(this.checkBoxCouleurFond);
            this.groupBoxChoix.Enabled = false;
            this.groupBoxChoix.Location = new System.Drawing.Point(314, 21);
            this.groupBoxChoix.Name = "groupBoxChoix";
            this.groupBoxChoix.Size = new System.Drawing.Size(179, 86);
            this.groupBoxChoix.TabIndex = 2;
            this.groupBoxChoix.TabStop = false;
            this.groupBoxChoix.Text = "Choix";
            // 
            // checkBoxCasse
            // 
            this.checkBoxCasse.AutoSize = true;
            this.checkBoxCasse.Location = new System.Drawing.Point(6, 62);
            this.checkBoxCasse.Name = "checkBoxCasse";
            this.checkBoxCasse.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCasse.TabIndex = 2;
            this.checkBoxCasse.Text = "Casse";
            this.checkBoxCasse.UseVisualStyleBackColor = true;
            this.checkBoxCasse.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBoxCouleurCaracteres
            // 
            this.checkBoxCouleurCaracteres.AutoSize = true;
            this.checkBoxCouleurCaracteres.Location = new System.Drawing.Point(6, 39);
            this.checkBoxCouleurCaracteres.Name = "checkBoxCouleurCaracteres";
            this.checkBoxCouleurCaracteres.Size = new System.Drawing.Size(135, 17);
            this.checkBoxCouleurCaracteres.TabIndex = 1;
            this.checkBoxCouleurCaracteres.Text = "Couleur des caractères";
            this.checkBoxCouleurCaracteres.UseVisualStyleBackColor = true;
            this.checkBoxCouleurCaracteres.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBoxCouleurFond
            // 
            this.checkBoxCouleurFond.AutoSize = true;
            this.checkBoxCouleurFond.Location = new System.Drawing.Point(6, 19);
            this.checkBoxCouleurFond.Name = "checkBoxCouleurFond";
            this.checkBoxCouleurFond.Size = new System.Drawing.Size(101, 17);
            this.checkBoxCouleurFond.TabIndex = 0;
            this.checkBoxCouleurFond.Text = "Couleur du fond";
            this.checkBoxCouleurFond.UseVisualStyleBackColor = true;
            this.checkBoxCouleurFond.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // groupBoxFond
            // 
            this.groupBoxFond.Controls.Add(this.radioButtonFondBleu);
            this.groupBoxFond.Controls.Add(this.radioButtonFondVert);
            this.groupBoxFond.Controls.Add(this.radioButtonFondRouge);
            this.groupBoxFond.Location = new System.Drawing.Point(24, 122);
            this.groupBoxFond.Name = "groupBoxFond";
            this.groupBoxFond.Size = new System.Drawing.Size(95, 100);
            this.groupBoxFond.TabIndex = 3;
            this.groupBoxFond.TabStop = false;
            this.groupBoxFond.Text = "Fond";
            this.groupBoxFond.Visible = false;
            // 
            // radioButtonFondBleu
            // 
            this.radioButtonFondBleu.AutoSize = true;
            this.radioButtonFondBleu.Location = new System.Drawing.Point(23, 68);
            this.radioButtonFondBleu.Name = "radioButtonFondBleu";
            this.radioButtonFondBleu.Size = new System.Drawing.Size(46, 17);
            this.radioButtonFondBleu.TabIndex = 2;
            this.radioButtonFondBleu.TabStop = true;
            this.radioButtonFondBleu.Tag = "fondBleu";
            this.radioButtonFondBleu.Text = "Bleu";
            this.radioButtonFondBleu.UseVisualStyleBackColor = true;
            this.radioButtonFondBleu.Click += new System.EventHandler(this.fond_Click);
            // 
            // radioButtonFondVert
            // 
            this.radioButtonFondVert.AutoSize = true;
            this.radioButtonFondVert.Location = new System.Drawing.Point(23, 44);
            this.radioButtonFondVert.Name = "radioButtonFondVert";
            this.radioButtonFondVert.Size = new System.Drawing.Size(44, 17);
            this.radioButtonFondVert.TabIndex = 1;
            this.radioButtonFondVert.TabStop = true;
            this.radioButtonFondVert.Tag = "fondVert";
            this.radioButtonFondVert.Text = "Vert";
            this.radioButtonFondVert.UseVisualStyleBackColor = true;
            this.radioButtonFondVert.Click += new System.EventHandler(this.fond_Click);
            // 
            // radioButtonFondRouge
            // 
            this.radioButtonFondRouge.AutoSize = true;
            this.radioButtonFondRouge.Location = new System.Drawing.Point(23, 20);
            this.radioButtonFondRouge.Name = "radioButtonFondRouge";
            this.radioButtonFondRouge.Size = new System.Drawing.Size(57, 17);
            this.radioButtonFondRouge.TabIndex = 0;
            this.radioButtonFondRouge.TabStop = true;
            this.radioButtonFondRouge.Tag = "fondRouge";
            this.radioButtonFondRouge.Text = "Rouge";
            this.radioButtonFondRouge.UseVisualStyleBackColor = true;
            this.radioButtonFondRouge.Click += new System.EventHandler(this.fond_Click);
            // 
            // groupBoxCaracteres
            // 
            this.groupBoxCaracteres.Controls.Add(this.radioButtonCaraNoir);
            this.groupBoxCaracteres.Controls.Add(this.radioButtonCaraBlanc);
            this.groupBoxCaracteres.Controls.Add(this.radioButtonCaraRouge);
            this.groupBoxCaracteres.Location = new System.Drawing.Point(125, 122);
            this.groupBoxCaracteres.Name = "groupBoxCaracteres";
            this.groupBoxCaracteres.Size = new System.Drawing.Size(95, 100);
            this.groupBoxCaracteres.TabIndex = 4;
            this.groupBoxCaracteres.TabStop = false;
            this.groupBoxCaracteres.Text = "Caractères";
            this.groupBoxCaracteres.Visible = false;
            // 
            // radioButtonCaraNoir
            // 
            this.radioButtonCaraNoir.AutoSize = true;
            this.radioButtonCaraNoir.Location = new System.Drawing.Point(23, 66);
            this.radioButtonCaraNoir.Name = "radioButtonCaraNoir";
            this.radioButtonCaraNoir.Size = new System.Drawing.Size(44, 17);
            this.radioButtonCaraNoir.TabIndex = 5;
            this.radioButtonCaraNoir.TabStop = true;
            this.radioButtonCaraNoir.Tag = "caraNoir";
            this.radioButtonCaraNoir.Text = "Noir";
            this.radioButtonCaraNoir.UseVisualStyleBackColor = true;
            this.radioButtonCaraNoir.Click += new System.EventHandler(this.caracteresCouleur_Click);
            // 
            // radioButtonCaraBlanc
            // 
            this.radioButtonCaraBlanc.AutoSize = true;
            this.radioButtonCaraBlanc.Location = new System.Drawing.Point(23, 42);
            this.radioButtonCaraBlanc.Name = "radioButtonCaraBlanc";
            this.radioButtonCaraBlanc.Size = new System.Drawing.Size(52, 17);
            this.radioButtonCaraBlanc.TabIndex = 4;
            this.radioButtonCaraBlanc.TabStop = true;
            this.radioButtonCaraBlanc.Tag = "caraBlanc";
            this.radioButtonCaraBlanc.Text = "Blanc";
            this.radioButtonCaraBlanc.UseVisualStyleBackColor = true;
            this.radioButtonCaraBlanc.Click += new System.EventHandler(this.caracteresCouleur_Click);
            // 
            // radioButtonCaraRouge
            // 
            this.radioButtonCaraRouge.AutoSize = true;
            this.radioButtonCaraRouge.Location = new System.Drawing.Point(23, 18);
            this.radioButtonCaraRouge.Name = "radioButtonCaraRouge";
            this.radioButtonCaraRouge.Size = new System.Drawing.Size(57, 17);
            this.radioButtonCaraRouge.TabIndex = 3;
            this.radioButtonCaraRouge.TabStop = true;
            this.radioButtonCaraRouge.Tag = "caraRouge";
            this.radioButtonCaraRouge.Text = "Rouge";
            this.radioButtonCaraRouge.UseVisualStyleBackColor = true;
            this.radioButtonCaraRouge.Click += new System.EventHandler(this.caracteresCouleur_Click);
            // 
            // groupBoxCasse
            // 
            this.groupBoxCasse.Controls.Add(this.radioButtonCasseMajuscules);
            this.groupBoxCasse.Controls.Add(this.radioButtonCasseMinuscules);
            this.groupBoxCasse.Location = new System.Drawing.Point(226, 150);
            this.groupBoxCasse.Name = "groupBoxCasse";
            this.groupBoxCasse.Size = new System.Drawing.Size(121, 72);
            this.groupBoxCasse.TabIndex = 4;
            this.groupBoxCasse.TabStop = false;
            this.groupBoxCasse.Text = "Casse";
            this.groupBoxCasse.Visible = false;
            // 
            // radioButtonCasseMajuscules
            // 
            this.radioButtonCasseMajuscules.AutoSize = true;
            this.radioButtonCasseMajuscules.Location = new System.Drawing.Point(25, 42);
            this.radioButtonCasseMajuscules.Name = "radioButtonCasseMajuscules";
            this.radioButtonCasseMajuscules.Size = new System.Drawing.Size(78, 17);
            this.radioButtonCasseMajuscules.TabIndex = 4;
            this.radioButtonCasseMajuscules.TabStop = true;
            this.radioButtonCasseMajuscules.Tag = "majuscule";
            this.radioButtonCasseMajuscules.Text = "Majuscules";
            this.radioButtonCasseMajuscules.UseVisualStyleBackColor = true;
            this.radioButtonCasseMajuscules.Click += new System.EventHandler(this.casse_click);
            // 
            // radioButtonCasseMinuscules
            // 
            this.radioButtonCasseMinuscules.AutoSize = true;
            this.radioButtonCasseMinuscules.Location = new System.Drawing.Point(25, 18);
            this.radioButtonCasseMinuscules.Name = "radioButtonCasseMinuscules";
            this.radioButtonCasseMinuscules.Size = new System.Drawing.Size(78, 17);
            this.radioButtonCasseMinuscules.TabIndex = 3;
            this.radioButtonCasseMinuscules.TabStop = true;
            this.radioButtonCasseMinuscules.Tag = "minuscule";
            this.radioButtonCasseMinuscules.Text = "Minuscules";
            this.radioButtonCasseMinuscules.UseVisualStyleBackColor = true;
            this.radioButtonCasseMinuscules.Click += new System.EventHandler(this.casse_click);
            // 
            // labelTextModifie
            // 
            this.labelTextModifie.AutoSize = true;
            this.labelTextModifie.BackColor = System.Drawing.SystemColors.Control;
            this.labelTextModifie.Location = new System.Drawing.Point(18, 83);
            this.labelTextModifie.Name = "labelTextModifie";
            this.labelTextModifie.Size = new System.Drawing.Size(157, 13);
            this.labelTextModifie.TabIndex = 5;
            this.labelTextModifie.Text = "                                                  ";
            // 
            // checkBoxAndRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 247);
            this.Controls.Add(this.labelTextModifie);
            this.Controls.Add(this.groupBoxCaracteres);
            this.Controls.Add(this.groupBoxCasse);
            this.Controls.Add(this.groupBoxFond);
            this.Controls.Add(this.groupBoxChoix);
            this.Controls.Add(this.textBox_votreTexte);
            this.Controls.Add(this.tapez_votre_texte);
            this.Name = "checkBoxAndRadioButton";
            this.Text = "CheckBox et RadioButton";
            this.groupBoxChoix.ResumeLayout(false);
            this.groupBoxChoix.PerformLayout();
            this.groupBoxFond.ResumeLayout(false);
            this.groupBoxFond.PerformLayout();
            this.groupBoxCaracteres.ResumeLayout(false);
            this.groupBoxCaracteres.PerformLayout();
            this.groupBoxCasse.ResumeLayout(false);
            this.groupBoxCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tapez_votre_texte;
        private System.Windows.Forms.TextBox textBox_votreTexte;
        private System.Windows.Forms.GroupBox groupBoxChoix;
        private System.Windows.Forms.CheckBox checkBoxCasse;
        private System.Windows.Forms.CheckBox checkBoxCouleurCaracteres;
        private System.Windows.Forms.CheckBox checkBoxCouleurFond;
        private System.Windows.Forms.GroupBox groupBoxFond;
        private System.Windows.Forms.RadioButton radioButtonFondBleu;
        private System.Windows.Forms.RadioButton radioButtonFondVert;
        private System.Windows.Forms.RadioButton radioButtonFondRouge;
        private System.Windows.Forms.GroupBox groupBoxCaracteres;
        private System.Windows.Forms.RadioButton radioButtonCaraNoir;
        private System.Windows.Forms.RadioButton radioButtonCaraBlanc;
        private System.Windows.Forms.RadioButton radioButtonCaraRouge;
        private System.Windows.Forms.GroupBox groupBoxCasse;
        private System.Windows.Forms.RadioButton radioButtonCasseMajuscules;
        private System.Windows.Forms.RadioButton radioButtonCasseMinuscules;
        private System.Windows.Forms.Label labelTextModifie;
    }
}

