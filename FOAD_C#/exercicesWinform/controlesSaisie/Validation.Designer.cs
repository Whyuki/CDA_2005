namespace controlesSaisie
{
    partial class Validation
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMontant = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.validNom = new System.Windows.Forms.Label();
            this.validDate = new System.Windows.Forms.Label();
            this.validMontant = new System.Windows.Forms.Label();
            this.validCP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(77, 157);
            this.buttonOk.MaximumSize = new System.Drawing.Size(94, 30);
            this.buttonOk.MinimumSize = new System.Drawing.Size(94, 30);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 30);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(43, 42);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom :";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(43, 65);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date :";
            // 
            // labelMontant
            // 
            this.labelMontant.AutoSize = true;
            this.labelMontant.Location = new System.Drawing.Point(43, 87);
            this.labelMontant.Name = "labelMontant";
            this.labelMontant.Size = new System.Drawing.Size(52, 13);
            this.labelMontant.TabIndex = 3;
            this.labelMontant.Text = "Montant :";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(43, 109);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(38, 13);
            this.labelCode.TabIndex = 4;
            this.labelCode.Text = "Code :";
            // 
            // validNom
            // 
            this.validNom.AutoSize = true;
            this.validNom.Location = new System.Drawing.Point(99, 42);
            this.validNom.Name = "validNom";
            this.validNom.Size = new System.Drawing.Size(35, 13);
            this.validNom.TabIndex = 5;
            this.validNom.Text = "label5";
            // 
            // validDate
            // 
            this.validDate.AutoSize = true;
            this.validDate.Location = new System.Drawing.Point(99, 65);
            this.validDate.Name = "validDate";
            this.validDate.Size = new System.Drawing.Size(35, 13);
            this.validDate.TabIndex = 6;
            this.validDate.Text = "label6";
            // 
            // validMontant
            // 
            this.validMontant.AutoSize = true;
            this.validMontant.Location = new System.Drawing.Point(99, 87);
            this.validMontant.Name = "validMontant";
            this.validMontant.Size = new System.Drawing.Size(35, 13);
            this.validMontant.TabIndex = 7;
            this.validMontant.Text = "label7";
            // 
            // validCP
            // 
            this.validCP.AutoSize = true;
            this.validCP.Location = new System.Drawing.Point(99, 109);
            this.validCP.Name = "validCP";
            this.validCP.Size = new System.Drawing.Size(35, 13);
            this.validCP.TabIndex = 8;
            this.validCP.Text = "label8";
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 209);
            this.Controls.Add(this.validCP);
            this.Controls.Add(this.validMontant);
            this.Controls.Add(this.validDate);
            this.Controls.Add(this.validNom);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelMontant);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonOk);
            this.Name = "Validation";
            this.Text = "Validation effectuée";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMontant;
        private System.Windows.Forms.Label labelCode;
        public System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label validNom;
        private System.Windows.Forms.Label validDate;
        private System.Windows.Forms.Label validMontant;
        private System.Windows.Forms.Label validCP;


    }


    
}