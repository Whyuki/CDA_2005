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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStripConnection = new System.Windows.Forms.MenuStrip();
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
            this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonIdentification = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripOutilsMenuItemCases = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOutilsMenuItemListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOutilsMenuItemComboBox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOutilsMenuItemDefilement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripOutilsMenuItemEmprunt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDerniereOperation = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStripConnection.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripConnection
            // 
            this.menuStripConnection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemConnection,
            this.toolStripMenuItemPhase1,
            this.toolStripMenuItemPhase2,
            this.toolStripMenuItemPhase3,
            this.toolStripMenuItemFenetres});
            this.menuStripConnection.Location = new System.Drawing.Point(0, 0);
            this.menuStripConnection.Name = "menuStripConnection";
            this.menuStripConnection.Size = new System.Drawing.Size(1027, 24);
            this.menuStripConnection.TabIndex = 1;
            this.menuStripConnection.Text = "menuStrip1";
            // 
            // toolStripMenuItemConnection
            // 
            this.toolStripMenuItemConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemIdentification,
            this.toolStripSeparator1,
            this.toolStripMenuItemQuitter});
            this.toolStripMenuItemConnection.Name = "toolStripMenuItemConnection";
            this.toolStripMenuItemConnection.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItemConnection.Text = "Connection";
            // 
            // toolStripMenuItemIdentification
            // 
            this.toolStripMenuItemIdentification.Name = "toolStripMenuItemIdentification";
            this.toolStripMenuItemIdentification.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemIdentification.Text = "S\'identifier";
            this.toolStripMenuItemIdentification.Click += new System.EventHandler(this.Identification_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // toolStripMenuItemQuitter
            // 
            this.toolStripMenuItemQuitter.Name = "toolStripMenuItemQuitter";
            this.toolStripMenuItemQuitter.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemQuitter.Text = "Quitter";
            // 
            // toolStripMenuItemPhase1
            // 
            this.toolStripMenuItemPhase1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdditionneur});
            this.toolStripMenuItemPhase1.Enabled = false;
            this.toolStripMenuItemPhase1.Name = "toolStripMenuItemPhase1";
            this.toolStripMenuItemPhase1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItemPhase1.Text = "Phase 1";
            // 
            // toolStripMenuItemAdditionneur
            // 
            this.toolStripMenuItemAdditionneur.Name = "toolStripMenuItemAdditionneur";
            this.toolStripMenuItemAdditionneur.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItemAdditionneur.Text = "Additionneur";
            this.toolStripMenuItemAdditionneur.Click += new System.EventHandler(this.toolStripMenuItemAdditionneur_Click);
            // 
            // toolStripMenuItemPhase2
            // 
            this.toolStripMenuItemPhase2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemControles});
            this.toolStripMenuItemPhase2.Enabled = false;
            this.toolStripMenuItemPhase2.Name = "toolStripMenuItemPhase2";
            this.toolStripMenuItemPhase2.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItemPhase2.Text = "Phase 2";
            // 
            // toolStripMenuItemControles
            // 
            this.toolStripMenuItemControles.Name = "toolStripMenuItemControles";
            this.toolStripMenuItemControles.Size = new System.Drawing.Size(172, 22);
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
            this.toolStripMenuItemPhase3.Name = "toolStripMenuItemPhase3";
            this.toolStripMenuItemPhase3.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItemPhase3.Text = "Phase 3";
            // 
            // toolStripMenuItemCases
            // 
            this.toolStripMenuItemCases.Name = "toolStripMenuItemCases";
            this.toolStripMenuItemCases.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemCases.Text = "Cases";
            this.toolStripMenuItemCases.Click += new System.EventHandler(this.toolStripMenuItemCases_Click);
            // 
            // toolStripMenuItemListBox
            // 
            this.toolStripMenuItemListBox.Name = "toolStripMenuItemListBox";
            this.toolStripMenuItemListBox.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemListBox.Text = "ListBox";
            this.toolStripMenuItemListBox.Click += new System.EventHandler(this.toolStripMenuItemListBox_Click);
            // 
            // toolStripMenuItemComboBox
            // 
            this.toolStripMenuItemComboBox.Name = "toolStripMenuItemComboBox";
            this.toolStripMenuItemComboBox.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemComboBox.Text = "ComboBox";
            this.toolStripMenuItemComboBox.Click += new System.EventHandler(this.toolStripMenuItemComboBox_Click);
            // 
            // toolStripMenuItemDefilement
            // 
            this.toolStripMenuItemDefilement.Name = "toolStripMenuItemDefilement";
            this.toolStripMenuItemDefilement.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDefilement.Text = "Defilement";
            this.toolStripMenuItemDefilement.Click += new System.EventHandler(this.toolStripMenuItemDefilement_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItemEmprunt
            // 
            this.toolStripMenuItemEmprunt.Name = "toolStripMenuItemEmprunt";
            this.toolStripMenuItemEmprunt.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemEmprunt.Text = "Emprunt";
            this.toolStripMenuItemEmprunt.Click += new System.EventHandler(this.toolStripMenuItemEmprunt_Click);
            // 
            // toolStripMenuItemFenetres
            // 
            this.toolStripMenuItemFenetres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCascade,
            this.toolStripMenuItemHorizontal,
            this.toolStripMenuItemVertical,
            this.toolStripSeparator3,
            this.toolStripComboBox});
            this.toolStripMenuItemFenetres.Enabled = false;
            this.toolStripMenuItemFenetres.Name = "toolStripMenuItemFenetres";
            this.toolStripMenuItemFenetres.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItemFenetres.Text = "Fenetres";
            // 
            // toolStripMenuItemCascade
            // 
            this.toolStripMenuItemCascade.Name = "toolStripMenuItemCascade";
            this.toolStripMenuItemCascade.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItemCascade.Text = "Cascade";
            this.toolStripMenuItemCascade.Click += new System.EventHandler(this.toolStripMenuItemCascade_Click);
            // 
            // toolStripMenuItemHorizontal
            // 
            this.toolStripMenuItemHorizontal.Name = "toolStripMenuItemHorizontal";
            this.toolStripMenuItemHorizontal.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItemHorizontal.Text = "Horizontal";
            this.toolStripMenuItemHorizontal.Click += new System.EventHandler(this.toolStripMenuItemHorizontal_Click);
            // 
            // toolStripMenuItemVertical
            // 
            this.toolStripMenuItemVertical.Name = "toolStripMenuItemVertical";
            this.toolStripMenuItemVertical.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItemVertical.Text = "Vertical";
            this.toolStripMenuItemVertical.Click += new System.EventHandler(this.toolStripMenuItemVertical_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripComboBox
            // 
            this.toolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox.Name = "toolStripComboBox";
            this.toolStripComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonIdentification,
            this.toolStripSeparator4,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1027, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStripOutils";
            // 
            // toolStripButtonIdentification
            // 
            this.toolStripButtonIdentification.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonIdentification.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIdentification.Image")));
            this.toolStripButtonIdentification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIdentification.Name = "toolStripButtonIdentification";
            this.toolStripButtonIdentification.Size = new System.Drawing.Size(67, 22);
            this.toolStripButtonIdentification.Text = "S\'identifier";
            this.toolStripButtonIdentification.Click += new System.EventHandler(this.Identification_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOutilsMenuItemCases,
            this.toolStripOutilsMenuItemListBox,
            this.toolStripOutilsMenuItemComboBox,
            this.toolStripOutilsMenuItemDefilement,
            this.toolStripSeparator5,
            this.toolStripOutilsMenuItemEmprunt});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripSplitButton1.Text = "Phase 3";
            // 
            // toolStripOutilsMenuItemCases
            // 
            this.toolStripOutilsMenuItemCases.Name = "toolStripOutilsMenuItemCases";
            this.toolStripOutilsMenuItemCases.Size = new System.Drawing.Size(180, 22);
            this.toolStripOutilsMenuItemCases.Text = "Cases";
            this.toolStripOutilsMenuItemCases.Click += new System.EventHandler(this.toolStripMenuItemCases_Click);
            // 
            // toolStripOutilsMenuItemListBox
            // 
            this.toolStripOutilsMenuItemListBox.Name = "toolStripOutilsMenuItemListBox";
            this.toolStripOutilsMenuItemListBox.Size = new System.Drawing.Size(180, 22);
            this.toolStripOutilsMenuItemListBox.Text = "ListBox";
            this.toolStripOutilsMenuItemListBox.Click += new System.EventHandler(this.toolStripMenuItemListBox_Click);
            // 
            // toolStripOutilsMenuItemComboBox
            // 
            this.toolStripOutilsMenuItemComboBox.Name = "toolStripOutilsMenuItemComboBox";
            this.toolStripOutilsMenuItemComboBox.Size = new System.Drawing.Size(180, 22);
            this.toolStripOutilsMenuItemComboBox.Text = "ComboBox";
            this.toolStripOutilsMenuItemComboBox.Click += new System.EventHandler(this.toolStripMenuItemComboBox_Click);
            // 
            // toolStripOutilsMenuItemDefilement
            // 
            this.toolStripOutilsMenuItemDefilement.Name = "toolStripOutilsMenuItemDefilement";
            this.toolStripOutilsMenuItemDefilement.Size = new System.Drawing.Size(180, 22);
            this.toolStripOutilsMenuItemDefilement.Text = "Defilement";
            this.toolStripOutilsMenuItemDefilement.Click += new System.EventHandler(this.toolStripMenuItemDefilement_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripOutilsMenuItemEmprunt
            // 
            this.toolStripOutilsMenuItemEmprunt.Name = "toolStripOutilsMenuItemEmprunt";
            this.toolStripOutilsMenuItemEmprunt.Size = new System.Drawing.Size(180, 22);
            this.toolStripOutilsMenuItemEmprunt.Text = "Emprunt";
            this.toolStripOutilsMenuItemEmprunt.Click += new System.EventHandler(this.toolStripMenuItemEmprunt_Click);
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabelDate.Text = "date";
            // 
            // toolStripStatusLabelDerniereOperation
            // 
            this.toolStripStatusLabelDerniereOperation.Name = "toolStripStatusLabelDerniereOperation";
            this.toolStripStatusLabelDerniereOperation.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabelDerniereOperation.Text = "derniere operation";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDate,
            this.toolStripStatusLabelDerniereOperation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 658);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1027, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 680);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripConnection);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripConnection;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creer des formulaires";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.menuStripConnection.ResumeLayout(false);
            this.menuStripConnection.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripConnection;
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
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonIdentification;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
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
    }
}

