namespace ClassLibraryUserControlToutEmbal
{
    partial class ucBoutons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBoutons));
            this.buttonDemarrer = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonContinuer = new System.Windows.Forms.Button();
            this.textBoxBoutonsNomProd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDemarrer
            // 
            this.buttonDemarrer.AutoSize = true;
            this.buttonDemarrer.Image = ((System.Drawing.Image)(resources.GetObject("buttonDemarrer.Image")));
            this.buttonDemarrer.Location = new System.Drawing.Point(3, 3);
            this.buttonDemarrer.Name = "buttonDemarrer";
            this.buttonDemarrer.Size = new System.Drawing.Size(39, 85);
            this.buttonDemarrer.TabIndex = 0;
            this.buttonDemarrer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDemarrer.UseVisualStyleBackColor = true;
            // 
            // buttonPause
            // 
            this.buttonPause.AutoSize = true;
            this.buttonPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPause.Image")));
            this.buttonPause.Location = new System.Drawing.Point(48, 3);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(39, 85);
            this.buttonPause.TabIndex = 3;
            this.buttonPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // buttonContinuer
            // 
            this.buttonContinuer.AutoSize = true;
            this.buttonContinuer.Image = ((System.Drawing.Image)(resources.GetObject("buttonContinuer.Image")));
            this.buttonContinuer.Location = new System.Drawing.Point(93, 3);
            this.buttonContinuer.Name = "buttonContinuer";
            this.buttonContinuer.Size = new System.Drawing.Size(39, 85);
            this.buttonContinuer.TabIndex = 4;
            this.buttonContinuer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonContinuer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonContinuer.UseVisualStyleBackColor = true;
            // 
            // textBoxBoutonsNomProd
            // 
            this.textBoxBoutonsNomProd.Enabled = false;
            this.textBoxBoutonsNomProd.Location = new System.Drawing.Point(3, 94);
            this.textBoxBoutonsNomProd.Name = "textBoxBoutonsNomProd";
            this.textBoxBoutonsNomProd.Size = new System.Drawing.Size(129, 20);
            this.textBoxBoutonsNomProd.TabIndex = 5;
            this.textBoxBoutonsNomProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxBoutonsNomProd);
            this.Controls.Add(this.buttonContinuer);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonDemarrer);
            this.Name = "ucActions";
            this.Size = new System.Drawing.Size(139, 121);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDemarrer;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonContinuer;
        private System.Windows.Forms.TextBox textBoxBoutonsNomProd;
    }
}
