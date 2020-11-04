namespace WindowsFormsAppEmprunt
{
    partial class FormEmprunt
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelDureeMoisRemboursement = new System.Windows.Forms.Label();
            this.labelPeriodiciteRemboursement = new System.Windows.Forms.Label();
            this.labelNbRemboursement = new System.Windows.Forms.Label();
            this.labelRemboursements = new System.Windows.Forms.Label();
            this.labelMontantRemboursement = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCapitalEmprunte = new System.Windows.Forms.TextBox();
            this.groupBoxTauxInteret = new System.Windows.Forms.GroupBox();
            this.radioButton9pourcent = new System.Windows.Forms.RadioButton();
            this.radioButton8pourcent = new System.Windows.Forms.RadioButton();
            this.radioButton7pourcent = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.listBoxPeriodicite = new System.Windows.Forms.ListBox();
            this.hScrollBarDuree = new System.Windows.Forms.HScrollBar();
            this.labelDureeChoisie = new System.Windows.Forms.Label();
            this.errorProviderNom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCapital = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxTauxInteret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCapital)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(33, 41);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(42, 20);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capital Emprunté";
            // 
            // labelDureeMoisRemboursement
            // 
            this.labelDureeMoisRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDureeMoisRemboursement.Location = new System.Drawing.Point(33, 181);
            this.labelDureeMoisRemboursement.Name = "labelDureeMoisRemboursement";
            this.labelDureeMoisRemboursement.Size = new System.Drawing.Size(140, 44);
            this.labelDureeMoisRemboursement.TabIndex = 2;
            this.labelDureeMoisRemboursement.Text = "Durée en mois du remboursement";
            // 
            // labelPeriodiciteRemboursement
            // 
            this.labelPeriodiciteRemboursement.AutoSize = true;
            this.labelPeriodiciteRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriodiciteRemboursement.Location = new System.Drawing.Point(33, 272);
            this.labelPeriodiciteRemboursement.Name = "labelPeriodiciteRemboursement";
            this.labelPeriodiciteRemboursement.Size = new System.Drawing.Size(220, 20);
            this.labelPeriodiciteRemboursement.TabIndex = 3;
            this.labelPeriodiciteRemboursement.Text = "Périodicité de remboursement";
            // 
            // labelNbRemboursement
            // 
            this.labelNbRemboursement.AutoSize = true;
            this.labelNbRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbRemboursement.ForeColor = System.Drawing.Color.Red;
            this.labelNbRemboursement.Location = new System.Drawing.Point(429, 272);
            this.labelNbRemboursement.Name = "labelNbRemboursement";
            this.labelNbRemboursement.Size = new System.Drawing.Size(61, 20);
            this.labelNbRemboursement.TabIndex = 4;
            this.labelNbRemboursement.Text = "             ";
            this.labelNbRemboursement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRemboursements
            // 
            this.labelRemboursements.AutoSize = true;
            this.labelRemboursements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemboursements.Location = new System.Drawing.Point(496, 272);
            this.labelRemboursements.Name = "labelRemboursements";
            this.labelRemboursements.Size = new System.Drawing.Size(146, 20);
            this.labelRemboursements.TabIndex = 5;
            this.labelRemboursements.Text = "Remboursement(s)";
            // 
            // labelMontantRemboursement
            // 
            this.labelMontantRemboursement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMontantRemboursement.AutoSize = true;
            this.labelMontantRemboursement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontantRemboursement.ForeColor = System.Drawing.Color.Red;
            this.labelMontantRemboursement.Location = new System.Drawing.Point(515, 325);
            this.labelMontantRemboursement.Name = "labelMontantRemboursement";
            this.labelMontantRemboursement.Size = new System.Drawing.Size(18, 20);
            this.labelMontantRemboursement.TabIndex = 6;
            this.labelMontantRemboursement.Text = "€";
            this.labelMontantRemboursement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(194, 38);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(158, 26);
            this.textBoxNom.TabIndex = 7;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // textBoxCapitalEmprunte
            // 
            this.textBoxCapitalEmprunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCapitalEmprunte.Location = new System.Drawing.Point(194, 97);
            this.textBoxCapitalEmprunte.Name = "textBoxCapitalEmprunte";
            this.textBoxCapitalEmprunte.Size = new System.Drawing.Size(158, 26);
            this.textBoxCapitalEmprunte.TabIndex = 8;
            this.textBoxCapitalEmprunte.TextChanged += new System.EventHandler(this.textBoxCapitalEmprunte_TextChanged);
            // 
            // groupBoxTauxInteret
            // 
            this.groupBoxTauxInteret.Controls.Add(this.radioButton9pourcent);
            this.groupBoxTauxInteret.Controls.Add(this.radioButton8pourcent);
            this.groupBoxTauxInteret.Controls.Add(this.radioButton7pourcent);
            this.groupBoxTauxInteret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTauxInteret.Location = new System.Drawing.Point(485, 28);
            this.groupBoxTauxInteret.Name = "groupBoxTauxInteret";
            this.groupBoxTauxInteret.Size = new System.Drawing.Size(119, 180);
            this.groupBoxTauxInteret.TabIndex = 9;
            this.groupBoxTauxInteret.TabStop = false;
            this.groupBoxTauxInteret.Text = "Taux d\'intérêt";
            // 
            // radioButton9pourcent
            // 
            this.radioButton9pourcent.AutoSize = true;
            this.radioButton9pourcent.Location = new System.Drawing.Point(34, 134);
            this.radioButton9pourcent.Name = "radioButton9pourcent";
            this.radioButton9pourcent.Size = new System.Drawing.Size(50, 24);
            this.radioButton9pourcent.TabIndex = 2;
            this.radioButton9pourcent.TabStop = true;
            this.radioButton9pourcent.Tag = "9";
            this.radioButton9pourcent.Text = "9%";
            this.radioButton9pourcent.UseVisualStyleBackColor = true;
            this.radioButton9pourcent.CheckedChanged += new System.EventHandler(this.radioButtonTaux_CheckedChanged);
            // 
            // radioButton8pourcent
            // 
            this.radioButton8pourcent.AutoSize = true;
            this.radioButton8pourcent.Location = new System.Drawing.Point(34, 90);
            this.radioButton8pourcent.Name = "radioButton8pourcent";
            this.radioButton8pourcent.Size = new System.Drawing.Size(50, 24);
            this.radioButton8pourcent.TabIndex = 1;
            this.radioButton8pourcent.TabStop = true;
            this.radioButton8pourcent.Tag = "8";
            this.radioButton8pourcent.Text = "8%";
            this.radioButton8pourcent.UseVisualStyleBackColor = true;
            this.radioButton8pourcent.CheckedChanged += new System.EventHandler(this.radioButtonTaux_CheckedChanged);
            // 
            // radioButton7pourcent
            // 
            this.radioButton7pourcent.AutoSize = true;
            this.radioButton7pourcent.Location = new System.Drawing.Point(34, 44);
            this.radioButton7pourcent.Name = "radioButton7pourcent";
            this.radioButton7pourcent.Size = new System.Drawing.Size(50, 24);
            this.radioButton7pourcent.TabIndex = 0;
            this.radioButton7pourcent.TabStop = true;
            this.radioButton7pourcent.Tag = "7";
            this.radioButton7pourcent.Text = "7%";
            this.radioButton7pourcent.UseVisualStyleBackColor = true;
            this.radioButton7pourcent.CheckedChanged += new System.EventHandler(this.radioButtonTaux_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.AutoSize = true;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(666, 62);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(87, 34);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.AutoSize = true;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(666, 118);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(87, 34);
            this.buttonAnnuler.TabIndex = 11;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // listBoxPeriodicite
            // 
            this.listBoxPeriodicite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPeriodicite.FormattingEnabled = true;
            this.listBoxPeriodicite.ItemHeight = 20;
            this.listBoxPeriodicite.Location = new System.Drawing.Point(37, 298);
            this.listBoxPeriodicite.Name = "listBoxPeriodicite";
            this.listBoxPeriodicite.Size = new System.Drawing.Size(216, 104);
            this.listBoxPeriodicite.TabIndex = 12;
            this.listBoxPeriodicite.SelectedIndexChanged += new System.EventHandler(this.listBoxPeriodicite_SelectedIndexChanged);
            // 
            // hScrollBarDuree
            // 
            this.hScrollBarDuree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hScrollBarDuree.LargeChange = 1;
            this.hScrollBarDuree.Location = new System.Drawing.Point(244, 190);
            this.hScrollBarDuree.Maximum = 180;
            this.hScrollBarDuree.Minimum = 1;
            this.hScrollBarDuree.Name = "hScrollBarDuree";
            this.hScrollBarDuree.Size = new System.Drawing.Size(200, 25);
            this.hScrollBarDuree.TabIndex = 13;
            this.hScrollBarDuree.Value = 1;
            this.hScrollBarDuree.ValueChanged += new System.EventHandler(this.hScrollBarDuree_ValueChanged);
            // 
            // labelDureeChoisie
            // 
            this.labelDureeChoisie.AutoSize = true;
            this.labelDureeChoisie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDureeChoisie.Location = new System.Drawing.Point(202, 192);
            this.labelDureeChoisie.Name = "labelDureeChoisie";
            this.labelDureeChoisie.Size = new System.Drawing.Size(18, 20);
            this.labelDureeChoisie.TabIndex = 14;
            this.labelDureeChoisie.Text = "1";
            // 
            // errorProviderNom
            // 
            this.errorProviderNom.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderNom.ContainerControl = this;
            // 
            // errorProviderCapital
            // 
            this.errorProviderCapital.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCapital.ContainerControl = this;
            // 
            // FormEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDureeChoisie);
            this.Controls.Add(this.hScrollBarDuree);
            this.Controls.Add(this.listBoxPeriodicite);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxTauxInteret);
            this.Controls.Add(this.textBoxCapitalEmprunte);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelMontantRemboursement);
            this.Controls.Add(this.labelRemboursements);
            this.Controls.Add(this.labelNbRemboursement);
            this.Controls.Add(this.labelPeriodiciteRemboursement);
            this.Controls.Add(this.labelDureeMoisRemboursement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNom);
            this.Name = "FormEmprunt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprunts";
            this.groupBoxTauxInteret.ResumeLayout(false);
            this.groupBoxTauxInteret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCapital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDureeMoisRemboursement;
        private System.Windows.Forms.Label labelPeriodiciteRemboursement;
        private System.Windows.Forms.Label labelNbRemboursement;
        private System.Windows.Forms.Label labelRemboursements;
        private System.Windows.Forms.Label labelMontantRemboursement;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCapitalEmprunte;
        private System.Windows.Forms.GroupBox groupBoxTauxInteret;
        private System.Windows.Forms.RadioButton radioButton9pourcent;
        private System.Windows.Forms.RadioButton radioButton8pourcent;
        private System.Windows.Forms.RadioButton radioButton7pourcent;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.ListBox listBoxPeriodicite;
        private System.Windows.Forms.HScrollBar hScrollBarDuree;
        private System.Windows.Forms.Label labelDureeChoisie;
        private System.Windows.Forms.ErrorProvider errorProviderNom;
        private System.Windows.Forms.ErrorProvider errorProviderCapital;
    }
}

