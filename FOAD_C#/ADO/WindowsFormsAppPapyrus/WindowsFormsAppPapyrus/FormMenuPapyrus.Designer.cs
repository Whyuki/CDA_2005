
namespace WindowsFormsAppPapyrus
{
    partial class FormMenuPapyrus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPapyrus));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonConnexion = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRechercheFournisseur = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRechercheCommande = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGestionFournisseurs = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAfficherProduits = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConnexion,
            this.toolStripButtonRechercheFournisseur,
            this.toolStripButtonRechercheCommande,
            this.toolStripButtonGestionFournisseurs});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1200, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonConnexion
            // 
            this.toolStripButtonConnexion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonConnexion.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripButtonConnexion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConnexion.Image")));
            this.toolStripButtonConnexion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnexion.Name = "toolStripButtonConnexion";
            this.toolStripButtonConnexion.Size = new System.Drawing.Size(128, 32);
            this.toolStripButtonConnexion.Text = "Se connecter";
            this.toolStripButtonConnexion.Click += new System.EventHandler(this.toolStripButtonConnexion_Click);
            // 
            // toolStripButtonRechercheFournisseur
            // 
            this.toolStripButtonRechercheFournisseur.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRechercheFournisseur.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripButtonRechercheFournisseur.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRechercheFournisseur.Image")));
            this.toolStripButtonRechercheFournisseur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRechercheFournisseur.Name = "toolStripButtonRechercheFournisseur";
            this.toolStripButtonRechercheFournisseur.Size = new System.Drawing.Size(239, 32);
            this.toolStripButtonRechercheFournisseur.Text = "Rechercher un fournisseur";
            this.toolStripButtonRechercheFournisseur.Click += new System.EventHandler(this.toolStripButtonRechercheFournisseur_Click);
            // 
            // toolStripButtonRechercheCommande
            // 
            this.toolStripButtonRechercheCommande.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRechercheCommande.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripButtonRechercheCommande.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRechercheCommande.Image")));
            this.toolStripButtonRechercheCommande.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRechercheCommande.Name = "toolStripButtonRechercheCommande";
            this.toolStripButtonRechercheCommande.Size = new System.Drawing.Size(251, 32);
            this.toolStripButtonRechercheCommande.Text = "Rechercher une commande";
            this.toolStripButtonRechercheCommande.Click += new System.EventHandler(this.toolStripButtonRechercheCommande_Click);
            // 
            // toolStripButtonGestionFournisseurs
            // 
            this.toolStripButtonGestionFournisseurs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGestionFournisseurs.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripButtonGestionFournisseurs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGestionFournisseurs.Image")));
            this.toolStripButtonGestionFournisseurs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGestionFournisseurs.Name = "toolStripButtonGestionFournisseurs";
            this.toolStripButtonGestionFournisseurs.Size = new System.Drawing.Size(201, 32);
            this.toolStripButtonGestionFournisseurs.Text = "Gerer les fournisseurs";
            this.toolStripButtonGestionFournisseurs.Click += new System.EventHandler(this.toolStripButtonGestionFournisseurs_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAfficherProduits});
            this.toolStrip2.Location = new System.Drawing.Point(0, 35);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1200, 35);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonAfficherProduits
            // 
            this.toolStripButtonAfficherProduits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAfficherProduits.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripButtonAfficherProduits.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAfficherProduits.Image")));
            this.toolStripButtonAfficherProduits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAfficherProduits.Name = "toolStripButtonAfficherProduits";
            this.toolStripButtonAfficherProduits.Size = new System.Drawing.Size(190, 32);
            this.toolStripButtonAfficherProduits.Text = "Afficher les produits";
            this.toolStripButtonAfficherProduits.Click += new System.EventHandler(this.toolStripButtonAfficherProduits_Click_1);
            // 
            // FormMenuPapyrus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMenuPapyrus";
            this.Text = "Papyrus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRechercheFournisseur;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnexion;
        private System.Windows.Forms.ToolStripButton toolStripButtonRechercheCommande;
        private System.Windows.Forms.ToolStripButton toolStripButtonGestionFournisseurs;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAfficherProduits;
    }
}