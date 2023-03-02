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
            this.components = new System.ComponentModel.Container();
            this.dgvTabelle = new System.Windows.Forms.DataGridView();
            this.cbPerson = new System.Windows.Forms.ComboBox();
            this.bRollenListen = new System.Windows.Forms.Button();
            this.bPersonHinzufuegen = new System.Windows.Forms.Button();
            this.bPersonEntfernen = new System.Windows.Forms.Button();
            this.lbPersonenauswahl = new System.Windows.Forms.Label();
            this.cbRollen = new System.Windows.Forms.ComboBox();
            this.lbRollenauswahl = new System.Windows.Forms.Label();
            this.bRolleEntfernen = new System.Windows.Forms.Button();
            this.bRolleHinzufuegen = new System.Windows.Forms.Button();
            this.bPersonenListen = new System.Windows.Forms.Button();
            this.ttRollenListen = new System.Windows.Forms.ToolTip(this.components);
            this.ttPersonHinzufuegen = new System.Windows.Forms.ToolTip(this.components);
            this.ttPersonEntfernen = new System.Windows.Forms.ToolTip(this.components);
            this.ttPersonenListen = new System.Windows.Forms.ToolTip(this.components);
            this.bRolleZuweisen = new System.Windows.Forms.Button();
            this.ttRolleHinzufuegen = new System.Windows.Forms.ToolTip(this.components);
            this.ttRolleEntfernen = new System.Windows.Forms.ToolTip(this.components);
            this.ttRolleZuweisen = new System.Windows.Forms.ToolTip(this.components);
            this.bAlleZuweisungenAnzeigen = new System.Windows.Forms.Button();
            this.bZuweisungEntfernen = new System.Windows.Forms.Button();
            this.ttPersonenComboBox = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpVerwaltung = new System.Windows.Forms.TabPage();
            this.tpAnfragen = new System.Windows.Forms.TabPage();
            this.bAnfragenAblehnen = new System.Windows.Forms.Button();
            this.bAnfragenAnnehmen = new System.Windows.Forms.Button();
            this.bAnfragenAktualisieren = new System.Windows.Forms.Button();
            this.bVerbindungHerstellen = new System.Windows.Forms.Button();
            this.lbServer = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbDatenbank = new System.Windows.Forms.TextBox();
            this.lbDatenbank = new System.Windows.Forms.Label();
            this.tbPasswort = new System.Windows.Forms.TextBox();
            this.lbPasswort = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbConnectionError = new System.Windows.Forms.Label();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelle)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpVerwaltung.SuspendLayout();
            this.tpAnfragen.SuspendLayout();
            this.gbConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTabelle
            // 
            this.dgvTabelle.AllowUserToAddRows = false;
            this.dgvTabelle.AllowUserToDeleteRows = false;
            this.dgvTabelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTabelle.Location = new System.Drawing.Point(12, 242);
            this.dgvTabelle.MultiSelect = false;
            this.dgvTabelle.Name = "dgvTabelle";
            this.dgvTabelle.ReadOnly = true;
            this.dgvTabelle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTabelle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabelle.Size = new System.Drawing.Size(828, 262);
            this.dgvTabelle.TabIndex = 10;
            // 
            // cbPerson
            // 
            this.cbPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPerson.FormattingEnabled = true;
            this.cbPerson.Location = new System.Drawing.Point(6, 19);
            this.cbPerson.Name = "cbPerson";
            this.cbPerson.Size = new System.Drawing.Size(181, 21);
            this.cbPerson.TabIndex = 1;
            this.ttPersonenComboBox.SetToolTip(this.cbPerson, "Personen liegen im Format \'Nachname, Vorname\' vor");
            // 
            // bRollenListen
            // 
            this.bRollenListen.Location = new System.Drawing.Point(193, 19);
            this.bRollenListen.Name = "bRollenListen";
            this.bRollenListen.Size = new System.Drawing.Size(116, 21);
            this.bRollenListen.TabIndex = 2;
            this.bRollenListen.Text = "Rollen auflisten";
            this.ttRollenListen.SetToolTip(this.bRollenListen, "Listet alle Rollen der gewählten Person.\r\nIst keine Person ausgewählt, werden all" +
        "e Zuweisungen gelistet.");
            this.bRollenListen.UseVisualStyleBackColor = true;
            this.bRollenListen.Click += new System.EventHandler(this.bRollenListen_Click);
            // 
            // bPersonHinzufuegen
            // 
            this.bPersonHinzufuegen.Location = new System.Drawing.Point(193, 46);
            this.bPersonHinzufuegen.Name = "bPersonHinzufuegen";
            this.bPersonHinzufuegen.Size = new System.Drawing.Size(116, 21);
            this.bPersonHinzufuegen.TabIndex = 3;
            this.bPersonHinzufuegen.Text = "Person hinzufügen";
            this.ttPersonHinzufuegen.SetToolTip(this.bPersonHinzufuegen, "Legt einen neuen \"Person\" Datensatz an, wenn der eingegebene Name \r\nDie ID wird a" +
        "utomatisch generiert.");
            this.bPersonHinzufuegen.UseVisualStyleBackColor = true;
            this.bPersonHinzufuegen.Click += new System.EventHandler(this.bPersonHinzufuegen_Click);
            // 
            // bPersonEntfernen
            // 
            this.bPersonEntfernen.Location = new System.Drawing.Point(193, 95);
            this.bPersonEntfernen.Name = "bPersonEntfernen";
            this.bPersonEntfernen.Size = new System.Drawing.Size(116, 21);
            this.bPersonEntfernen.TabIndex = 4;
            this.bPersonEntfernen.Text = "Person entfernen";
            this.ttPersonEntfernen.SetToolTip(this.bPersonEntfernen, "Entfernt die Person und alle mit ihr assoziierten Datensätze.");
            this.bPersonEntfernen.UseVisualStyleBackColor = true;
            this.bPersonEntfernen.Click += new System.EventHandler(this.bPersonEntfernen_Click);
            // 
            // lbPersonenauswahl
            // 
            this.lbPersonenauswahl.AutoSize = true;
            this.lbPersonenauswahl.Location = new System.Drawing.Point(6, 3);
            this.lbPersonenauswahl.Name = "lbPersonenauswahl";
            this.lbPersonenauswahl.Size = new System.Drawing.Size(91, 13);
            this.lbPersonenauswahl.TabIndex = 0;
            this.lbPersonenauswahl.Text = "Personenauswahl";
            // 
            // cbRollen
            // 
            this.cbRollen.FormattingEnabled = true;
            this.cbRollen.Location = new System.Drawing.Point(375, 19);
            this.cbRollen.Name = "cbRollen";
            this.cbRollen.Size = new System.Drawing.Size(181, 21);
            this.cbRollen.TabIndex = 6;
            // 
            // lbRollenauswahl
            // 
            this.lbRollenauswahl.AutoSize = true;
            this.lbRollenauswahl.Location = new System.Drawing.Point(372, 3);
            this.lbRollenauswahl.Name = "lbRollenauswahl";
            this.lbRollenauswahl.Size = new System.Drawing.Size(76, 13);
            this.lbRollenauswahl.TabIndex = 5;
            this.lbRollenauswahl.Text = "Rollenauswahl";
            // 
            // bRolleEntfernen
            // 
            this.bRolleEntfernen.Location = new System.Drawing.Point(562, 95);
            this.bRolleEntfernen.Name = "bRolleEntfernen";
            this.bRolleEntfernen.Size = new System.Drawing.Size(116, 21);
            this.bRolleEntfernen.TabIndex = 9;
            this.bRolleEntfernen.Text = "Rolle entfernen";
            this.ttRolleEntfernen.SetToolTip(this.bRolleEntfernen, "Entfernt die Rolle und alle mit ihr assoziierten Datensätze.");
            this.bRolleEntfernen.UseVisualStyleBackColor = true;
            this.bRolleEntfernen.Click += new System.EventHandler(this.bRolleEntfernen_Click);
            // 
            // bRolleHinzufuegen
            // 
            this.bRolleHinzufuegen.Location = new System.Drawing.Point(562, 46);
            this.bRolleHinzufuegen.Name = "bRolleHinzufuegen";
            this.bRolleHinzufuegen.Size = new System.Drawing.Size(116, 21);
            this.bRolleHinzufuegen.TabIndex = 8;
            this.bRolleHinzufuegen.Text = "Rolle hinzufügen";
            this.ttRolleHinzufuegen.SetToolTip(this.bRolleHinzufuegen, "Legt einen neuen \"Rolle\" Datensatz an, wenn die eingegebene Bezeichnung nicht exi" +
        "stiert.\r\nDie ID wird automatisch generiert.");
            this.bRolleHinzufuegen.UseVisualStyleBackColor = true;
            this.bRolleHinzufuegen.Click += new System.EventHandler(this.bRolleHinzufuegen_Click);
            // 
            // bPersonenListen
            // 
            this.bPersonenListen.Location = new System.Drawing.Point(562, 19);
            this.bPersonenListen.Name = "bPersonenListen";
            this.bPersonenListen.Size = new System.Drawing.Size(116, 21);
            this.bPersonenListen.TabIndex = 7;
            this.bPersonenListen.Text = "Personen auflisten";
            this.ttPersonenListen.SetToolTip(this.bPersonenListen, "Listet alle Personen mit der gewählten Rolle\r\nIst keine Rolle gewählt, werden all" +
        "e Zuweisungen gelistet.");
            this.bPersonenListen.UseVisualStyleBackColor = true;
            this.bPersonenListen.Click += new System.EventHandler(this.bPersonenListen_Click);
            // 
            // bRolleZuweisen
            // 
            this.bRolleZuweisen.Location = new System.Drawing.Point(699, 19);
            this.bRolleZuweisen.Name = "bRolleZuweisen";
            this.bRolleZuweisen.Size = new System.Drawing.Size(116, 21);
            this.bRolleZuweisen.TabIndex = 10;
            this.bRolleZuweisen.Text = "Rolle zuweisen";
            this.ttRolleZuweisen.SetToolTip(this.bRolleZuweisen, "Weist der gewählten Person die gewählt Rolle zu, wenn sie diese nicht bereits bes" +
        "itzt.");
            this.bRolleZuweisen.UseVisualStyleBackColor = true;
            this.bRolleZuweisen.Click += new System.EventHandler(this.bRolleZuweisen_Click);
            // 
            // bAlleZuweisungenAnzeigen
            // 
            this.bAlleZuweisungenAnzeigen.Location = new System.Drawing.Point(699, 46);
            this.bAlleZuweisungenAnzeigen.Name = "bAlleZuweisungenAnzeigen";
            this.bAlleZuweisungenAnzeigen.Size = new System.Drawing.Size(116, 34);
            this.bAlleZuweisungenAnzeigen.TabIndex = 11;
            this.bAlleZuweisungenAnzeigen.Text = "Alle Zuweisungen anzeigen";
            this.ttRolleZuweisen.SetToolTip(this.bAlleZuweisungenAnzeigen, "Weist der gewählten Person die gewählt Rolle zu, wenn sie diese nicht bereits bes" +
        "itzt.");
            this.bAlleZuweisungenAnzeigen.UseVisualStyleBackColor = true;
            this.bAlleZuweisungenAnzeigen.Click += new System.EventHandler(this.AlleZuweisungenAnzeigen);
            // 
            // bZuweisungEntfernen
            // 
            this.bZuweisungEntfernen.Location = new System.Drawing.Point(699, 95);
            this.bZuweisungEntfernen.Name = "bZuweisungEntfernen";
            this.bZuweisungEntfernen.Size = new System.Drawing.Size(116, 21);
            this.bZuweisungEntfernen.TabIndex = 12;
            this.bZuweisungEntfernen.Text = "Zuweisung entfernen";
            this.ttRolleZuweisen.SetToolTip(this.bZuweisungEntfernen, "Weist der gewählten Person die gewählt Rolle zu, wenn sie diese nicht bereits bes" +
        "itzt.");
            this.bZuweisungEntfernen.UseVisualStyleBackColor = true;
            this.bZuweisungEntfernen.Click += new System.EventHandler(this.bZuweisungEntfernen_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpVerwaltung);
            this.tabControl1.Controls.Add(this.tpAnfragen);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 152);
            this.tabControl1.TabIndex = 9;
            // 
            // tpVerwaltung
            // 
            this.tpVerwaltung.Controls.Add(this.bZuweisungEntfernen);
            this.tpVerwaltung.Controls.Add(this.bAlleZuweisungenAnzeigen);
            this.tpVerwaltung.Controls.Add(this.bRolleZuweisen);
            this.tpVerwaltung.Controls.Add(this.bRolleEntfernen);
            this.tpVerwaltung.Controls.Add(this.bRolleHinzufuegen);
            this.tpVerwaltung.Controls.Add(this.bRollenListen);
            this.tpVerwaltung.Controls.Add(this.bPersonenListen);
            this.tpVerwaltung.Controls.Add(this.cbPerson);
            this.tpVerwaltung.Controls.Add(this.lbRollenauswahl);
            this.tpVerwaltung.Controls.Add(this.cbRollen);
            this.tpVerwaltung.Controls.Add(this.lbPersonenauswahl);
            this.tpVerwaltung.Controls.Add(this.bPersonHinzufuegen);
            this.tpVerwaltung.Controls.Add(this.bPersonEntfernen);
            this.tpVerwaltung.Location = new System.Drawing.Point(4, 22);
            this.tpVerwaltung.Name = "tpVerwaltung";
            this.tpVerwaltung.Padding = new System.Windows.Forms.Padding(3);
            this.tpVerwaltung.Size = new System.Drawing.Size(820, 126);
            this.tpVerwaltung.TabIndex = 0;
            this.tpVerwaltung.Text = "Verwaltung";
            this.tpVerwaltung.UseVisualStyleBackColor = true;
            this.tpVerwaltung.Enter += new System.EventHandler(this.AlleZuweisungenAnzeigen);
            // 
            // tpAnfragen
            // 
            this.tpAnfragen.Controls.Add(this.bAnfragenAblehnen);
            this.tpAnfragen.Controls.Add(this.bAnfragenAnnehmen);
            this.tpAnfragen.Controls.Add(this.bAnfragenAktualisieren);
            this.tpAnfragen.Location = new System.Drawing.Point(4, 22);
            this.tpAnfragen.Name = "tpAnfragen";
            this.tpAnfragen.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnfragen.Size = new System.Drawing.Size(820, 126);
            this.tpAnfragen.TabIndex = 1;
            this.tpAnfragen.Text = "Anfragen";
            this.tpAnfragen.UseVisualStyleBackColor = true;
            this.tpAnfragen.Enter += new System.EventHandler(this.AlleRequestsAnzeigen);
            // 
            // bAnfragenAblehnen
            // 
            this.bAnfragenAblehnen.Location = new System.Drawing.Point(514, 6);
            this.bAnfragenAblehnen.Name = "bAnfragenAblehnen";
            this.bAnfragenAblehnen.Size = new System.Drawing.Size(300, 114);
            this.bAnfragenAblehnen.TabIndex = 2;
            this.bAnfragenAblehnen.Text = "Gewählte Anfrage(n) ablehnen";
            this.bAnfragenAblehnen.UseVisualStyleBackColor = true;
            this.bAnfragenAblehnen.Click += new System.EventHandler(this.bAnfragenAblehnen_Click);
            // 
            // bAnfragenAnnehmen
            // 
            this.bAnfragenAnnehmen.Location = new System.Drawing.Point(208, 6);
            this.bAnfragenAnnehmen.Name = "bAnfragenAnnehmen";
            this.bAnfragenAnnehmen.Size = new System.Drawing.Size(300, 114);
            this.bAnfragenAnnehmen.TabIndex = 1;
            this.bAnfragenAnnehmen.Text = "Gewählte Anfrage(n) annehmen";
            this.bAnfragenAnnehmen.UseVisualStyleBackColor = true;
            this.bAnfragenAnnehmen.Click += new System.EventHandler(this.bAnfragenAnnehmen_Click);
            // 
            // bAnfragenAktualisieren
            // 
            this.bAnfragenAktualisieren.Location = new System.Drawing.Point(6, 6);
            this.bAnfragenAktualisieren.Name = "bAnfragenAktualisieren";
            this.bAnfragenAktualisieren.Size = new System.Drawing.Size(138, 23);
            this.bAnfragenAktualisieren.TabIndex = 0;
            this.bAnfragenAktualisieren.Text = "Anfragen aktualisieren";
            this.bAnfragenAktualisieren.UseVisualStyleBackColor = true;
            this.bAnfragenAktualisieren.Click += new System.EventHandler(this.AlleRequestsAnzeigen);
            // 
            // bVerbindungHerstellen
            // 
            this.bVerbindungHerstellen.Location = new System.Drawing.Point(424, 19);
            this.bVerbindungHerstellen.Name = "bVerbindungHerstellen";
            this.bVerbindungHerstellen.Size = new System.Drawing.Size(136, 20);
            this.bVerbindungHerstellen.TabIndex = 8;
            this.bVerbindungHerstellen.Text = "Verbindung herstellen";
            this.bVerbindungHerstellen.UseVisualStyleBackColor = true;
            this.bVerbindungHerstellen.Click += new System.EventHandler(this.bVerbindungHerstellen_Click);
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(-3, 2);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(38, 13);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Server";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(0, 19);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(100, 20);
            this.tbServer.TabIndex = 4;
            this.tbServer.Enter += new System.EventHandler(this.AllesAuswaehlen);
            // 
            // tbDatenbank
            // 
            this.tbDatenbank.Location = new System.Drawing.Point(106, 19);
            this.tbDatenbank.Name = "tbDatenbank";
            this.tbDatenbank.Size = new System.Drawing.Size(100, 20);
            this.tbDatenbank.TabIndex = 5;
            this.tbDatenbank.Enter += new System.EventHandler(this.AllesAuswaehlen);
            // 
            // lbDatenbank
            // 
            this.lbDatenbank.AutoSize = true;
            this.lbDatenbank.Location = new System.Drawing.Point(103, 2);
            this.lbDatenbank.Name = "lbDatenbank";
            this.lbDatenbank.Size = new System.Drawing.Size(60, 13);
            this.lbDatenbank.TabIndex = 1;
            this.lbDatenbank.Text = "Datenbank";
            // 
            // tbPasswort
            // 
            this.tbPasswort.Location = new System.Drawing.Point(318, 19);
            this.tbPasswort.Name = "tbPasswort";
            this.tbPasswort.PasswordChar = '●';
            this.tbPasswort.Size = new System.Drawing.Size(100, 20);
            this.tbPasswort.TabIndex = 7;
            this.tbPasswort.Enter += new System.EventHandler(this.AllesAuswaehlen);
            // 
            // lbPasswort
            // 
            this.lbPasswort.AutoSize = true;
            this.lbPasswort.Location = new System.Drawing.Point(315, 2);
            this.lbPasswort.Name = "lbPasswort";
            this.lbPasswort.Size = new System.Drawing.Size(50, 13);
            this.lbPasswort.TabIndex = 3;
            this.lbPasswort.Text = "Passwort";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(212, 19);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 6;
            this.tbUser.Enter += new System.EventHandler(this.AllesAuswaehlen);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(209, 2);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(29, 13);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "User";
            // 
            // lbConnectionError
            // 
            this.lbConnectionError.AutoSize = true;
            this.lbConnectionError.ForeColor = System.Drawing.Color.Red;
            this.lbConnectionError.Location = new System.Drawing.Point(566, 22);
            this.lbConnectionError.Name = "lbConnectionError";
            this.lbConnectionError.Size = new System.Drawing.Size(0, 13);
            this.lbConnectionError.TabIndex = 11;
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.lbConnectionError);
            this.gbConnection.Controls.Add(this.tbPasswort);
            this.gbConnection.Controls.Add(this.lbPasswort);
            this.gbConnection.Controls.Add(this.tbUser);
            this.gbConnection.Controls.Add(this.lbUser);
            this.gbConnection.Controls.Add(this.tbDatenbank);
            this.gbConnection.Controls.Add(this.lbDatenbank);
            this.gbConnection.Controls.Add(this.tbServer);
            this.gbConnection.Controls.Add(this.lbServer);
            this.gbConnection.Controls.Add(this.bVerbindungHerstellen);
            this.gbConnection.Location = new System.Drawing.Point(12, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(786, 66);
            this.gbConnection.TabIndex = 12;
            this.gbConnection.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvTabelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(865, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Benutzerverwaltung (Admin)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelle)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpVerwaltung.ResumeLayout(false);
            this.tpVerwaltung.PerformLayout();
            this.tpAnfragen.ResumeLayout(false);
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabelle;
        private System.Windows.Forms.ComboBox cbPerson;
        private System.Windows.Forms.Button bRollenListen;
        private System.Windows.Forms.Button bPersonHinzufuegen;
        private System.Windows.Forms.Button bPersonEntfernen;
        private System.Windows.Forms.Label lbPersonenauswahl;
        private System.Windows.Forms.ComboBox cbRollen;
        private System.Windows.Forms.Label lbRollenauswahl;
        private System.Windows.Forms.Button bRolleEntfernen;
        private System.Windows.Forms.Button bRolleHinzufuegen;
        private System.Windows.Forms.Button bPersonenListen;
        private System.Windows.Forms.ToolTip ttRollenListen;
        private System.Windows.Forms.ToolTip ttPersonHinzufuegen;
        private System.Windows.Forms.ToolTip ttPersonEntfernen;
        private System.Windows.Forms.ToolTip ttPersonenListen;
        private System.Windows.Forms.ToolTip ttRolleHinzufuegen;
        private System.Windows.Forms.ToolTip ttRolleEntfernen;
        private System.Windows.Forms.ToolTip ttRolleZuweisen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpVerwaltung;
        private System.Windows.Forms.TabPage tpAnfragen;
        private System.Windows.Forms.Button bRolleZuweisen;
        private System.Windows.Forms.Button bAnfragenAktualisieren;
        private System.Windows.Forms.Button bAnfragenAblehnen;
        private System.Windows.Forms.Button bAnfragenAnnehmen;
        private System.Windows.Forms.Button bVerbindungHerstellen;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbDatenbank;
        private System.Windows.Forms.Label lbDatenbank;
        private System.Windows.Forms.TextBox tbPasswort;
        private System.Windows.Forms.Label lbPasswort;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbConnectionError;
        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Button bAlleZuweisungenAnzeigen;
        private System.Windows.Forms.ToolTip ttPersonenComboBox;
        private System.Windows.Forms.Button bZuweisungEntfernen;
    }
}

