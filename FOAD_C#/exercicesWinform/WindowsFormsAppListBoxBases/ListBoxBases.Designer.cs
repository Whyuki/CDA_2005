namespace WindowsFormsAppListBoxBases
{
    partial class ListBoxBases
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
            this.labelNouvelElement = new System.Windows.Forms.Label();
            this.labelLstListe = new System.Windows.Forms.Label();
            this.labelIndexElement = new System.Windows.Forms.Label();
            this.labelProprietes = new System.Windows.Forms.Label();
            this.textBoxNouvelElement = new System.Windows.Forms.TextBox();
            this.textBoxIndexElement = new System.Windows.Forms.TextBox();
            this.buttonAjoutListe = new System.Windows.Forms.Button();
            this.buttonSelectionner = new System.Windows.Forms.Button();
            this.buttonViderListe = new System.Windows.Forms.Button();
            this.listBoxLstListe = new System.Windows.Forms.ListBox();
            this.labelItemsCount = new System.Windows.Forms.Label();
            this.labelSelectedIndex = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.textBoxItemsCount = new System.Windows.Forms.TextBox();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.textBoxSelectedText = new System.Windows.Forms.TextBox();
            this.errorProviderAjoutListe = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIndex = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAjoutListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNouvelElement
            // 
            this.labelNouvelElement.AutoSize = true;
            this.labelNouvelElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNouvelElement.Location = new System.Drawing.Point(23, 21);
            this.labelNouvelElement.Name = "labelNouvelElement";
            this.labelNouvelElement.Size = new System.Drawing.Size(134, 20);
            this.labelNouvelElement.TabIndex = 0;
            this.labelNouvelElement.Text = "Nouvel Element";
            // 
            // labelLstListe
            // 
            this.labelLstListe.AutoSize = true;
            this.labelLstListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLstListe.Location = new System.Drawing.Point(23, 199);
            this.labelLstListe.Name = "labelLstListe";
            this.labelLstListe.Size = new System.Drawing.Size(73, 20);
            this.labelLstListe.TabIndex = 1;
            this.labelLstListe.Text = "LstListe";
            // 
            // labelIndexElement
            // 
            this.labelIndexElement.AutoSize = true;
            this.labelIndexElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexElement.Location = new System.Drawing.Point(239, 21);
            this.labelIndexElement.Name = "labelIndexElement";
            this.labelIndexElement.Size = new System.Drawing.Size(124, 20);
            this.labelIndexElement.TabIndex = 2;
            this.labelIndexElement.Text = "Index Element";
            // 
            // labelProprietes
            // 
            this.labelProprietes.AutoSize = true;
            this.labelProprietes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProprietes.Location = new System.Drawing.Point(238, 199);
            this.labelProprietes.Name = "labelProprietes";
            this.labelProprietes.Size = new System.Drawing.Size(91, 20);
            this.labelProprietes.TabIndex = 3;
            this.labelProprietes.Text = "Proprietes";
            // 
            // textBoxNouvelElement
            // 
            this.textBoxNouvelElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNouvelElement.Location = new System.Drawing.Point(26, 66);
            this.textBoxNouvelElement.Name = "textBoxNouvelElement";
            this.textBoxNouvelElement.Size = new System.Drawing.Size(100, 26);
            this.textBoxNouvelElement.TabIndex = 4;
            this.textBoxNouvelElement.TextChanged += new System.EventHandler(this.textBoxNouvelElement_TextChanged);
            this.textBoxNouvelElement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNouvelElement_KeyPress);
            // 
            // textBoxIndexElement
            // 
            this.textBoxIndexElement.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxIndexElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndexElement.Location = new System.Drawing.Point(242, 66);
            this.textBoxIndexElement.Name = "textBoxIndexElement";
            this.textBoxIndexElement.Size = new System.Drawing.Size(66, 26);
            this.textBoxIndexElement.TabIndex = 6;
            this.textBoxIndexElement.TextChanged += new System.EventHandler(this.textBoxIndexElement_TextChanged);
            this.textBoxIndexElement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIndexElement_KeyPress);
            // 
            // buttonAjoutListe
            // 
            this.buttonAjoutListe.AutoSize = true;
            this.buttonAjoutListe.Enabled = false;
            this.buttonAjoutListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjoutListe.Location = new System.Drawing.Point(26, 116);
            this.buttonAjoutListe.Name = "buttonAjoutListe";
            this.buttonAjoutListe.Size = new System.Drawing.Size(149, 35);
            this.buttonAjoutListe.TabIndex = 5;
            this.buttonAjoutListe.Text = "Ajout Liste";
            this.buttonAjoutListe.UseVisualStyleBackColor = true;
            this.buttonAjoutListe.Click += new System.EventHandler(this.buttonAjoutListe_Click);
            // 
            // buttonSelectionner
            // 
            this.buttonSelectionner.AutoSize = true;
            this.buttonSelectionner.Enabled = false;
            this.buttonSelectionner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectionner.Location = new System.Drawing.Point(356, 64);
            this.buttonSelectionner.Name = "buttonSelectionner";
            this.buttonSelectionner.Size = new System.Drawing.Size(131, 35);
            this.buttonSelectionner.TabIndex = 7;
            this.buttonSelectionner.Text = "Selectionner";
            this.buttonSelectionner.UseVisualStyleBackColor = true;
            this.buttonSelectionner.Click += new System.EventHandler(this.buttonSelectionner_Click);
            // 
            // buttonViderListe
            // 
            this.buttonViderListe.AutoSize = true;
            this.buttonViderListe.Enabled = false;
            this.buttonViderListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViderListe.Location = new System.Drawing.Point(356, 116);
            this.buttonViderListe.Name = "buttonViderListe";
            this.buttonViderListe.Size = new System.Drawing.Size(127, 35);
            this.buttonViderListe.TabIndex = 8;
            this.buttonViderListe.Text = "Vider la liste";
            this.buttonViderListe.UseVisualStyleBackColor = true;
            this.buttonViderListe.Click += new System.EventHandler(this.buttonViderListe_Click);
            // 
            // listBoxLstListe
            // 
            this.listBoxLstListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLstListe.FormattingEnabled = true;
            this.listBoxLstListe.ItemHeight = 20;
            this.listBoxLstListe.Location = new System.Drawing.Point(27, 246);
            this.listBoxLstListe.Name = "listBoxLstListe";
            this.listBoxLstListe.Size = new System.Drawing.Size(176, 224);
            this.listBoxLstListe.TabIndex = 9;
            this.listBoxLstListe.SelectedIndexChanged += new System.EventHandler(this.listBoxLstListe_SelectedIndexChanged);
            // 
            // labelItemsCount
            // 
            this.labelItemsCount.AutoSize = true;
            this.labelItemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemsCount.Location = new System.Drawing.Point(244, 266);
            this.labelItemsCount.Name = "labelItemsCount";
            this.labelItemsCount.Size = new System.Drawing.Size(96, 20);
            this.labelItemsCount.TabIndex = 10;
            this.labelItemsCount.Text = "Items.Count";
            // 
            // labelSelectedIndex
            // 
            this.labelSelectedIndex.AutoSize = true;
            this.labelSelectedIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedIndex.Location = new System.Drawing.Point(244, 318);
            this.labelSelectedIndex.Name = "labelSelectedIndex";
            this.labelSelectedIndex.Size = new System.Drawing.Size(111, 20);
            this.labelSelectedIndex.TabIndex = 11;
            this.labelSelectedIndex.Text = "SelectedIndex";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(244, 364);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(39, 20);
            this.labelText.TabIndex = 12;
            this.labelText.Text = "Text";
            // 
            // textBoxItemsCount
            // 
            this.textBoxItemsCount.Enabled = false;
            this.textBoxItemsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemsCount.Location = new System.Drawing.Point(366, 263);
            this.textBoxItemsCount.Name = "textBoxItemsCount";
            this.textBoxItemsCount.Size = new System.Drawing.Size(38, 26);
            this.textBoxItemsCount.TabIndex = 13;
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.Enabled = false;
            this.textBoxSelectedIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(366, 315);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(38, 26);
            this.textBoxSelectedIndex.TabIndex = 14;
            // 
            // textBoxSelectedText
            // 
            this.textBoxSelectedText.Enabled = false;
            this.textBoxSelectedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelectedText.Location = new System.Drawing.Point(366, 361);
            this.textBoxSelectedText.Name = "textBoxSelectedText";
            this.textBoxSelectedText.Size = new System.Drawing.Size(109, 26);
            this.textBoxSelectedText.TabIndex = 15;
            // 
            // errorProviderAjoutListe
            // 
            this.errorProviderAjoutListe.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderAjoutListe.ContainerControl = this;
            // 
            // errorProviderIndex
            // 
            this.errorProviderIndex.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderIndex.ContainerControl = this;
            // 
            // ListBoxBases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(520, 509);
            this.Controls.Add(this.textBoxSelectedText);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.textBoxItemsCount);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelSelectedIndex);
            this.Controls.Add(this.labelItemsCount);
            this.Controls.Add(this.listBoxLstListe);
            this.Controls.Add(this.buttonViderListe);
            this.Controls.Add(this.buttonSelectionner);
            this.Controls.Add(this.buttonAjoutListe);
            this.Controls.Add(this.textBoxIndexElement);
            this.Controls.Add(this.textBoxNouvelElement);
            this.Controls.Add(this.labelProprietes);
            this.Controls.Add(this.labelIndexElement);
            this.Controls.Add(this.labelLstListe);
            this.Controls.Add(this.labelNouvelElement);
            this.Name = "ListBoxBases";
            this.Text = "Les listes et leurs proprietes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAjoutListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNouvelElement;
        private System.Windows.Forms.Label labelLstListe;
        private System.Windows.Forms.Label labelIndexElement;
        private System.Windows.Forms.Label labelProprietes;
        private System.Windows.Forms.TextBox textBoxNouvelElement;
        private System.Windows.Forms.TextBox textBoxIndexElement;
        private System.Windows.Forms.Button buttonAjoutListe;
        private System.Windows.Forms.Button buttonSelectionner;
        private System.Windows.Forms.Button buttonViderListe;
        private System.Windows.Forms.ListBox listBoxLstListe;
        private System.Windows.Forms.Label labelItemsCount;
        private System.Windows.Forms.Label labelSelectedIndex;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox textBoxItemsCount;
        private System.Windows.Forms.TextBox textBoxSelectedIndex;
        private System.Windows.Forms.TextBox textBoxSelectedText;
        private System.Windows.Forms.ErrorProvider errorProviderAjoutListe;
        private System.Windows.Forms.ErrorProvider errorProviderIndex;
    }
}

