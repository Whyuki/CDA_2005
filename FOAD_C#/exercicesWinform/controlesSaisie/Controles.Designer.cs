namespace controlesSaisie
{
    partial class Controles
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
            this.textNom = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textMontant = new System.Windows.Forms.TextBox();
            this.textCP = new System.Windows.Forms.TextBox();
            this.valider = new System.Windows.Forms.Button();
            this.effacer = new System.Windows.Forms.Button();
            this.Nom = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.Label();
            this.CodePostal = new System.Windows.Forms.Label();
            this.DateFormat = new System.Windows.Forms.Label();
            this.controlErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.controlErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(105, 33);
            this.textNom.MaxLength = 30;
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(173, 20);
            this.textNom.TabIndex = 0;
            this.textNom.Tag = "Nom";
            this.textNom.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textNom.Validating += new System.ComponentModel.CancelEventHandler(this.textNom_Validating);
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(105, 75);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(124, 20);
            this.textDate.TabIndex = 1;
            this.textDate.Tag = "Date";
            this.textDate.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textDate.Validating += new System.ComponentModel.CancelEventHandler(this.textDate_Validating);
            // 
            // textMontant
            // 
            this.textMontant.Location = new System.Drawing.Point(105, 116);
            this.textMontant.Name = "textMontant";
            this.textMontant.Size = new System.Drawing.Size(124, 20);
            this.textMontant.TabIndex = 2;
            this.textMontant.Tag = "Montant";
            this.textMontant.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textMontant.Validating += new System.ComponentModel.CancelEventHandler(this.textMontant_Validating);
            // 
            // textCP
            // 
            this.textCP.Location = new System.Drawing.Point(105, 159);
            this.textCP.MaxLength = 5;
            this.textCP.Name = "textCP";
            this.textCP.Size = new System.Drawing.Size(100, 20);
            this.textCP.TabIndex = 3;
            this.textCP.Tag = "Code postal";
            this.textCP.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textCP.Validating += new System.ComponentModel.CancelEventHandler(this.textCP_Validating);
            // 
            // valider
            // 
            this.valider.Enabled = false;
            this.valider.Location = new System.Drawing.Point(282, 191);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(83, 24);
            this.valider.TabIndex = 4;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // effacer
            // 
            this.effacer.Location = new System.Drawing.Point(282, 221);
            this.effacer.Name = "effacer";
            this.effacer.Size = new System.Drawing.Size(83, 24);
            this.effacer.TabIndex = 5;
            this.effacer.Text = "Effacer";
            this.effacer.UseVisualStyleBackColor = true;
            this.effacer.Click += new System.EventHandler(this.effacer_Click);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(32, 36);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 6;
            this.Nom.Text = "Nom";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(32, 78);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 7;
            this.Date.Text = "Date";
            // 
            // Montant
            // 
            this.Montant.AutoSize = true;
            this.Montant.Location = new System.Drawing.Point(32, 123);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(46, 13);
            this.Montant.TabIndex = 8;
            this.Montant.Text = "Montant";
            // 
            // CodePostal
            // 
            this.CodePostal.AutoSize = true;
            this.CodePostal.Location = new System.Drawing.Point(32, 162);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(64, 13);
            this.CodePostal.TabIndex = 9;
            this.CodePostal.Text = "Code Postal";
            // 
            // DateFormat
            // 
            this.DateFormat.AutoSize = true;
            this.DateFormat.Location = new System.Drawing.Point(249, 78);
            this.DateFormat.Name = "DateFormat";
            this.DateFormat.Size = new System.Drawing.Size(79, 13);
            this.DateFormat.TabIndex = 10;
            this.DateFormat.Text = "(JJ/MM/AAAA)";
            // 
            // controlErrorProvider
            // 
            this.controlErrorProvider.ContainerControl = this;
            // 
            // Controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.DateFormat);
            this.Controls.Add(this.CodePostal);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.effacer);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.textCP);
            this.Controls.Add(this.textMontant);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Controles";
            this.Text = "Les contrôles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.controle_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.controlErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button effacer;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Montant;
        private System.Windows.Forms.Label CodePostal;
        private System.Windows.Forms.Label DateFormat;
        public System.Windows.Forms.TextBox textDate;
        public System.Windows.Forms.TextBox textMontant;
        public System.Windows.Forms.TextBox textCP;
        public System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.ErrorProvider controlErrorProvider;
    }
}

