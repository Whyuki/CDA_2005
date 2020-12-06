namespace ClassLibraryUserControlToutEmbal
{
    partial class ucProgressBar
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBarProdA = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarProdA
            // 
            this.progressBarProdA.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBarProdA.Location = new System.Drawing.Point(212, 4);
            this.progressBarProdA.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarProdA.Name = "progressBarProdA";
            this.progressBarProdA.Size = new System.Drawing.Size(294, 30);
            this.progressBarProdA.TabIndex = 9;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoEllipsis = true;
            this.labelProgress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelProgress.Location = new System.Drawing.Point(6, 8);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(198, 24);
            this.labelProgress.TabIndex = 8;
            this.labelProgress.Text = "Production A";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBarProdA);
            this.Controls.Add(this.labelProgress);
            this.Name = "ucProgressBar";
            this.Size = new System.Drawing.Size(513, 38);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarProdA;
        private System.Windows.Forms.Label labelProgress;
    }
}
