namespace Database {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbPerson = new System.Windows.Forms.ComboBox();
            this.bRollenListen = new System.Windows.Forms.Button();
            this.bPersonHinzufuegen = new System.Windows.Forms.Button();
            this.bPersonEntfernen = new System.Windows.Forms.Button();
            this.lbPersonenauswahl = new System.Windows.Forms.Label();
            this.cbRollen = new System.Windows.Forms.ComboBox();
            this.lbRollenauswahl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbPerson
            // 
            this.cbPerson.FormattingEnabled = true;
            this.cbPerson.Location = new System.Drawing.Point(12, 41);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(181, 21);
            this.cbPerson.TabIndex = 1;
            // 
            // bRollenListen
            // 
            this.bRollenListen.Location = new System.Drawing.Point(199, 41);
            this.bRollenListen.Name = "bRollenListen";
            this.bRollenListen.Size = new System.Drawing.Size(116, 21);
            this.bRollenListen.TabIndex = 3;
            this.bRollenListen.Text = "Rollen auflisten";
            this.bRollenListen.UseVisualStyleBackColor = true;
            // 
            // bPersonHinzufuegen
            // 
            this.bPersonHinzufuegen.Location = new System.Drawing.Point(199, 68);
            this.bPersonHinzufuegen.Name = "bPersonHinzufuegen";
            this.bPersonHinzufuegen.Size = new System.Drawing.Size(116, 21);
            this.bPersonHinzufuegen.TabIndex = 4;
            this.bPersonHinzufuegen.Text = "Person hinzufügen";
            this.bPersonHinzufuegen.UseVisualStyleBackColor = true;
            // 
            // bPersonEntfernen
            // 
            this.bPersonEntfernen.Location = new System.Drawing.Point(199, 95);
            this.bPersonEntfernen.Name = "bPersonEntfernen";
            this.bPersonEntfernen.Size = new System.Drawing.Size(116, 21);
            this.bPersonEntfernen.TabIndex = 5;
            this.bPersonEntfernen.Text = "Person entfernen";
            this.bPersonEntfernen.UseVisualStyleBackColor = true;
            // 
            // lbPersonenauswahl
            // 
            this.lbPersonenauswahl.AutoSize = true;
            this.lbPersonenauswahl.Location = new System.Drawing.Point(12, 25);
            this.lbPersonenauswahl.Name = "lbPersonenauswahl";
            this.lbPersonenauswahl.Size = new System.Drawing.Size(91, 13);
            this.lbPersonenauswahl.TabIndex = 6;
            this.lbPersonenauswahl.Text = "Personenauswahl";
            // 
            // cbRollen
            // 
            this.cbRollen.FormattingEnabled = true;
            this.cbRollen.Location = new System.Drawing.Point(381, 41);
            this.cbRollen.Name = "cbRollen";
            this.cbRollen.Size = new System.Drawing.Size(181, 21);
            this.cbRollen.TabIndex = 2;
            // 
            // lbRollenauswahl
            // 
            this.lbRollenauswahl.AutoSize = true;
            this.lbRollenauswahl.Location = new System.Drawing.Point(378, 25);
            this.lbRollenauswahl.Name = "lbRollenauswahl";
            this.lbRollenauswahl.Size = new System.Drawing.Size(76, 13);
            this.lbRollenauswahl.TabIndex = 7;
            this.lbRollenauswahl.Text = "Rollenauswahl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbRollenauswahl);
            this.Controls.Add(this.lbPersonenauswahl);
            this.Controls.Add(this.bPersonEntfernen);
            this.Controls.Add(this.bPersonHinzufuegen);
            this.Controls.Add(this.bRollenListen);
            this.Controls.Add(this.cbRollen);
            this.Controls.Add(this.cbPerson);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Benutzerverwaltung (Admin)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbPerson;
        private System.Windows.Forms.Button bRollenListen;
        private System.Windows.Forms.Button bPersonHinzufuegen;
        private System.Windows.Forms.Button bPersonEntfernen;
        private System.Windows.Forms.Label lbPersonenauswahl;
        private System.Windows.Forms.ComboBox cbRollen;
        private System.Windows.Forms.Label lbRollenauswahl;
    }
}

