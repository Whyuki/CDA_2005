namespace ClassLibraryUserControlToutEmbal
{
    partial class ucEtatProd
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxEtat = new System.Windows.Forms.TextBox();
            this.labelEtatNomProd = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.textBoxEtat, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelEtatNomProd, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 26);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // textBoxEtat
            // 
            this.textBoxEtat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxEtat.Enabled = false;
            this.textBoxEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEtat.Location = new System.Drawing.Point(53, 3);
            this.textBoxEtat.Name = "textBoxEtat";
            this.textBoxEtat.ReadOnly = true;
            this.textBoxEtat.Size = new System.Drawing.Size(91, 20);
            this.textBoxEtat.TabIndex = 2;
            // 
            // labelEtatNomProd
            // 
            this.labelEtatNomProd.AutoSize = true;
            this.labelEtatNomProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEtatNomProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtatNomProd.Location = new System.Drawing.Point(3, 0);
            this.labelEtatNomProd.Name = "labelEtatNomProd";
            this.labelEtatNomProd.Size = new System.Drawing.Size(44, 26);
            this.labelEtatNomProd.TabIndex = 0;
            this.labelEtatNomProd.Text = "Caisse";
            this.labelEtatNomProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucEtatProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucEtatProd";
            this.Size = new System.Drawing.Size(193, 31);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxEtat;
        private System.Windows.Forms.Label labelEtatNomProd;
    }
}
