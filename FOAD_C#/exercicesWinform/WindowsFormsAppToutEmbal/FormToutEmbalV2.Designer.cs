namespace WindowsFormsAppToutEmbal
{
    partial class FormToutEmbalV2
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
            this.timerHeure = new System.Windows.Forms.Timer(this.components);
            this.statusStripHeure = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelHeure = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.démarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspendreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlOngletsType = new System.Windows.Forms.TabControl();
            this.flowLayoutPanelProgressBar = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelBoutonsActions = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelEtat = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStripHeure.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerHeure
            // 
            this.timerHeure.Tick += new System.EventHandler(this.timerHeure_Tick);
            // 
            // statusStripHeure
            // 
            this.statusStripHeure.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStripHeure.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelHeure});
            this.statusStripHeure.Location = new System.Drawing.Point(0, 575);
            this.statusStripHeure.Name = "statusStripHeure";
            this.statusStripHeure.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.statusStripHeure.Size = new System.Drawing.Size(1017, 26);
            this.statusStripHeure.SizingGrip = false;
            this.statusStripHeure.TabIndex = 2;
            this.statusStripHeure.Text = "statusStrip1";
            // 
            // toolStripStatusLabelHeure
            // 
            this.toolStripStatusLabelHeure.Margin = new System.Windows.Forms.Padding(130, 3, 0, 2);
            this.toolStripStatusLabelHeure.Name = "toolStripStatusLabelHeure";
            this.toolStripStatusLabelHeure.Size = new System.Drawing.Size(866, 21);
            this.toolStripStatusLabelHeure.Spring = true;
            this.toolStripStatusLabelHeure.Text = "HEURE";
            this.toolStripStatusLabelHeure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1017, 29);
            this.menuStripMain.TabIndex = 9;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneProductionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterUneProductionToolStripMenuItem
            // 
            this.ajouterUneProductionToolStripMenuItem.Name = "ajouterUneProductionToolStripMenuItem";
            this.ajouterUneProductionToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.ajouterUneProductionToolStripMenuItem.Text = "Ajouter une production";
            this.ajouterUneProductionToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneProductionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.démarrerToolStripMenuItem,
            this.suspendreToolStripMenuItem,
            this.continuerToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.productionToolStripMenuItem.Text = "Production";
            // 
            // démarrerToolStripMenuItem
            // 
            this.démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            this.démarrerToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.démarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // suspendreToolStripMenuItem
            // 
            this.suspendreToolStripMenuItem.Name = "suspendreToolStripMenuItem";
            this.suspendreToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.suspendreToolStripMenuItem.Text = "Mettre en pause";
            // 
            // continuerToolStripMenuItem
            // 
            this.continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            this.continuerToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.continuerToolStripMenuItem.Text = "Continuer";
            // 
            // tabControlOngletsType
            // 
            this.tabControlOngletsType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlOngletsType.Location = new System.Drawing.Point(474, 32);
            this.tabControlOngletsType.Name = "tabControlOngletsType";
            this.tabControlOngletsType.SelectedIndex = 0;
            this.tabControlOngletsType.Size = new System.Drawing.Size(536, 257);
            this.tabControlOngletsType.TabIndex = 12;
            // 
            // flowLayoutPanelProgressBar
            // 
            this.flowLayoutPanelProgressBar.AutoScroll = true;
            this.flowLayoutPanelProgressBar.Location = new System.Drawing.Point(474, 295);
            this.flowLayoutPanelProgressBar.Name = "flowLayoutPanelProgressBar";
            this.flowLayoutPanelProgressBar.Size = new System.Drawing.Size(536, 218);
            this.flowLayoutPanelProgressBar.TabIndex = 15;
            // 
            // flowLayoutPanelBoutonsActions
            // 
            this.flowLayoutPanelBoutonsActions.AutoScroll = true;
            this.flowLayoutPanelBoutonsActions.Location = new System.Drawing.Point(12, 32);
            this.flowLayoutPanelBoutonsActions.Name = "flowLayoutPanelBoutonsActions";
            this.flowLayoutPanelBoutonsActions.Size = new System.Drawing.Size(456, 481);
            this.flowLayoutPanelBoutonsActions.TabIndex = 16;
            // 
            // flowLayoutPanelEtat
            // 
            this.flowLayoutPanelEtat.AutoScroll = true;
            this.flowLayoutPanelEtat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelEtat.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanelEtat.Location = new System.Drawing.Point(0, 516);
            this.flowLayoutPanelEtat.Name = "flowLayoutPanelEtat";
            this.flowLayoutPanelEtat.Size = new System.Drawing.Size(1017, 59);
            this.flowLayoutPanelEtat.TabIndex = 17;
            // 
            // FormToutEmbalV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 601);
            this.Controls.Add(this.flowLayoutPanelEtat);
            this.Controls.Add(this.flowLayoutPanelBoutonsActions);
            this.Controls.Add(this.flowLayoutPanelProgressBar);
            this.Controls.Add(this.tabControlOngletsType);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.statusStripHeure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormToutEmbalV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production de caisses";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormToutEmbal_FormClosing);
            this.statusStripHeure.ResumeLayout(false);
            this.statusStripHeure.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerHeure;
        private System.Windows.Forms.StatusStrip statusStripHeure;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHeure;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneProductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem démarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspendreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continuerToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlOngletsType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProgressBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBoutonsActions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEtat;
    }
}