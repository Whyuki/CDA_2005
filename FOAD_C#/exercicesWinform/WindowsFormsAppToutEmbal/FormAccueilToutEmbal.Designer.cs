namespace WindowsFormsAppToutEmbal
{
    partial class FormAccueilToutEmbal
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
            this.buttonDemo = new System.Windows.Forms.Button();
            this.buttonExo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDemo
            // 
            this.buttonDemo.AutoSize = true;
            this.buttonDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDemo.Location = new System.Drawing.Point(86, 29);
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.Size = new System.Drawing.Size(140, 49);
            this.buttonDemo.TabIndex = 0;
            this.buttonDemo.Text = "DEMO";
            this.buttonDemo.UseVisualStyleBackColor = true;
            this.buttonDemo.Click += new System.EventHandler(this.buttonDemo_Click);
            // 
            // buttonExo
            // 
            this.buttonExo.AutoSize = true;
            this.buttonExo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExo.Location = new System.Drawing.Point(55, 103);
            this.buttonExo.Name = "buttonExo";
            this.buttonExo.Size = new System.Drawing.Size(204, 49);
            this.buttonExo.TabIndex = 1;
            this.buttonExo.Text = "EXERCICE";
            this.buttonExo.UseVisualStyleBackColor = true;
            this.buttonExo.Click += new System.EventHandler(this.buttonExo_Click);
            // 
            // FormAccueilToutEmbal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 195);
            this.Controls.Add(this.buttonExo);
            this.Controls.Add(this.buttonDemo);
            this.Name = "FormAccueilToutEmbal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToutEmbal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDemo;
        private System.Windows.Forms.Button buttonExo;
    }
}