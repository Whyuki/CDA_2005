
namespace WindowsFormsAppPapyrusGaming
{
    partial class FormFournisseur
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
            this.components = new System.ComponentModel.Container();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxNomFournisseur = new System.Windows.Forms.TextBox();
            this.textBoxAdresseFournisseur = new System.Windows.Forms.TextBox();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.textBoxCpFournisseur = new System.Windows.Forms.TextBox();
            this.labelCp = new System.Windows.Forms.Label();
            this.textBoxVilleFournisseur = new System.Windows.Forms.TextBox();
            this.labelVille = new System.Windows.Forms.Label();
            this.textBoxContactFournisseur = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.textBoxSatisfactionFournisseur = new System.Windows.Forms.TextBox();
            this.labelSatisfaction = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxCodeFournisseur = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.comboBoxListeFournisseurs = new System.Windows.Forms.ComboBox();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.errorProviderFournisseur = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.panelFournisseur = new System.Windows.Forms.Panel();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAdresse = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderVille = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSatisfaction = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSelectionFournisseur = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFournisseur)).BeginInit();
            this.panelFournisseur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdresse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSatisfaction)).BeginInit();
            this.panelSelectionFournisseur.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(23, 151);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // textBoxNomFournisseur
            // 
            this.textBoxNomFournisseur.Location = new System.Drawing.Point(3, 6);
            this.textBoxNomFournisseur.Name = "textBoxNomFournisseur";
            this.textBoxNomFournisseur.ReadOnly = true;
            this.textBoxNomFournisseur.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomFournisseur.TabIndex = 1;
            this.textBoxNomFournisseur.TextChanged += new System.EventHandler(this.textBoxNomFournisseur_TextChanged);
            this.textBoxNomFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNomFournisseur_Validating);
            // 
            // textBoxAdresseFournisseur
            // 
            this.textBoxAdresseFournisseur.Location = new System.Drawing.Point(3, 32);
            this.textBoxAdresseFournisseur.Name = "textBoxAdresseFournisseur";
            this.textBoxAdresseFournisseur.ReadOnly = true;
            this.textBoxAdresseFournisseur.Size = new System.Drawing.Size(147, 20);
            this.textBoxAdresseFournisseur.TabIndex = 3;
            this.textBoxAdresseFournisseur.TextChanged += new System.EventHandler(this.textBoxAdresseFournisseur_TextChanged);
            this.textBoxAdresseFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAdresseFournisseur_Validating);
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(23, 177);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(45, 13);
            this.labelAdresse.TabIndex = 2;
            this.labelAdresse.Text = "Adresse";
            // 
            // textBoxCpFournisseur
            // 
            this.textBoxCpFournisseur.Location = new System.Drawing.Point(3, 58);
            this.textBoxCpFournisseur.Name = "textBoxCpFournisseur";
            this.textBoxCpFournisseur.ReadOnly = true;
            this.textBoxCpFournisseur.Size = new System.Drawing.Size(58, 20);
            this.textBoxCpFournisseur.TabIndex = 5;
            this.textBoxCpFournisseur.TextChanged += new System.EventHandler(this.textBoxCpFournisseur_TextChanged);
            this.textBoxCpFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCpFournisseur_Validating);
            // 
            // labelCp
            // 
            this.labelCp.AutoSize = true;
            this.labelCp.Location = new System.Drawing.Point(23, 203);
            this.labelCp.Name = "labelCp";
            this.labelCp.Size = new System.Drawing.Size(21, 13);
            this.labelCp.TabIndex = 4;
            this.labelCp.Text = "CP";
            // 
            // textBoxVilleFournisseur
            // 
            this.textBoxVilleFournisseur.Location = new System.Drawing.Point(3, 84);
            this.textBoxVilleFournisseur.Name = "textBoxVilleFournisseur";
            this.textBoxVilleFournisseur.ReadOnly = true;
            this.textBoxVilleFournisseur.Size = new System.Drawing.Size(100, 20);
            this.textBoxVilleFournisseur.TabIndex = 7;
            this.textBoxVilleFournisseur.TextChanged += new System.EventHandler(this.textBoxVilleFournisseur_TextChanged);
            this.textBoxVilleFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVilleFournisseur_Validating);
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(23, 229);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(26, 13);
            this.labelVille.TabIndex = 6;
            this.labelVille.Text = "Ville";
            // 
            // textBoxContactFournisseur
            // 
            this.textBoxContactFournisseur.Location = new System.Drawing.Point(3, 110);
            this.textBoxContactFournisseur.Name = "textBoxContactFournisseur";
            this.textBoxContactFournisseur.ReadOnly = true;
            this.textBoxContactFournisseur.Size = new System.Drawing.Size(100, 20);
            this.textBoxContactFournisseur.TabIndex = 9;
            this.textBoxContactFournisseur.TextChanged += new System.EventHandler(this.textBoxContactFournisseur_TextChanged);
            this.textBoxContactFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxContactFournisseur_Validating);
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(23, 255);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(44, 13);
            this.labelContact.TabIndex = 8;
            this.labelContact.Text = "Contact";
            // 
            // textBoxSatisfactionFournisseur
            // 
            this.textBoxSatisfactionFournisseur.Location = new System.Drawing.Point(3, 136);
            this.textBoxSatisfactionFournisseur.Name = "textBoxSatisfactionFournisseur";
            this.textBoxSatisfactionFournisseur.ReadOnly = true;
            this.textBoxSatisfactionFournisseur.Size = new System.Drawing.Size(36, 20);
            this.textBoxSatisfactionFournisseur.TabIndex = 11;
            this.textBoxSatisfactionFournisseur.TextChanged += new System.EventHandler(this.textBoxSatisfactionFournisseur_TextChanged);
            this.textBoxSatisfactionFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSatisfactionFournisseur_Validating);
            // 
            // labelSatisfaction
            // 
            this.labelSatisfaction.AutoSize = true;
            this.labelSatisfaction.Location = new System.Drawing.Point(23, 281);
            this.labelSatisfaction.Name = "labelSatisfaction";
            this.labelSatisfaction.Size = new System.Drawing.Size(62, 13);
            this.labelSatisfaction.TabIndex = 10;
            this.labelSatisfaction.Text = "Satisfaction";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(4, 50);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(32, 13);
            this.labelId.TabIndex = 12;
            this.labelId.Text = "Code";
            // 
            // textBoxCodeFournisseur
            // 
            this.textBoxCodeFournisseur.Location = new System.Drawing.Point(45, 47);
            this.textBoxCodeFournisseur.Name = "textBoxCodeFournisseur";
            this.textBoxCodeFournisseur.Size = new System.Drawing.Size(65, 20);
            this.textBoxCodeFournisseur.TabIndex = 13;
            this.textBoxCodeFournisseur.TextChanged += new System.EventHandler(this.textBoxCodeFournisseur_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.Enabled = false;
            this.buttonValider.Location = new System.Drawing.Point(108, 317);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 14;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // comboBoxListeFournisseurs
            // 
            this.comboBoxListeFournisseurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListeFournisseurs.FormattingEnabled = true;
            this.comboBoxListeFournisseurs.Location = new System.Drawing.Point(42, 3);
            this.comboBoxListeFournisseurs.Name = "comboBoxListeFournisseurs";
            this.comboBoxListeFournisseurs.Size = new System.Drawing.Size(149, 21);
            this.comboBoxListeFournisseurs.TabIndex = 15;
            this.comboBoxListeFournisseurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeFournisseurs_SelectedIndexChanged);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Enabled = false;
            this.buttonRechercher.Location = new System.Drawing.Point(116, 45);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(75, 23);
            this.buttonRechercher.TabIndex = 16;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // errorProviderFournisseur
            // 
            this.errorProviderFournisseur.ContainerControl = this;
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.AutoSize = true;
            this.buttonNouveau.Location = new System.Drawing.Point(7, 358);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(115, 23);
            this.buttonNouveau.TabIndex = 17;
            this.buttonNouveau.Text = "Nouveau fournisseur";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            this.buttonNouveau.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Enabled = false;
            this.buttonModifier.Location = new System.Drawing.Point(75, 108);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 18;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Enabled = false;
            this.buttonSupprimer.Location = new System.Drawing.Point(156, 108);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 19;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(190, 358);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 20;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // panelFournisseur
            // 
            this.panelFournisseur.Controls.Add(this.textBoxNomFournisseur);
            this.panelFournisseur.Controls.Add(this.textBoxAdresseFournisseur);
            this.panelFournisseur.Controls.Add(this.textBoxCpFournisseur);
            this.panelFournisseur.Controls.Add(this.textBoxVilleFournisseur);
            this.panelFournisseur.Controls.Add(this.textBoxContactFournisseur);
            this.panelFournisseur.Controls.Add(this.textBoxSatisfactionFournisseur);
            this.panelFournisseur.Location = new System.Drawing.Point(91, 142);
            this.panelFournisseur.Name = "panelFournisseur";
            this.panelFournisseur.Size = new System.Drawing.Size(174, 169);
            this.panelFournisseur.TabIndex = 21;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Enabled = false;
            this.buttonAnnuler.Location = new System.Drawing.Point(190, 317);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 22;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.ContainerControl = this;
            // 
            // errorProviderAdresse
            // 
            this.errorProviderAdresse.ContainerControl = this;
            // 
            // errorProviderCP
            // 
            this.errorProviderCP.ContainerControl = this;
            // 
            // errorProviderVille
            // 
            this.errorProviderVille.ContainerControl = this;
            // 
            // errorProviderContact
            // 
            this.errorProviderContact.ContainerControl = this;
            // 
            // errorProviderSatisfaction
            // 
            this.errorProviderSatisfaction.ContainerControl = this;
            // 
            // panelSelectionFournisseur
            // 
            this.panelSelectionFournisseur.Controls.Add(this.comboBoxListeFournisseurs);
            this.panelSelectionFournisseur.Controls.Add(this.labelId);
            this.panelSelectionFournisseur.Controls.Add(this.textBoxCodeFournisseur);
            this.panelSelectionFournisseur.Controls.Add(this.buttonRechercher);
            this.panelSelectionFournisseur.Location = new System.Drawing.Point(40, 12);
            this.panelSelectionFournisseur.Name = "panelSelectionFournisseur";
            this.panelSelectionFournisseur.Size = new System.Drawing.Size(213, 90);
            this.panelSelectionFournisseur.TabIndex = 23;
            // 
            // FormFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 396);
            this.Controls.Add(this.panelSelectionFournisseur);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.panelFournisseur);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.labelCp);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.labelSatisfaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion fournisseur";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFournisseur)).EndInit();
            this.panelFournisseur.ResumeLayout(false);
            this.panelFournisseur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdresse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSatisfaction)).EndInit();
            this.panelSelectionFournisseur.ResumeLayout(false);
            this.panelSelectionFournisseur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNomFournisseur;
        private System.Windows.Forms.TextBox textBoxAdresseFournisseur;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.TextBox textBoxCpFournisseur;
        private System.Windows.Forms.Label labelCp;
        private System.Windows.Forms.TextBox textBoxVilleFournisseur;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.TextBox textBoxContactFournisseur;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.TextBox textBoxSatisfactionFournisseur;
        private System.Windows.Forms.Label labelSatisfaction;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxCodeFournisseur;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.ComboBox comboBoxListeFournisseurs;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.ErrorProvider errorProviderFournisseur;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.Panel panelFournisseur;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ErrorProvider errorProviderNom;
        private System.Windows.Forms.ErrorProvider errorProviderAdresse;
        private System.Windows.Forms.ErrorProvider errorProviderCP;
        private System.Windows.Forms.ErrorProvider errorProviderVille;
        private System.Windows.Forms.ErrorProvider errorProviderContact;
        private System.Windows.Forms.ErrorProvider errorProviderSatisfaction;
        private System.Windows.Forms.Panel panelSelectionFournisseur;
    }
}

