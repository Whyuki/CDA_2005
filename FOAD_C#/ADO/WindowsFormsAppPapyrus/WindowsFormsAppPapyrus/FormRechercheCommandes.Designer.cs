
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
            this.richTextBoxCommandesNum = new System.Windows.Forms.RichTextBox();
            this.labelIdCommande = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.richTextBoxCommandesDate = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCommandesComment = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelNomFournisseur
            // 
            this.labelNomFournisseur.AutoSize = true;
            this.labelNomFournisseur.Location = new System.Drawing.Point(83, 27);
            this.labelNomFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomFournisseur.Name = "labelNomFournisseur";
            this.labelNomFournisseur.Size = new System.Drawing.Size(162, 20);
            this.labelNomFournisseur.TabIndex = 0;
            this.labelNomFournisseur.Text = "Choisir un fournisseur";
            // 
            // comboBoxListeFournisseurs
            // 
            this.comboBoxListeFournisseurs.FormattingEnabled = true;
            this.comboBoxListeFournisseurs.Location = new System.Drawing.Point(307, 22);
            this.comboBoxListeFournisseurs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxListeFournisseurs.Name = "comboBoxListeFournisseurs";
            this.comboBoxListeFournisseurs.Size = new System.Drawing.Size(180, 28);
            this.comboBoxListeFournisseurs.TabIndex = 1;
            this.comboBoxListeFournisseurs.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeFournisseurs_SelectedIndexChanged);
            // 
            // richTextBoxCommandesNum
            // 
            this.richTextBoxCommandesNum.Location = new System.Drawing.Point(24, 112);
            this.richTextBoxCommandesNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxCommandesNum.Name = "richTextBoxCommandesNum";
            this.richTextBoxCommandesNum.ReadOnly = true;
            this.richTextBoxCommandesNum.Size = new System.Drawing.Size(96, 146);
            this.richTextBoxCommandesNum.TabIndex = 2;
            this.richTextBoxCommandesNum.Text = "";
            // 
            // labelIdCommande
            // 
            this.labelIdCommande.AutoSize = true;
            this.labelIdCommande.Location = new System.Drawing.Point(24, 83);
            this.labelIdCommande.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdCommande.Name = "labelIdCommande";
            this.labelIdCommande.Size = new System.Drawing.Size(25, 20);
            this.labelIdCommande.TabIndex = 3;
            this.labelIdCommande.Text = "N°";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(126, 83);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 20);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "DATE";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(266, 83);
            this.labelComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(128, 20);
            this.labelComment.TabIndex = 5;
            this.labelComment.Text = "COMMENTAIRE";
            // 
            // richTextBoxCommandesDate
            // 
            this.richTextBoxCommandesDate.Location = new System.Drawing.Point(130, 112);
            this.richTextBoxCommandesDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxCommandesDate.Name = "richTextBoxCommandesDate";
            this.richTextBoxCommandesDate.ReadOnly = true;
            this.richTextBoxCommandesDate.Size = new System.Drawing.Size(128, 146);
            this.richTextBoxCommandesDate.TabIndex = 6;
            this.richTextBoxCommandesDate.Text = "";
            // 
            // richTextBoxCommandesComment
            // 
            this.richTextBoxCommandesComment.Location = new System.Drawing.Point(270, 112);
            this.richTextBoxCommandesComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxCommandesComment.Name = "richTextBoxCommandesComment";
            this.richTextBoxCommandesComment.ReadOnly = true;
            this.richTextBoxCommandesComment.Size = new System.Drawing.Size(287, 146);
            this.richTextBoxCommandesComment.TabIndex = 7;
            this.richTextBoxCommandesComment.Text = "";
            // 
            // FormRechercheCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 283);
            this.Controls.Add(this.richTextBoxCommandesComment);
            this.Controls.Add(this.richTextBoxCommandesDate);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelIdCommande);
            this.Controls.Add(this.richTextBoxCommandesNum);
            this.Controls.Add(this.comboBoxListeFournisseurs);
            this.Controls.Add(this.labelNomFournisseur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.RichTextBox richTextBoxCommandesNum;
        private System.Windows.Forms.Label labelIdCommande;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.RichTextBox richTextBoxCommandesDate;
        private System.Windows.Forms.RichTextBox richTextBoxCommandesComment;
    }
}