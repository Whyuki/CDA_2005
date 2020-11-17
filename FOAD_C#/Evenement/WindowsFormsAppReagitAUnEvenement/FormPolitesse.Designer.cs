namespace WindowsFormsAppReagitAUnEvenement
{
    partial class FormPolitesse
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userControlDisBonjour3 = new WindowsFormsControlLibrary.UserControlDisBonjour();
            this.userControlDisBonjour2 = new WindowsFormsControlLibrary.UserControlDisBonjour();
            this.userControlDisBonjour1 = new WindowsFormsControlLibrary.UserControlDisBonjour();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // userControlDisBonjour3
            // 
            this.userControlDisBonjour3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControlDisBonjour3.Location = new System.Drawing.Point(65, 198);
            this.userControlDisBonjour3.Name = "userControlDisBonjour3";
            this.userControlDisBonjour3.NomSurLequelIlFautReagir = "Loulou";
            this.userControlDisBonjour3.Size = new System.Drawing.Size(347, 124);
            this.userControlDisBonjour3.TabIndex = 4;
            // 
            // userControlDisBonjour2
            // 
            this.userControlDisBonjour2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControlDisBonjour2.Location = new System.Drawing.Point(430, 282);
            this.userControlDisBonjour2.Name = "userControlDisBonjour2";
            this.userControlDisBonjour2.NomSurLequelIlFautReagir = "Fifi";
            this.userControlDisBonjour2.Size = new System.Drawing.Size(347, 124);
            this.userControlDisBonjour2.TabIndex = 3;
            // 
            // userControlDisBonjour1
            // 
            this.userControlDisBonjour1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControlDisBonjour1.Location = new System.Drawing.Point(409, 48);
            this.userControlDisBonjour1.Name = "userControlDisBonjour1";
            this.userControlDisBonjour1.NomSurLequelIlFautReagir = "Riri";
            this.userControlDisBonjour1.Size = new System.Drawing.Size(347, 124);
            this.userControlDisBonjour1.TabIndex = 2;
            this.userControlDisBonjour1.NomTrouve += new System.EventHandler(this.userControlDisBonjour1_NomTrouve);
            this.userControlDisBonjour1.Load += new System.EventHandler(this.userControlDisBonjour1_Load);
            // 
            // FormPolitesse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlDisBonjour3);
            this.Controls.Add(this.userControlDisBonjour2);
            this.Controls.Add(this.userControlDisBonjour1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormPolitesse";
            this.Text = "FormPolitesse";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormPolitesse_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private WindowsFormsControlLibrary.UserControlDisBonjour userControlDisBonjour1;
        private WindowsFormsControlLibrary.UserControlDisBonjour userControlDisBonjour2;
        private WindowsFormsControlLibrary.UserControlDisBonjour userControlDisBonjour3;
    }
}