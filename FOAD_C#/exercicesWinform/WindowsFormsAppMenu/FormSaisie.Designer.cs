namespace WindowsFormsAppMenu
{
    partial class FormSaisie
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
            this.textBoxVotreTexte = new System.Windows.Forms.TextBox();
            this.tapez_votre_texte = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxVotreTexte
            // 
            this.textBoxVotreTexte.Location = new System.Drawing.Point(15, 28);
            this.textBoxVotreTexte.Name = "textBoxVotreTexte";
            this.textBoxVotreTexte.Size = new System.Drawing.Size(214, 20);
            this.textBoxVotreTexte.TabIndex = 3;
            // 
            // tapez_votre_texte
            // 
            this.tapez_votre_texte.AutoSize = true;
            this.tapez_votre_texte.Location = new System.Drawing.Point(12, 9);
            this.tapez_votre_texte.Name = "tapez_votre_texte";
            this.tapez_votre_texte.Size = new System.Drawing.Size(90, 13);
            this.tapez_votre_texte.TabIndex = 2;
            this.tapez_votre_texte.Text = "Tapez votre texte";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(250, 25);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 4;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // FormSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 71);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxVotreTexte);
            this.Controls.Add(this.tapez_votre_texte);
            this.Name = "FormSaisie";
            this.Text = "Saisie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVotreTexte;
        private System.Windows.Forms.Label tapez_votre_texte;
        private System.Windows.Forms.Button buttonValider;
    }
}