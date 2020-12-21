
namespace WindowsFormsAppPapyrus
{
    partial class FormGestionFournisseurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxSatisfactionFournisseur = new System.Windows.Forms.TextBox();
            this.labelSatisfactionFournisseur = new System.Windows.Forms.Label();
            this.textBoxContactFournisseur = new System.Windows.Forms.TextBox();
            this.labelContactFournisseur = new System.Windows.Forms.Label();
            this.textBoxVilleFournisseur = new System.Windows.Forms.TextBox();
            this.textBoxCpFournisseur = new System.Windows.Forms.TextBox();
            this.labelCpVilleFournisseur = new System.Windows.Forms.Label();
            this.textBoxAdresseFournisseur = new System.Windows.Forms.TextBox();
            this.labelAdresseFournisseur = new System.Windows.Forms.Label();
            this.textBoxNomFournisseur = new System.Windows.Forms.TextBox();
            this.labelNomFournisseur = new System.Windows.Forms.Label();
            this.textBoxCodeFournisseur = new System.Windows.Forms.TextBox();
            this.labelCodeFournisseur = new System.Windows.Forms.Label();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.comboBoxListeFournisseurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderCodeFournisseur = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.errorProviderSuppression = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSelectFournisseur = new System.Windows.Forms.Panel();
            this.panelTBFournisseur = new System.Windows.Forms.Panel();
            this.buttonValider = new System.Windows.Forms.Button();
            this.errorProviderSaisie = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodeFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSuppression)).BeginInit();
            this.panelSelectFournisseur.SuspendLayout();
            this.panelTBFournisseur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSaisie)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSatisfactionFournisseur
            // 
            this.textBoxSatisfactionFournisseur.Location = new System.Drawing.Point(4, 168);
            this.textBoxSatisfactionFournisseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSatisfactionFournisseur.Name = "textBoxSatisfactionFournisseur";
            this.textBoxSatisfactionFournisseur.ReadOnly = true;
            this.textBoxSatisfactionFournisseur.Size = new System.Drawing.Size(54, 20);
            this.textBoxSatisfactionFournisseur.TabIndex = 21;
            this.textBoxSatisfactionFournisseur.TextChanged += new System.EventHandler(this.textBoxSatisfactionFournisseur_TextChanged);
            this.textBoxSatisfactionFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSatisfactionFournisseur_Validating);
            // 
            // labelSatisfactionFournisseur
            // 
            this.labelSatisfactionFournisseur.AutoSize = true;
            this.labelSatisfactionFournisseur.Location = new System.Drawing.Point(39, 354);
            this.labelSatisfactionFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSatisfactionFournisseur.Name = "labelSatisfactionFournisseur";
            this.labelSatisfactionFournisseur.Size = new System.Drawing.Size(62, 13);
            this.labelSatisfactionFournisseur.TabIndex = 20;
            this.labelSatisfactionFournisseur.Text = "Satisfaction";
            // 
            // textBoxContactFournisseur
            // 
            this.textBoxContactFournisseur.Location = new System.Drawing.Point(4, 128);
            this.textBoxContactFournisseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxContactFournisseur.Name = "textBoxContactFournisseur";
            this.textBoxContactFournisseur.ReadOnly = true;
            this.textBoxContactFournisseur.Size = new System.Drawing.Size(193, 20);
            this.textBoxContactFournisseur.TabIndex = 19;
            this.textBoxContactFournisseur.TextChanged += new System.EventHandler(this.textBoxContactFournisseur_TextChanged);
            this.textBoxContactFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxContactFournisseur_Validating);
            // 
            // labelContactFournisseur
            // 
            this.labelContactFournisseur.AutoSize = true;
            this.labelContactFournisseur.Location = new System.Drawing.Point(39, 314);
            this.labelContactFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactFournisseur.Name = "labelContactFournisseur";
            this.labelContactFournisseur.Size = new System.Drawing.Size(44, 13);
            this.labelContactFournisseur.TabIndex = 18;
            this.labelContactFournisseur.Text = "Contact";
            // 
            // textBoxVilleFournisseur
            // 
            this.textBoxVilleFournisseur.Location = new System.Drawing.Point(81, 88);
            this.textBoxVilleFournisseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxVilleFournisseur.Name = "textBoxVilleFournisseur";
            this.textBoxVilleFournisseur.ReadOnly = true;
            this.textBoxVilleFournisseur.Size = new System.Drawing.Size(116, 20);
            this.textBoxVilleFournisseur.TabIndex = 17;
            this.textBoxVilleFournisseur.TextChanged += new System.EventHandler(this.textBoxVilleFournisseur_TextChanged);
            this.textBoxVilleFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxVilleFournisseur_Validating);
            // 
            // textBoxCpFournisseur
            // 
            this.textBoxCpFournisseur.Location = new System.Drawing.Point(4, 88);
            this.textBoxCpFournisseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCpFournisseur.MaxLength = 5;
            this.textBoxCpFournisseur.Name = "textBoxCpFournisseur";
            this.textBoxCpFournisseur.ReadOnly = true;
            this.textBoxCpFournisseur.Size = new System.Drawing.Size(66, 20);
            this.textBoxCpFournisseur.TabIndex = 16;
            this.textBoxCpFournisseur.TextChanged += new System.EventHandler(this.textBoxCpFournisseur_TextChanged);
            this.textBoxCpFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCpFournisseur_Validating);
            // 
            // labelCpVilleFournisseur
            // 
            this.labelCpVilleFournisseur.AutoSize = true;
            this.labelCpVilleFournisseur.Location = new System.Drawing.Point(39, 274);
            this.labelCpVilleFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCpVilleFournisseur.Name = "labelCpVilleFournisseur";
            this.labelCpVilleFournisseur.Size = new System.Drawing.Size(51, 13);
            this.labelCpVilleFournisseur.TabIndex = 15;
            this.labelCpVilleFournisseur.Text = "CP / Ville";
            // 
            // textBoxAdresseFournisseur
            // 
            this.textBoxAdresseFournisseur.Location = new System.Drawing.Point(4, 46);
            this.textBoxAdresseFournisseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAdresseFournisseur.Name = "textBoxAdresseFournisseur";
            this.textBoxAdresseFournisseur.ReadOnly = true;
            this.textBoxAdresseFournisseur.Size = new System.Drawing.Size(193, 20);
            this.textBoxAdresseFournisseur.TabIndex = 14;
            this.textBoxAdresseFournisseur.TextChanged += new System.EventHandler(this.textBoxAdresseFournisseur_TextChanged);
            this.textBoxAdresseFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAdresseFournisseur_Validating);
            // 
            // labelAdresseFournisseur
            // 
            this.labelAdresseFournisseur.AutoSize = true;
            this.labelAdresseFournisseur.Location = new System.Drawing.Point(39, 232);
            this.labelAdresseFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdresseFournisseur.Name = "labelAdresseFournisseur";
            this.labelAdresseFournisseur.Size = new System.Drawing.Size(45, 13);
            this.labelAdresseFournisseur.TabIndex = 13;
            this.labelAdresseFournisseur.Text = "Adresse";
            // 
            // textBoxNomFournisseur
            // 
            this.textBoxNomFournisseur.Location = new System.Drawing.Point(4, 5);
            this.textBoxNomFournisseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNomFournisseur.Name = "textBoxNomFournisseur";
            this.textBoxNomFournisseur.ReadOnly = true;
            this.textBoxNomFournisseur.Size = new System.Drawing.Size(193, 20);
            this.textBoxNomFournisseur.TabIndex = 12;
            this.textBoxNomFournisseur.TextChanged += new System.EventHandler(this.textBoxNomFournisseur_TextChanged);
            this.textBoxNomFournisseur.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNomFournisseur_Validating);
            // 
            // labelNomFournisseur
            // 
            this.labelNomFournisseur.AutoSize = true;
            this.labelNomFournisseur.Location = new System.Drawing.Point(39, 191);
            this.labelNomFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomFournisseur.Name = "labelNomFournisseur";
            this.labelNomFournisseur.Size = new System.Drawing.Size(29, 13);
            this.labelNomFournisseur.TabIndex = 11;
            this.labelNomFournisseur.Text = "Nom";
            // 
            // textBoxCodeFournisseur
            // 
            this.textBoxCodeFournisseur.Location = new System.Drawing.Point(128, 64);
            this.textBoxCodeFournisseur.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxCodeFournisseur.Name = "textBoxCodeFournisseur";
            this.textBoxCodeFournisseur.Size = new System.Drawing.Size(97, 20);
            this.textBoxCodeFournisseur.TabIndex = 23;
            this.textBoxCodeFournisseur.TextChanged += new System.EventHandler(this.textBoxCodeFournisseur_TextChanged);
            this.textBoxCodeFournisseur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodeFournisseur_KeyPress);
            // 
            // labelCodeFournisseur
            // 
            this.labelCodeFournisseur.AutoSize = true;
            this.labelCodeFournisseur.Location = new System.Drawing.Point(13, 67);
            this.labelCodeFournisseur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCodeFournisseur.Name = "labelCodeFournisseur";
            this.labelCodeFournisseur.Size = new System.Drawing.Size(86, 13);
            this.labelCodeFournisseur.TabIndex = 22;
            this.labelCodeFournisseur.Text = "Code fournisseur";
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Enabled = false;
            this.buttonRechercher.Location = new System.Drawing.Point(249, 62);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(75, 23);
            this.buttonRechercher.TabIndex = 24;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Enabled = false;
            this.buttonModifier.Location = new System.Drawing.Point(72, 105);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 25;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Enabled = false;
            this.buttonSupprimer.Location = new System.Drawing.Point(173, 105);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSupprimer.TabIndex = 26;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.AutoSize = true;
            this.buttonNouveau.Location = new System.Drawing.Point(12, 154);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(115, 23);
            this.buttonNouveau.TabIndex = 27;
            this.buttonNouveau.Text = "Nouveau fournisseur";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            this.buttonNouveau.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Enabled = false;
            this.buttonAjouter.Location = new System.Drawing.Point(12, 386);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 28;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Visible = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(300, 416);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 29;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // comboBoxListeFournisseurs
            // 
            this.comboBoxListeFournisseurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListeFournisseurs.FormattingEnabled = true;
            this.comboBoxListeFournisseurs.Location = new System.Drawing.Point(151, 12);
            this.comboBoxListeFournisseurs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxListeFournisseurs.Name = "comboBoxListeFournisseurs";
            this.comboBoxListeFournisseurs.Size = new System.Drawing.Size(161, 21);
            this.comboBoxListeFournisseurs.TabIndex = 31;
            this.comboBoxListeFournisseurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeFournisseurs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Choisir un fournisseur";
            // 
            // errorProviderCodeFournisseur
            // 
            this.errorProviderCodeFournisseur.ContainerControl = this;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Enabled = false;
            this.buttonAnnuler.Location = new System.Drawing.Point(93, 386);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 32;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Visible = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // errorProviderSuppression
            // 
            this.errorProviderSuppression.ContainerControl = this;
            // 
            // panelSelectFournisseur
            // 
            this.panelSelectFournisseur.Controls.Add(this.buttonSupprimer);
            this.panelSelectFournisseur.Controls.Add(this.labelCodeFournisseur);
            this.panelSelectFournisseur.Controls.Add(this.comboBoxListeFournisseurs);
            this.panelSelectFournisseur.Controls.Add(this.textBoxCodeFournisseur);
            this.panelSelectFournisseur.Controls.Add(this.label1);
            this.panelSelectFournisseur.Controls.Add(this.buttonRechercher);
            this.panelSelectFournisseur.Controls.Add(this.buttonModifier);
            this.panelSelectFournisseur.Location = new System.Drawing.Point(12, 12);
            this.panelSelectFournisseur.Name = "panelSelectFournisseur";
            this.panelSelectFournisseur.Size = new System.Drawing.Size(363, 136);
            this.panelSelectFournisseur.TabIndex = 33;
            // 
            // panelTBFournisseur
            // 
            this.panelTBFournisseur.Controls.Add(this.textBoxNomFournisseur);
            this.panelTBFournisseur.Controls.Add(this.textBoxAdresseFournisseur);
            this.panelTBFournisseur.Controls.Add(this.textBoxCpFournisseur);
            this.panelTBFournisseur.Controls.Add(this.textBoxVilleFournisseur);
            this.panelTBFournisseur.Controls.Add(this.textBoxContactFournisseur);
            this.panelTBFournisseur.Controls.Add(this.textBoxSatisfactionFournisseur);
            this.panelTBFournisseur.Location = new System.Drawing.Point(108, 183);
            this.panelTBFournisseur.Name = "panelTBFournisseur";
            this.panelTBFournisseur.Size = new System.Drawing.Size(216, 195);
            this.panelTBFournisseur.TabIndex = 34;
            // 
            // buttonValider
            // 
            this.buttonValider.Enabled = false;
            this.buttonValider.Location = new System.Drawing.Point(12, 386);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 35;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Visible = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // errorProviderSaisie
            // 
            this.errorProviderSaisie.ContainerControl = this;
            // 
            // FormMajFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 451);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.panelTBFournisseur);
            this.Controls.Add(this.panelSelectFournisseur);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.labelSatisfactionFournisseur);
            this.Controls.Add(this.labelContactFournisseur);
            this.Controls.Add(this.labelCpVilleFournisseur);
            this.Controls.Add(this.labelAdresseFournisseur);
            this.Controls.Add(this.labelNomFournisseur);
            this.Name = "FormMajFournisseurs";
            this.Text = "Gestion fournisseurs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestionFournisseurs_FormClosing);
            this.Load += new System.EventHandler(this.FormGestionFournisseurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodeFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSuppression)).EndInit();
            this.panelSelectFournisseur.ResumeLayout(false);
            this.panelSelectFournisseur.PerformLayout();
            this.panelTBFournisseur.ResumeLayout(false);
            this.panelTBFournisseur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSaisie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSatisfactionFournisseur;
        private System.Windows.Forms.Label labelSatisfactionFournisseur;
        private System.Windows.Forms.TextBox textBoxContactFournisseur;
        private System.Windows.Forms.Label labelContactFournisseur;
        private System.Windows.Forms.TextBox textBoxVilleFournisseur;
        private System.Windows.Forms.TextBox textBoxCpFournisseur;
        private System.Windows.Forms.Label labelCpVilleFournisseur;
        private System.Windows.Forms.TextBox textBoxAdresseFournisseur;
        private System.Windows.Forms.Label labelAdresseFournisseur;
        private System.Windows.Forms.TextBox textBoxNomFournisseur;
        private System.Windows.Forms.Label labelNomFournisseur;
        private System.Windows.Forms.TextBox textBoxCodeFournisseur;
        private System.Windows.Forms.Label labelCodeFournisseur;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.ComboBox comboBoxListeFournisseurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderCodeFournisseur;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ErrorProvider errorProviderSuppression;
        private System.Windows.Forms.Panel panelSelectFournisseur;
        private System.Windows.Forms.Panel panelTBFournisseur;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.ErrorProvider errorProviderSaisie;
    }
}