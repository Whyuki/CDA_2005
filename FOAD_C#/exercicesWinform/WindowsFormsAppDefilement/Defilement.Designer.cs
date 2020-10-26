namespace WindowsFormsAppDefilement
{
    partial class Defilement
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
            this.hScrollBarRouge = new System.Windows.Forms.HScrollBar();
            this.numericUpDownRouge = new System.Windows.Forms.NumericUpDown();
            this.textBoxRouge = new System.Windows.Forms.TextBox();
            this.labelRouge = new System.Windows.Forms.Label();
            this.labelVert = new System.Windows.Forms.Label();
            this.textBoxVert = new System.Windows.Forms.TextBox();
            this.numericUpDownVert = new System.Windows.Forms.NumericUpDown();
            this.hScrollBarVert = new System.Windows.Forms.HScrollBar();
            this.labelBleu = new System.Windows.Forms.Label();
            this.textBoxBleu = new System.Windows.Forms.TextBox();
            this.numericUpDownBleu = new System.Windows.Forms.NumericUpDown();
            this.hScrollBarBleu = new System.Windows.Forms.HScrollBar();
            this.textBoxCouleurChoisie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBarRouge
            // 
            this.hScrollBarRouge.LargeChange = 1;
            this.hScrollBarRouge.Location = new System.Drawing.Point(86, 14);
            this.hScrollBarRouge.Maximum = 255;
            this.hScrollBarRouge.Name = "hScrollBarRouge";
            this.hScrollBarRouge.Size = new System.Drawing.Size(252, 20);
            this.hScrollBarRouge.TabIndex = 0;
            this.hScrollBarRouge.ValueChanged += new System.EventHandler(this.hScrollBarRouge_ValueChanged);
            // 
            // numericUpDownRouge
            // 
            this.numericUpDownRouge.Location = new System.Drawing.Point(343, 12);
            this.numericUpDownRouge.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numericUpDownRouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRouge.Name = "numericUpDownRouge";
            this.numericUpDownRouge.Size = new System.Drawing.Size(82, 26);
            this.numericUpDownRouge.TabIndex = 1;
            this.numericUpDownRouge.ValueChanged += new System.EventHandler(this.numericUpDownRouge_ValueChanged);
            // 
            // textBoxRouge
            // 
            this.textBoxRouge.BackColor = System.Drawing.Color.Red;
            this.textBoxRouge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRouge.Enabled = false;
            this.textBoxRouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRouge.Location = new System.Drawing.Point(435, 14);
            this.textBoxRouge.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxRouge.Name = "textBoxRouge";
            this.textBoxRouge.Size = new System.Drawing.Size(62, 23);
            this.textBoxRouge.TabIndex = 2;
            // 
            // labelRouge
            // 
            this.labelRouge.AutoSize = true;
            this.labelRouge.Location = new System.Drawing.Point(18, 14);
            this.labelRouge.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRouge.Name = "labelRouge";
            this.labelRouge.Size = new System.Drawing.Size(57, 20);
            this.labelRouge.TabIndex = 3;
            this.labelRouge.Text = "Rouge";
            // 
            // labelVert
            // 
            this.labelVert.AutoSize = true;
            this.labelVert.Location = new System.Drawing.Point(20, 55);
            this.labelVert.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVert.Name = "labelVert";
            this.labelVert.Size = new System.Drawing.Size(39, 20);
            this.labelVert.TabIndex = 7;
            this.labelVert.Text = "Vert";
            // 
            // textBoxVert
            // 
            this.textBoxVert.BackColor = System.Drawing.Color.Green;
            this.textBoxVert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVert.Enabled = false;
            this.textBoxVert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVert.Location = new System.Drawing.Point(435, 56);
            this.textBoxVert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxVert.Name = "textBoxVert";
            this.textBoxVert.Size = new System.Drawing.Size(62, 23);
            this.textBoxVert.TabIndex = 6;
            // 
            // numericUpDownVert
            // 
            this.numericUpDownVert.Location = new System.Drawing.Point(343, 53);
            this.numericUpDownVert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numericUpDownVert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownVert.Name = "numericUpDownVert";
            this.numericUpDownVert.Size = new System.Drawing.Size(82, 26);
            this.numericUpDownVert.TabIndex = 5;
            this.numericUpDownVert.ValueChanged += new System.EventHandler(this.numericUpDownVert_ValueChanged);
            // 
            // hScrollBarVert
            // 
            this.hScrollBarVert.LargeChange = 1;
            this.hScrollBarVert.Location = new System.Drawing.Point(86, 55);
            this.hScrollBarVert.Maximum = 255;
            this.hScrollBarVert.Name = "hScrollBarVert";
            this.hScrollBarVert.Size = new System.Drawing.Size(252, 20);
            this.hScrollBarVert.TabIndex = 4;
            this.hScrollBarVert.ValueChanged += new System.EventHandler(this.hScrollBarVert_ValueChanged);
            // 
            // labelBleu
            // 
            this.labelBleu.AutoSize = true;
            this.labelBleu.Location = new System.Drawing.Point(20, 108);
            this.labelBleu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelBleu.Name = "labelBleu";
            this.labelBleu.Size = new System.Drawing.Size(41, 20);
            this.labelBleu.TabIndex = 11;
            this.labelBleu.Text = "Bleu";
            // 
            // textBoxBleu
            // 
            this.textBoxBleu.BackColor = System.Drawing.Color.Blue;
            this.textBoxBleu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBleu.Enabled = false;
            this.textBoxBleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBleu.Location = new System.Drawing.Point(435, 108);
            this.textBoxBleu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxBleu.Name = "textBoxBleu";
            this.textBoxBleu.Size = new System.Drawing.Size(62, 23);
            this.textBoxBleu.TabIndex = 10;
            // 
            // numericUpDownBleu
            // 
            this.numericUpDownBleu.Location = new System.Drawing.Point(343, 106);
            this.numericUpDownBleu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numericUpDownBleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBleu.Name = "numericUpDownBleu";
            this.numericUpDownBleu.Size = new System.Drawing.Size(82, 26);
            this.numericUpDownBleu.TabIndex = 9;
            this.numericUpDownBleu.ValueChanged += new System.EventHandler(this.numericUpDownBleu_ValueChanged);
            // 
            // hScrollBarBleu
            // 
            this.hScrollBarBleu.LargeChange = 1;
            this.hScrollBarBleu.Location = new System.Drawing.Point(86, 108);
            this.hScrollBarBleu.Maximum = 255;
            this.hScrollBarBleu.Name = "hScrollBarBleu";
            this.hScrollBarBleu.Size = new System.Drawing.Size(252, 20);
            this.hScrollBarBleu.TabIndex = 8;
            this.hScrollBarBleu.ValueChanged += new System.EventHandler(this.hScrollBarBleu_ValueChanged);
            // 
            // textBoxCouleurChoisie
            // 
            this.textBoxCouleurChoisie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCouleurChoisie.Enabled = false;
            this.textBoxCouleurChoisie.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCouleurChoisie.Location = new System.Drawing.Point(22, 154);
            this.textBoxCouleurChoisie.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxCouleurChoisie.Name = "textBoxCouleurChoisie";
            this.textBoxCouleurChoisie.Size = new System.Drawing.Size(475, 121);
            this.textBoxCouleurChoisie.TabIndex = 12;
            // 
            // Defilement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 303);
            this.Controls.Add(this.textBoxCouleurChoisie);
            this.Controls.Add(this.labelBleu);
            this.Controls.Add(this.textBoxBleu);
            this.Controls.Add(this.numericUpDownBleu);
            this.Controls.Add(this.hScrollBarBleu);
            this.Controls.Add(this.labelVert);
            this.Controls.Add(this.textBoxVert);
            this.Controls.Add(this.numericUpDownVert);
            this.Controls.Add(this.hScrollBarVert);
            this.Controls.Add(this.labelRouge);
            this.Controls.Add(this.textBoxRouge);
            this.Controls.Add(this.numericUpDownRouge);
            this.Controls.Add(this.hScrollBarRouge);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Defilement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defilement";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBleu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBarRouge;
        private System.Windows.Forms.NumericUpDown numericUpDownRouge;
        private System.Windows.Forms.TextBox textBoxRouge;
        private System.Windows.Forms.Label labelRouge;
        private System.Windows.Forms.Label labelVert;
        private System.Windows.Forms.TextBox textBoxVert;
        private System.Windows.Forms.NumericUpDown numericUpDownVert;
        private System.Windows.Forms.HScrollBar hScrollBarVert;
        private System.Windows.Forms.Label labelBleu;
        private System.Windows.Forms.TextBox textBoxBleu;
        private System.Windows.Forms.NumericUpDown numericUpDownBleu;
        private System.Windows.Forms.HScrollBar hScrollBarBleu;
        private System.Windows.Forms.TextBox textBoxCouleurChoisie;
    }
}

