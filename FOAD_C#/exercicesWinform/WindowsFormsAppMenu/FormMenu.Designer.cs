namespace WindowsFormsAppMenu
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemIdentification = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPhase1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdditionneur = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPhase2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemControles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPhase3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCases = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemComboBox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDefilement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemEmprunt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFenetres = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonIdentification = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonPhase3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripOutilsMenuItemCases = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOutilsMenuItemListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOutilsMenuItemComboBox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOutilsMenuItemDefilement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripOutilsMenuItemEmprunt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDerniereOperation = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemConnection,
            this.toolStripMenuItemPhase1,
            this.toolStripMenuItemPhase2,
            this.toolStripMenuItemPhase3,
            this.toolStripMenuItemFenetres});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1520, 29);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemConnection
            // 
            this.toolStripMenuItemConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemIdentification,
            this.toolStripSeparator1,
            this.toolStripMenuItemQuitter});
            this.toolStripMenuItemConnection.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItemConnection.Name = "toolStripMenuItemConnection";
            this.toolStripMenuItemConnection.Size = new System.Drawing.Size(101, 25);
            this.toolStripMenuItemConnection.Text = "Connection";
            // 
            // toolStripMenuItemIdentification
            // 
            this.toolStripMenuItemIdentification.Name = "toolStripMenuItemIdentification";
            this.toolStripMenuItemIdentification.Size = new System.Drawing.Size(155, 26);
            this.toolStripMenuItemIdentification.Text = "S\'identifier";
            this.toolStripMenuItemIdentification.Click += new System.EventHandler(this.Identification_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // toolStripMenuItemQuitter
            // 
            this.toolStripMenuItemQuitter.Name = "toolStripMenuItemQuitter";
            this.toolStripMenuItemQuitter.Size = new System.Drawing.Size(155, 26);
            this.toolStripMenuItemQuitter.Text = "Quitter";
            this.toolStripMenuItemQuitter.Click += new System.EventHandler(this.toolStripMenuItemQuitter_Click);
            // 
            // toolStripMenuItemPhase1
            // 
            this.toolStripMenuItemPhase1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdditionneur});
            this.toolStripMenuItemPhase1.Enabled = false;
            this.toolStripMenuItemPhase1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItemPhase1.Name = "toolStripMenuItemPhase1";
            this.toolStripMenuItemPhase1.Size = new System.Drawing.Size(76, 25);
            this.toolStripMenuItemPhase1.Text = "Phase 1";
            // 
            // toolStripMenuItemAdditionneur
            // 
            this.toolStripMenuItemAdditionneur.Name = "toolStripMenuItemAdditionneur";
            this.toolStripMenuItemAdditionneur.Size = new System.Drawing.Size(171, 26);
            this.toolStripMenuItemAdditionneur.Text = "Additionneur";
            this.toolStripMenuItemAdditionneur.Click += new System.EventHandler(this.toolStripMenuItemAdditionneur_Click);
            // 
            // toolStripMenuItemPhase2
            // 
            this.toolStripMenuItemPhase2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemControles});
            this.toolStripMenuItemPhase2.Enabled = false;
            this.toolStripMenuItemPhase2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItemPhase2.Name = "toolStripMenuItemPhase2";
            this.toolStripMenuItemPhase2.Size = new System.Drawing.Size(76, 25);
            this.toolStripMenuItemPhase2.Text = "Phase 2";
            // 
            // toolStripMenuItemControles
            // 
            this.toolStripMenuItemControles.Name = "toolStripMenuItemControles";
            this.toolStripMenuItemControles.Size = new System.Drawing.Size(210, 26);
            this.toolStripMenuItemControles.Text = "Controles de saisie";
            this.toolStripMenuItemControles.Click += new System.EventHandler(this.toolStripMenuItemControles_Click);
            // 
            // toolStripMenuItemPhase3
            // 
            this.toolStripMenuItemPhase3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCases,
            this.toolStripMenuItemListBox,
            this.toolStripMenuItemComboBox,
            this.toolStripMenuItemDefilement,
            this.toolStripSeparator2,
            this.toolStripMenuItemEmprunt});
            this.toolStripMenuItemPhase3.Enabled = false;
            this.toolStripMenuItemPhase3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItemPhase3.Name = "toolStripMenuItemPhase3";
            this.toolStripMenuItemPhase3.Size = new System.Drawing.Size(76, 25);
            this.toolStripMenuItemPhase3.Text = "Phase 3";
            // 
            // toolStripMenuItemCases
            // 
            this.toolStripMenuItemCases.Name = "toolStripMenuItemCases";
            this.toolStripMenuItemCases.Size = new System.Drawing.Size(156, 26);
            this.toolStripMenuItemCases.Text = "Cases";
            this.toolStripMenuItemCases.Click += new System.EventHandler(this.toolStripMenuItemCases_Click);
            // 
            // toolStripMenuItemListBox
            // 
            this.toolStripMenuItemListBox.Name = "toolStripMenuItemListBox";
            this.toolStripMenuItemListBox.Size = new System.Drawing.Size(156, 26);
            this.toolStripMenuItemListBox.Text = "ListBox";
            this.toolStripMenuItemListBox.Click += new System.EventHandler(this.toolStripMenuItemListBox_Click);
            // 
            // toolStripMenuItemComboBox
            // 
            this.toolStripMenuItemComboBox.Name = "toolStripMenuItemComboBox";
            this.toolStripMenuItemComboBox.Size = new System.Drawing.Size(156, 26);
            this.toolStripMenuItemComboBox.Text = "ComboBox";
            this.toolStripMenuItemComboBox.Click += new System.EventHandler(this.toolStripMenuItemComboBox_Click);
            // 
            // toolStripMenuItemDefilement
            // 
            this.toolStripMenuItemDefilement.Name = "toolStripMenuItemDefilement";
            this.toolStripMenuItemDefilement.Size = new System.Drawing.Size(156, 26);
            this.toolStripMenuItemDefilement.Text = "Defilement";
            this.toolStripMenuItemDefilement.Click += new System.EventHandler(this.toolStripMenuItemDefilement_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // toolStripMenuItemEmprunt
            // 
            this.toolStripMenuItemEmprunt.Name = "toolStripMenuItemEmprunt";
            this.toolStripMenuItemEmprunt.Size = new System.Drawing.Size(156, 26);
            this.toolStripMenuItemEmprunt.Text = "Emprunt";
            this.toolStripMenuItemEmprunt.Click += new System.EventHandler(this.toolStripMenuItemEmprunt_Click);
            // 
            // toolStripMenuItemFenetres
            // 
            this.toolStripMenuItemFenetres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCascade,
            this.toolStripMenuItemHorizontal,
            this.toolStripMenuItemVertical,
            this.toolStripSeparator3});
            this.toolStripMenuItemFenetres.Enabled = false;
            this.toolStripMenuItemFenetres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItemFenetres.Name = "toolStripMenuItemFenetres";
            this.toolStripMenuItemFenetres.Size = new System.Drawing.Size(81, 25);
            this.toolStripMenuItemFenetres.Text = "Fenetres";
            // 
            // toolStripMenuItemCascade
            // 
            this.toolStripMenuItemCascade.Name = "toolStripMenuItemCascade";
            this.toolStripMenuItemCascade.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemCascade.Text = "Cascade";
            this.toolStripMenuItemCascade.Click += new System.EventHandler(this.toolStripMenuItemCascade_Click);
            // 
            // toolStripMenuItemHorizontal
            // 
            this.toolStripMenuItemHorizontal.Name = "toolStripMenuItemHorizontal";
            this.toolStripMenuItemHorizontal.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemHorizontal.Text = "Horizontal";
            this.toolStripMenuItemHorizontal.Click += new System.EventHandler(this.toolStripMenuItemHorizontal_Click);
            // 
            // toolStripMenuItemVertical
            // 
            this.toolStripMenuItemVertical.Name = "toolStripMenuItemVertical";
            this.toolStripMenuItemVertical.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemVertical.Text = "Vertical";
            this.toolStripMenuItemVertical.Click += new System.EventHandler(this.toolStripMenuItemVertical_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonIdentification,
            this.toolStripSeparator4,
            this.toolStripSplitButtonPhase3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1520, 28);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStripOutils";
            // 
            // toolStripButtonIdentification
            // 
            this.toolStripButtonIdentification.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonIdentification.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButtonIdentification.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIdentification.Image")));
            this.toolStripButtonIdentification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIdentification.Name = "toolStripButtonIdentification";
            this.toolStripButtonIdentification.Size = new System.Drawing.Size(89, 25);
            this.toolStripButtonIdentification.Text = "S\'identifier";
            this.toolStripButtonIdentification.Click += new System.EventHandler(this.Identification_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSplitButtonPhase3
            // 
            this.toolStripSplitButtonPhase3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonPhase3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOutilsMenuItemCases,
            this.toolStripOutilsMenuItemListBox,
            this.toolStripOutilsMenuItemComboBox,
            this.toolStripOutilsMenuItemDefilement,
            this.toolStripSeparator5,
            this.toolStripOutilsMenuItemEmprunt});
            this.toolStripSplitButtonPhase3.Enabled = false;
            this.toolStripSplitButtonPhase3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripSplitButtonPhase3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonPhase3.Image")));
            this.toolStripSplitButtonPhase3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonPhase3.Name = "toolStripSplitButtonPhase3";
            this.toolStripSplitButtonPhase3.Size = new System.Drawing.Size(80, 25);
            this.toolStripSplitButtonPhase3.Text = "Phase 3";
            this.toolStripSplitButtonPhase3.ButtonClick += new System.EventHandler(this.toolStripSplitButtonPhase3_ButtonClick);
            // 
            // toolStripOutilsMenuItemCases
            // 
            this.toolStripOutilsMenuItemCases.Name = "toolStripOutilsMenuItemCases";
            this.toolStripOutilsMenuItemCases.Size = new System.Drawing.Size(180, 26);
            this.toolStripOutilsMenuItemCases.Text = "Cases";
            this.toolStripOutilsMenuItemCases.Click += new System.EventHandler(this.toolStripOutilsMenuItemCases_Click);
            // 
            // toolStripOutilsMenuItemListBox
            // 
            this.toolStripOutilsMenuItemListBox.Name = "toolStripOutilsMenuItemListBox";
            this.toolStripOutilsMenuItemListBox.Size = new System.Drawing.Size(180, 26);
            this.toolStripOutilsMenuItemListBox.Text = "ListBox";
            this.toolStripOutilsMenuItemListBox.Click += new System.EventHandler(this.toolStripOutilsMenuItemListBox_Click);
            // 
            // toolStripOutilsMenuItemComboBox
            // 
            this.toolStripOutilsMenuItemComboBox.Name = "toolStripOutilsMenuItemComboBox";
            this.toolStripOutilsMenuItemComboBox.Size = new System.Drawing.Size(180, 26);
            this.toolStripOutilsMenuItemComboBox.Text = "ComboBox";
            this.toolStripOutilsMenuItemComboBox.Click += new System.EventHandler(this.toolStripOutilsMenuItemComboBox_Click);
            // 
            // toolStripOutilsMenuItemDefilement
            // 
            this.toolStripOutilsMenuItemDefilement.Name = "toolStripOutilsMenuItemDefilement";
            this.toolStripOutilsMenuItemDefilement.Size = new System.Drawing.Size(180, 26);
            this.toolStripOutilsMenuItemDefilement.Text = "Defilement";
            this.toolStripOutilsMenuItemDefilement.Click += new System.EventHandler(this.toolStripOutilsMenuItemDefilement_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripOutilsMenuItemEmprunt
            // 
            this.toolStripOutilsMenuItemEmprunt.Name = "toolStripOutilsMenuItemEmprunt";
            this.toolStripOutilsMenuItemEmprunt.Size = new System.Drawing.Size(180, 26);
            this.toolStripOutilsMenuItemEmprunt.Text = "Emprunt";
            this.toolStripOutilsMenuItemEmprunt.Click += new System.EventHandler(this.toolStripOutilsMenuItemEmprunt_Click);
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(40, 21);
            this.toolStripStatusLabelDate.Text = "date";
            // 
            // toolStripStatusLabelDerniereOperation
            // 
            this.toolStripStatusLabelDerniereOperation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabelDerniereOperation.Name = "toolStripStatusLabelDerniereOperation";
            this.toolStripStatusLabelDerniereOperation.Size = new System.Drawing.Size(0, 21);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDate,
            this.toolStripStatusLabelDerniereOperation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 841);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1520, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timerDate
            // 
            this.timerDate.Interval = 1000;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 867);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creer des formulaires";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConnection;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIdentification;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuitter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPhase1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPhase2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPhase3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFenetres;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdditionneur;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemControles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCases;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemComboBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDefilement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEmprunt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCascade;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHorizontal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVertical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonIdentification;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonPhase3;
        private System.Windows.Forms.ToolStripMenuItem toolStripOutilsMenuItemCases;
        private System.Windows.Forms.ToolStripMenuItem toolStripOutilsMenuItemComboBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripOutilsMenuItemDefilement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripOutilsMenuItemEmprunt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDerniereOperation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemListBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripOutilsMenuItemListBox;
        private System.Windows.Forms.Timer timerDate;
    }
}

