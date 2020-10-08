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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxMontant = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.valider = new System.Windows.Forms.Button();
            this.effacer = new System.Windows.Forms.Button();
            this.Nom = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.Label();
            this.CodePostal = new System.Windows.Forms.Label();
            this.Date2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(105, 33);
            this.textBoxNom.MaxLength = 30;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(173, 20);
            this.textBoxNom.TabIndex = 0;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(105, 75);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(124, 20);
            this.textBoxDate.TabIndex = 1;
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxMontant
            // 
            this.textBoxMontant.Location = new System.Drawing.Point(105, 116);
            this.textBoxMontant.Name = "textBoxMontant";
            this.textBoxMontant.Size = new System.Drawing.Size(124, 20);
            this.textBoxMontant.TabIndex = 2;
            this.textBoxMontant.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(105, 159);
            this.textBoxCP.MaxLength = 5;
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(100, 20);
            this.textBoxCP.TabIndex = 3;
            this.textBoxCP.TextChanged += new System.EventHandler(this.textBox_TextChanged);
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
            // Date2
            // 
            this.Date2.AutoSize = true;
            this.Date2.Location = new System.Drawing.Point(249, 78);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(79, 13);
            this.Date2.TabIndex = 10;
            this.Date2.Text = "(JJ/MM/AAAA)";
            // 
            // Controles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.Date2);
            this.Controls.Add(this.CodePostal);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.effacer);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxMontant);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxNom);
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Controles";
            this.Text = "Les contrôles";
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
        private System.Windows.Forms.Label Date2;
        public System.Windows.Forms.TextBox textBoxDate;
        public System.Windows.Forms.TextBox textBoxMontant;
        public System.Windows.Forms.TextBox textBoxCP;
        public System.Windows.Forms.TextBox textBoxNom;



    }
}

