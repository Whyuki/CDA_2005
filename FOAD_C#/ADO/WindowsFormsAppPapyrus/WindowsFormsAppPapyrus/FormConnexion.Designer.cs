
namespace WindowsFormsAppPapyrus
{
    partial class FormConnexion
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
            this.labelServeur = new System.Windows.Forms.Label();
            this.textBoxServeur = new System.Windows.Forms.TextBox();
            this.textBoxBdd = new System.Windows.Forms.TextBox();
            this.labelBdd = new System.Windows.Forms.Label();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.labelEtatConnexion = new System.Windows.Forms.Label();
            this.labelOpenClosed = new System.Windows.Forms.Label();
            this.richTextBoxMessageErreurConnexion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelServeur
            // 
            this.labelServeur.AutoSize = true;
            this.labelServeur.Location = new System.Drawing.Point(53, 55);
            this.labelServeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServeur.Name = "labelServeur";
            this.labelServeur.Size = new System.Drawing.Size(72, 20);
            this.labelServeur.TabIndex = 0;
            this.labelServeur.Text = "Serveur :";
            // 
            // textBoxServeur
            // 
            this.textBoxServeur.Location = new System.Drawing.Point(210, 52);
            this.textBoxServeur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxServeur.Name = "textBoxServeur";
            this.textBoxServeur.Size = new System.Drawing.Size(224, 26);
            this.textBoxServeur.TabIndex = 1;
            this.textBoxServeur.TextChanged += new System.EventHandler(this.textBoxServeur_TextChanged);
            // 
            // textBoxBdd
            // 
            this.textBoxBdd.Location = new System.Drawing.Point(210, 118);
            this.textBoxBdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBdd.Name = "textBoxBdd";
            this.textBoxBdd.Size = new System.Drawing.Size(224, 26);
            this.textBoxBdd.TabIndex = 3;
            this.textBoxBdd.TextChanged += new System.EventHandler(this.textBoxBdd_TextChanged);
            // 
            // labelBdd
            // 
            this.labelBdd.AutoSize = true;
            this.labelBdd.Location = new System.Drawing.Point(50, 121);
            this.labelBdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBdd.Name = "labelBdd";
            this.labelBdd.Size = new System.Drawing.Size(142, 20);
            this.labelBdd.TabIndex = 2;
            this.labelBdd.Text = "Base de données :";
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(57, 188);
            this.buttonConnexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(112, 35);
            this.buttonConnexion.TabIndex = 4;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Enabled = false;
            this.buttonDeconnexion.Location = new System.Drawing.Point(286, 188);
            this.buttonDeconnexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(130, 35);
            this.buttonDeconnexion.TabIndex = 5;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(286, 232);
            this.buttonQuitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(130, 35);
            this.buttonQuitter.TabIndex = 6;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // labelEtatConnexion
            // 
            this.labelEtatConnexion.AutoSize = true;
            this.labelEtatConnexion.Location = new System.Drawing.Point(52, 286);
            this.labelEtatConnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEtatConnexion.Name = "labelEtatConnexion";
            this.labelEtatConnexion.Size = new System.Drawing.Size(153, 20);
            this.labelEtatConnexion.TabIndex = 7;
            this.labelEtatConnexion.Text = "Etat de la connexion";
            // 
            // labelOpenClosed
            // 
            this.labelOpenClosed.AutoSize = true;
            this.labelOpenClosed.Location = new System.Drawing.Point(285, 286);
            this.labelOpenClosed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOpenClosed.Name = "labelOpenClosed";
            this.labelOpenClosed.Size = new System.Drawing.Size(0, 20);
            this.labelOpenClosed.TabIndex = 8;
            // 
            // richTextBoxMessageErreurConnexion
            // 
            this.richTextBoxMessageErreurConnexion.Location = new System.Drawing.Point(54, 311);
            this.richTextBoxMessageErreurConnexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxMessageErreurConnexion.Name = "richTextBoxMessageErreurConnexion";
            this.richTextBoxMessageErreurConnexion.Size = new System.Drawing.Size(380, 150);
            this.richTextBoxMessageErreurConnexion.TabIndex = 9;
            this.richTextBoxMessageErreurConnexion.Text = "";
            this.richTextBoxMessageErreurConnexion.Visible = false;
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 494);
            this.Controls.Add(this.richTextBoxMessageErreurConnexion);
            this.Controls.Add(this.labelOpenClosed);
            this.Controls.Add(this.labelEtatConnexion);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.textBoxBdd);
            this.Controls.Add(this.labelBdd);
            this.Controls.Add(this.textBoxServeur);
            this.Controls.Add(this.labelServeur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion à la base de données";
            this.Load += new System.EventHandler(this.FormConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServeur;
        private System.Windows.Forms.TextBox textBoxServeur;
        private System.Windows.Forms.TextBox textBoxBdd;
        private System.Windows.Forms.Label labelBdd;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Label labelEtatConnexion;
        private System.Windows.Forms.Label labelOpenClosed;
        private System.Windows.Forms.RichTextBox richTextBoxMessageErreurConnexion;
    }
}

