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
            this.components = new System.ComponentModel.Container();
            this.textBoxVotreTexte = new System.Windows.Forms.TextBox();
            this.tapez_votre_texte = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.errorProviderSaisie = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSaisie)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxVotreTexte
            // 
            this.textBoxVotreTexte.Location = new System.Drawing.Point(22, 43);
            this.textBoxVotreTexte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxVotreTexte.Name = "textBoxVotreTexte";
            this.textBoxVotreTexte.Size = new System.Drawing.Size(319, 26);
            this.textBoxVotreTexte.TabIndex = 3;
            this.textBoxVotreTexte.TextChanged += new System.EventHandler(this.textBoxVotreTexte_TextChanged);
            this.textBoxVotreTexte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVotreTexte_KeyPress);
            // 
            // tapez_votre_texte
            // 
            this.tapez_votre_texte.AutoSize = true;
            this.tapez_votre_texte.Location = new System.Drawing.Point(18, 14);
            this.tapez_votre_texte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tapez_votre_texte.Name = "tapez_votre_texte";
            this.tapez_votre_texte.Size = new System.Drawing.Size(131, 20);
            this.tapez_votre_texte.TabIndex = 2;
            this.tapez_votre_texte.Text = "Tapez votre texte";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(375, 38);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(112, 35);
            this.buttonValider.TabIndex = 4;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // errorProviderSaisie
            // 
            this.errorProviderSaisie.ContainerControl = this;
            // 
            // FormSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 109);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxVotreTexte);
            this.Controls.Add(this.tapez_votre_texte);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSaisie";
            this.Text = "Saisie";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSaisie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVotreTexte;
        private System.Windows.Forms.Label tapez_votre_texte;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.ErrorProvider errorProviderSaisie;
    }
}