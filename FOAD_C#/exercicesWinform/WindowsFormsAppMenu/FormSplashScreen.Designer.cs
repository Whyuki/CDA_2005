namespace WindowsFormsAppMenu
{
    partial class FormSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplashScreen));
            this.timerSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.progressBarSplashScreen = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // timerSplashScreen
            // 
            this.timerSplashScreen.Interval = 250;
            this.timerSplashScreen.Tick += new System.EventHandler(this.timerSplashScreen_Tick);
            // 
            // progressBarSplashScreen
            // 
            this.progressBarSplashScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBarSplashScreen.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBarSplashScreen.Location = new System.Drawing.Point(65, 360);
            this.progressBarSplashScreen.Name = "progressBarSplashScreen";
            this.progressBarSplashScreen.Size = new System.Drawing.Size(334, 40);
            this.progressBarSplashScreen.TabIndex = 0;
            this.progressBarSplashScreen.UseWaitCursor = true;
            // 
            // FormSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 565);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSplashScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplashScreen";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerSplashScreen;
        private System.Windows.Forms.ProgressBar progressBarSplashScreen;
    }
}