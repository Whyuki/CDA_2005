
namespace WindowsFormsAppPapyrus
{
    partial class FormRechercheCommandes
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
            this.labelNomFournisseur = new System.Windows.Forms.Label();
            this.comboBoxListeFournisseurs = new System.Windows.Forms.ComboBox();
            this.listViewCommandes = new System.Windows.Forms.ListView();
            this.columnHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.labelCommandes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNomFournisseur
            // 
            this.labelNomFournisseur.AutoSize = true;
            this.labelNomFournisseur.Location = new System.Drawing.Point(73, 30);
            this.labelNomFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomFournisseur.Name = "labelNomFournisseur";
            this.labelNomFournisseur.Size = new System.Drawing.Size(162, 20);
            this.labelNomFournisseur.TabIndex = 0;
            this.labelNomFournisseur.Text = "Choisir un fournisseur";
            // 
            // comboBoxListeFournisseurs
            // 
            this.comboBoxListeFournisseurs.FormattingEnabled = true;
            this.comboBoxListeFournisseurs.Location = new System.Drawing.Point(297, 25);
            this.comboBoxListeFournisseurs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxListeFournisseurs.Name = "comboBoxListeFournisseurs";
            this.comboBoxListeFournisseurs.Size = new System.Drawing.Size(180, 28);
            this.comboBoxListeFournisseurs.TabIndex = 1;
            this.comboBoxListeFournisseurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeFournisseurs_SelectedIndexChanged);
            // 
            // listViewCommandes
            // 
            this.listViewCommandes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNum,
            this.columnHeaderDate,
            this.columnHeaderComm});
            this.listViewCommandes.FullRowSelect = true;
            this.listViewCommandes.HideSelection = false;
            this.listViewCommandes.Location = new System.Drawing.Point(54, 109);
            this.listViewCommandes.Name = "listViewCommandes";
            this.listViewCommandes.Size = new System.Drawing.Size(462, 179);
            this.listViewCommandes.TabIndex = 9;
            this.listViewCommandes.UseCompatibleStateImageBehavior = false;
            this.listViewCommandes.View = System.Windows.Forms.View.Details;
            this.listViewCommandes.Visible = false;
            // 
            // columnHeaderNum
            // 
            this.columnHeaderNum.Text = "Numéro";
            this.columnHeaderNum.Width = 100;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 100;
            // 
            // columnHeaderComm
            // 
            this.columnHeaderComm.Text = "Commentaire";
            this.columnHeaderComm.Width = 200;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.AutoSize = true;
            this.buttonQuitter.Location = new System.Drawing.Point(474, 323);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 30);
            this.buttonQuitter.TabIndex = 10;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // labelCommandes
            // 
            this.labelCommandes.AutoSize = true;
            this.labelCommandes.Location = new System.Drawing.Point(50, 86);
            this.labelCommandes.Name = "labelCommandes";
            this.labelCommandes.Size = new System.Drawing.Size(126, 20);
            this.labelCommandes.TabIndex = 11;
            this.labelCommandes.Text = "Les commandes";
            this.labelCommandes.Visible = false;
            // 
            // FormRechercheCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(561, 365);
            this.Controls.Add(this.labelCommandes);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.listViewCommandes);
            this.Controls.Add(this.comboBoxListeFournisseurs);
            this.Controls.Add(this.labelNomFournisseur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRechercheCommandes";
            this.Text = "Affichage des commandes";
            this.Load += new System.EventHandler(this.FormRechercheCommandes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomFournisseur;
        private System.Windows.Forms.ComboBox comboBoxListeFournisseurs;
        private System.Windows.Forms.ListView listViewCommandes;
        private System.Windows.Forms.ColumnHeader columnHeaderNum;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderComm;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Label labelCommandes;
    }
}