namespace WindowsFormsAppListBoxAndComboBox
{
    partial class FormListBoxComboBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCible = new System.Windows.Forms.ListBox();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.buttonSelectionToCible = new System.Windows.Forms.Button();
            this.buttonAllToCible = new System.Windows.Forms.Button();
            this.buttonSelectionToSource = new System.Windows.Forms.Button();
            this.buttonAllToSource = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.errorProviderTextComboBox = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cible";
            // 
            // listBoxCible
            // 
            this.listBoxCible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCible.FormattingEnabled = true;
            this.listBoxCible.ItemHeight = 16;
            this.listBoxCible.Location = new System.Drawing.Point(264, 56);
            this.listBoxCible.Name = "listBoxCible";
            this.listBoxCible.Size = new System.Drawing.Size(123, 148);
            this.listBoxCible.TabIndex = 2;
            this.listBoxCible.SelectedIndexChanged += new System.EventHandler(this.listBoxCible_SelectedIndexChanged);
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(12, 55);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSource.TabIndex = 3;
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            this.comboBoxSource.TextUpdate += new System.EventHandler(this.comboBoxSource_TextUpdate);
            // 
            // buttonSelectionToCible
            // 
            this.buttonSelectionToCible.Enabled = false;
            this.buttonSelectionToCible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectionToCible.Location = new System.Drawing.Point(173, 56);
            this.buttonSelectionToCible.Name = "buttonSelectionToCible";
            this.buttonSelectionToCible.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectionToCible.TabIndex = 4;
            this.buttonSelectionToCible.Text = ">";
            this.buttonSelectionToCible.UseVisualStyleBackColor = true;
            this.buttonSelectionToCible.Click += new System.EventHandler(this.buttonSectionToCible_Click);
            // 
            // buttonAllToCible
            // 
            this.buttonAllToCible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllToCible.Location = new System.Drawing.Point(173, 85);
            this.buttonAllToCible.Name = "buttonAllToCible";
            this.buttonAllToCible.Size = new System.Drawing.Size(75, 23);
            this.buttonAllToCible.TabIndex = 5;
            this.buttonAllToCible.Text = ">>";
            this.buttonAllToCible.UseVisualStyleBackColor = true;
            this.buttonAllToCible.Click += new System.EventHandler(this.buttonAllToCible_Click);
            // 
            // buttonSelectionToSource
            // 
            this.buttonSelectionToSource.Enabled = false;
            this.buttonSelectionToSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectionToSource.Location = new System.Drawing.Point(173, 139);
            this.buttonSelectionToSource.Name = "buttonSelectionToSource";
            this.buttonSelectionToSource.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectionToSource.TabIndex = 6;
            this.buttonSelectionToSource.Text = "<";
            this.buttonSelectionToSource.UseVisualStyleBackColor = true;
            this.buttonSelectionToSource.Click += new System.EventHandler(this.buttonSelectionToSource_Click);
            // 
            // buttonAllToSource
            // 
            this.buttonAllToSource.Enabled = false;
            this.buttonAllToSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllToSource.Location = new System.Drawing.Point(173, 168);
            this.buttonAllToSource.Name = "buttonAllToSource";
            this.buttonAllToSource.Size = new System.Drawing.Size(75, 23);
            this.buttonAllToSource.TabIndex = 7;
            this.buttonAllToSource.Text = "<<";
            this.buttonAllToSource.UseVisualStyleBackColor = true;
            this.buttonAllToSource.Click += new System.EventHandler(this.buttonAllToSource_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.AutoSize = true;
            this.buttonUp.Enabled = false;
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(282, 210);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(43, 41);
            this.buttonUp.TabIndex = 8;
            this.buttonUp.Text = "▲";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.AutoSize = true;
            this.buttonDown.Enabled = false;
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.Location = new System.Drawing.Point(331, 210);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(43, 41);
            this.buttonDown.TabIndex = 9;
            this.buttonDown.Text = "▼";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // errorProviderTextComboBox
            // 
            this.errorProviderTextComboBox.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTextComboBox.ContainerControl = this;
            // 
            // FormListBoxComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 269);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonAllToSource);
            this.Controls.Add(this.buttonSelectionToSource);
            this.Controls.Add(this.buttonAllToCible);
            this.Controls.Add(this.buttonSelectionToCible);
            this.Controls.Add(this.comboBoxSource);
            this.Controls.Add(this.listBoxCible);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormListBoxComboBox";
            this.Text = "Les listes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTextComboBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxCible;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.Button buttonSelectionToCible;
        private System.Windows.Forms.Button buttonAllToCible;
        private System.Windows.Forms.Button buttonSelectionToSource;
        private System.Windows.Forms.Button buttonAllToSource;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.ErrorProvider errorProviderTextComboBox;
    }
}

