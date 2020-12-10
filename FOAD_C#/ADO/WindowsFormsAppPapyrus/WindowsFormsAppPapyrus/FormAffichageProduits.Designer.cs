
namespace WindowsFormsAppPapyrus
{
    partial class FormAffichageProduits
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
            this.labelListeProduits = new System.Windows.Forms.Label();
            this.listBoxListeProduit = new System.Windows.Forms.ListBox();
            this.labelCodeProduit = new System.Windows.Forms.Label();
            this.textBoxCodeProduit = new System.Windows.Forms.TextBox();
            this.textBoxLibelleProduit = new System.Windows.Forms.TextBox();
            this.labelLibelleProduit = new System.Windows.Forms.Label();
            this.textBoxStockAlerteProduit = new System.Windows.Forms.TextBox();
            this.labelStockAlerteProduit = new System.Windows.Forms.Label();
            this.textBoxStockPhysiqueProduit = new System.Windows.Forms.TextBox();
            this.labelStockPhysiqueProduit = new System.Windows.Forms.Label();
            this.textBoxQuantiteAnnuelleProduit = new System.Windows.Forms.TextBox();
            this.labelQuantiteAnnuelleProduit = new System.Windows.Forms.Label();
            this.textBoxUniteMesureProduit = new System.Windows.Forms.TextBox();
            this.labelUniteMesureProduit = new System.Windows.Forms.Label();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelListeProduits
            // 
            this.labelListeProduits.AutoSize = true;
            this.labelListeProduits.Location = new System.Drawing.Point(13, 21);
            this.labelListeProduits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListeProduits.Name = "labelListeProduits";
            this.labelListeProduits.Size = new System.Drawing.Size(134, 20);
            this.labelListeProduits.TabIndex = 0;
            this.labelListeProduits.Text = "Liste des produits";
            // 
            // listBoxListeProduit
            // 
            this.listBoxListeProduit.FormattingEnabled = true;
            this.listBoxListeProduit.ItemHeight = 20;
            this.listBoxListeProduit.Location = new System.Drawing.Point(17, 46);
            this.listBoxListeProduit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxListeProduit.Name = "listBoxListeProduit";
            this.listBoxListeProduit.Size = new System.Drawing.Size(248, 244);
            this.listBoxListeProduit.TabIndex = 1;
            this.listBoxListeProduit.SelectedIndexChanged += new System.EventHandler(this.listBoxListeProduit_SelectedIndexChanged);
            // 
            // labelCodeProduit
            // 
            this.labelCodeProduit.AutoSize = true;
            this.labelCodeProduit.Location = new System.Drawing.Point(349, 63);
            this.labelCodeProduit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodeProduit.Name = "labelCodeProduit";
            this.labelCodeProduit.Size = new System.Drawing.Size(47, 20);
            this.labelCodeProduit.TabIndex = 2;
            this.labelCodeProduit.Text = "Code";
            // 
            // textBoxCodeProduit
            // 
            this.textBoxCodeProduit.Location = new System.Drawing.Point(512, 58);
            this.textBoxCodeProduit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCodeProduit.Name = "textBoxCodeProduit";
            this.textBoxCodeProduit.ReadOnly = true;
            this.textBoxCodeProduit.Size = new System.Drawing.Size(148, 26);
            this.textBoxCodeProduit.TabIndex = 3;
            // 
            // textBoxLibelleProduit
            // 
            this.textBoxLibelleProduit.Location = new System.Drawing.Point(512, 98);
            this.textBoxLibelleProduit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLibelleProduit.Name = "textBoxLibelleProduit";
            this.textBoxLibelleProduit.ReadOnly = true;
            this.textBoxLibelleProduit.Size = new System.Drawing.Size(148, 26);
            this.textBoxLibelleProduit.TabIndex = 5;
            // 
            // labelLibelleProduit
            // 
            this.labelLibelleProduit.AutoSize = true;
            this.labelLibelleProduit.Location = new System.Drawing.Point(349, 103);
            this.labelLibelleProduit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLibelleProduit.Name = "labelLibelleProduit";
            this.labelLibelleProduit.Size = new System.Drawing.Size(54, 20);
            this.labelLibelleProduit.TabIndex = 4;
            this.labelLibelleProduit.Text = "Libellé";
            // 
            // textBoxStockAlerteProduit
            // 
            this.textBoxStockAlerteProduit.Location = new System.Drawing.Point(512, 138);
            this.textBoxStockAlerteProduit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStockAlerteProduit.Name = "textBoxStockAlerteProduit";
            this.textBoxStockAlerteProduit.ReadOnly = true;
            this.textBoxStockAlerteProduit.Size = new System.Drawing.Size(148, 26);
            this.textBoxStockAlerteProduit.TabIndex = 7;
            // 
            // labelStockAlerteProduit
            // 
            this.labelStockAlerteProduit.AutoSize = true;
            this.labelStockAlerteProduit.Location = new System.Drawing.Point(349, 143);
            this.labelStockAlerteProduit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStockAlerteProduit.Name = "labelStockAlerteProduit";
            this.labelStockAlerteProduit.Size = new System.Drawing.Size(106, 20);
            this.labelStockAlerteProduit.TabIndex = 6;
            this.labelStockAlerteProduit.Text = "Stock d\'alerte";
            // 
            // textBoxStockPhysiqueProduit
            // 
            this.textBoxStockPhysiqueProduit.Location = new System.Drawing.Point(512, 178);
            this.textBoxStockPhysiqueProduit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStockPhysiqueProduit.Name = "textBoxStockPhysiqueProduit";
            this.textBoxStockPhysiqueProduit.ReadOnly = true;
            this.textBoxStockPhysiqueProduit.Size = new System.Drawing.Size(148, 26);
            this.textBoxStockPhysiqueProduit.TabIndex = 9;
            // 
            // labelStockPhysiqueProduit
            // 
            this.labelStockPhysiqueProduit.AutoSize = true;
            this.labelStockPhysiqueProduit.Location = new System.Drawing.Point(349, 183);
            this.labelStockPhysiqueProduit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStockPhysiqueProduit.Name = "labelStockPhysiqueProduit";
            this.labelStockPhysiqueProduit.Size = new System.Drawing.Size(117, 20);
            this.labelStockPhysiqueProduit.TabIndex = 8;
            this.labelStockPhysiqueProduit.Text = "Stock physique";
            // 
            // textBoxQuantiteAnnuelleProduit
            // 
            this.textBoxQuantiteAnnuelleProduit.Location = new System.Drawing.Point(512, 218);
            this.textBoxQuantiteAnnuelleProduit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxQuantiteAnnuelleProduit.Name = "textBoxQuantiteAnnuelleProduit";
            this.textBoxQuantiteAnnuelleProduit.ReadOnly = true;
            this.textBoxQuantiteAnnuelleProduit.Size = new System.Drawing.Size(148, 26);
            this.textBoxQuantiteAnnuelleProduit.TabIndex = 11;
            // 
            // labelQuantiteAnnuelleProduit
            // 
            this.labelQuantiteAnnuelleProduit.AutoSize = true;
            this.labelQuantiteAnnuelleProduit.Location = new System.Drawing.Point(349, 223);
            this.labelQuantiteAnnuelleProduit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantiteAnnuelleProduit.Name = "labelQuantiteAnnuelleProduit";
            this.labelQuantiteAnnuelleProduit.Size = new System.Drawing.Size(134, 20);
            this.labelQuantiteAnnuelleProduit.TabIndex = 10;
            this.labelQuantiteAnnuelleProduit.Text = "Quantité annuelle";
            // 
            // textBoxUniteMesureProduit
            // 
            this.textBoxUniteMesureProduit.Location = new System.Drawing.Point(512, 258);
            this.textBoxUniteMesureProduit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUniteMesureProduit.Name = "textBoxUniteMesureProduit";
            this.textBoxUniteMesureProduit.ReadOnly = true;
            this.textBoxUniteMesureProduit.Size = new System.Drawing.Size(148, 26);
            this.textBoxUniteMesureProduit.TabIndex = 13;
            // 
            // labelUniteMesureProduit
            // 
            this.labelUniteMesureProduit.AutoSize = true;
            this.labelUniteMesureProduit.Location = new System.Drawing.Point(349, 263);
            this.labelUniteMesureProduit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUniteMesureProduit.Name = "labelUniteMesureProduit";
            this.labelUniteMesureProduit.Size = new System.Drawing.Size(126, 20);
            this.labelUniteMesureProduit.TabIndex = 12;
            this.labelUniteMesureProduit.Text = "Unité de mesure";
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.AutoSize = true;
            this.buttonQuitter.Location = new System.Drawing.Point(599, 326);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 30);
            this.buttonQuitter.TabIndex = 14;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // FormAffichageProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 381);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.textBoxUniteMesureProduit);
            this.Controls.Add(this.labelUniteMesureProduit);
            this.Controls.Add(this.textBoxQuantiteAnnuelleProduit);
            this.Controls.Add(this.labelQuantiteAnnuelleProduit);
            this.Controls.Add(this.textBoxStockPhysiqueProduit);
            this.Controls.Add(this.labelStockPhysiqueProduit);
            this.Controls.Add(this.textBoxStockAlerteProduit);
            this.Controls.Add(this.labelStockAlerteProduit);
            this.Controls.Add(this.textBoxLibelleProduit);
            this.Controls.Add(this.labelLibelleProduit);
            this.Controls.Add(this.textBoxCodeProduit);
            this.Controls.Add(this.labelCodeProduit);
            this.Controls.Add(this.listBoxListeProduit);
            this.Controls.Add(this.labelListeProduits);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAffichageProduits";
            this.Text = "Affichage des produits";
            this.Load += new System.EventHandler(this.FormAffichageProduits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListeProduits;
        private System.Windows.Forms.ListBox listBoxListeProduit;
        private System.Windows.Forms.Label labelCodeProduit;
        private System.Windows.Forms.TextBox textBoxCodeProduit;
        private System.Windows.Forms.TextBox textBoxLibelleProduit;
        private System.Windows.Forms.Label labelLibelleProduit;
        private System.Windows.Forms.TextBox textBoxStockAlerteProduit;
        private System.Windows.Forms.Label labelStockAlerteProduit;
        private System.Windows.Forms.TextBox textBoxStockPhysiqueProduit;
        private System.Windows.Forms.Label labelStockPhysiqueProduit;
        private System.Windows.Forms.TextBox textBoxQuantiteAnnuelleProduit;
        private System.Windows.Forms.Label labelQuantiteAnnuelleProduit;
        private System.Windows.Forms.TextBox textBoxUniteMesureProduit;
        private System.Windows.Forms.Label labelUniteMesureProduit;
        private System.Windows.Forms.Button buttonQuitter;
    }
}