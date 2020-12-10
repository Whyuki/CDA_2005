
namespace WindowsFormsAppPapyrus
{
    partial class FormRechercheFournisseur
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
            this.labelCodeFournisseur = new System.Windows.Forms.Label();
            this.textBoxCodeFournisseur = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.errorProviderCodeFournisseurIntrouvable = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodeFournisseurIntrouvable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodeFournisseur
            // 
            this.labelCodeFournisseur.AutoSize = true;
            this.labelCodeFournisseur.Location = new System.Drawing.Point(74, 18);
            this.labelCodeFournisseur.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCodeFournisseur.Name = "labelCodeFournisseur";
            this.labelCodeFournisseur.Size = new System.Drawing.Size(161, 25);
            this.labelCodeFournisseur.TabIndex = 0;
            this.labelCodeFournisseur.Text = "Code fournisseur";
            this.labelCodeFournisseur.Click += new System.EventHandler(this.labelCodeFournisseur_Click);
            // 
            // textBoxCodeFournisseur
            // 
            this.textBoxCodeFournisseur.Location = new System.Drawing.Point(285, 15);
            this.textBoxCodeFournisseur.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxCodeFournisseur.Name = "textBoxCodeFournisseur";
            this.textBoxCodeFournisseur.Size = new System.Drawing.Size(97, 30);
            this.textBoxCodeFournisseur.TabIndex = 1;
            this.textBoxCodeFournisseur.TextChanged += new System.EventHandler(this.textBoxFournisseur_TextChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(60, 73);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(149, 44);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(259, 73);
            this.buttonQuitter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(149, 44);
            this.buttonQuitter.TabIndex = 3;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // errorProviderCodeFournisseurIntrouvable
            // 
            this.errorProviderCodeFournisseurIntrouvable.ContainerControl = this;
            // 
            // FormRechercheFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 132);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxCodeFournisseur);
            this.Controls.Add(this.labelCodeFournisseur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormRechercheFournisseur";
            this.Text = "Affichage Fournisseur";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodeFournisseurIntrouvable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodeFournisseur;
        private System.Windows.Forms.TextBox textBoxCodeFournisseur;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.ErrorProvider errorProviderCodeFournisseurIntrouvable;
    }
}