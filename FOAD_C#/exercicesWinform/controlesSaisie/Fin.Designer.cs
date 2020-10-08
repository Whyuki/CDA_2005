namespace controlesSaisie
{
    partial class Fin
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
            this.buttonOui = new System.Windows.Forms.Button();
            this.buttonNon = new System.Windows.Forms.Button();
            this.labelFinApp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOui
            // 
            this.buttonOui.Location = new System.Drawing.Point(12, 70);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(74, 22);
            this.buttonOui.TabIndex = 0;
            this.buttonOui.Text = "Oui";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
            // 
            // buttonNon
            // 
            this.buttonNon.Location = new System.Drawing.Point(92, 70);
            this.buttonNon.MaximumSize = new System.Drawing.Size(79, 22);
            this.buttonNon.MinimumSize = new System.Drawing.Size(79, 22);
            this.buttonNon.Name = "buttonNon";
            this.buttonNon.Size = new System.Drawing.Size(79, 22);
            this.buttonNon.TabIndex = 1;
            this.buttonNon.Text = "Non";
            this.buttonNon.UseVisualStyleBackColor = true;
            this.buttonNon.Click += new System.EventHandler(this.buttonNon_Click);
            // 
            // labelFinApp
            // 
            this.labelFinApp.AutoSize = true;
            this.labelFinApp.Location = new System.Drawing.Point(43, 33);
            this.labelFinApp.Name = "labelFinApp";
            this.labelFinApp.Size = new System.Drawing.Size(94, 13);
            this.labelFinApp.TabIndex = 2;
            this.labelFinApp.Text = "Fin de l\'application";
            // 
            // Fin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 115);
            this.Controls.Add(this.labelFinApp);
            this.Controls.Add(this.buttonNon);
            this.Controls.Add(this.buttonOui);
            this.Location = new System.Drawing.Point(30, 30);
            this.Name = "Fin";
            this.Text = "FIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOui;
        private System.Windows.Forms.Button buttonNon;
        private System.Windows.Forms.Label labelFinApp;

    }
}