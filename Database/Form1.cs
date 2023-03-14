using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Database {
    public partial class Form1 : Form {
        private MySqlConnection mySqlConnection = new MySqlConnection();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        /// <summary>
        /// Leert das DataGrid und erstellt die nötigen Spalten für das Anzeigen von Zuweisungen
        /// </summary>
        private void ResetDGVZuweisungen() {
            this.dgvTabelle.Columns.Clear();
            this.dgvTabelle.Rows.Clear();
            this.dgvTabelle.Refresh();

            this.dgvTabelle.Columns.Add("id_zuweisung", "id_zuweisung");
            this.dgvTabelle.Columns.Add("id_person", "id_person");
            this.dgvTabelle.Columns.Add("name", "name");
            this.dgvTabelle.Columns.Add("id_rolle", "id_rolle");
            this.dgvTabelle.Columns.Add("rolle", "rolle");
        }

        /// <summary>
        /// Leert das DataGrid und erstellt die nötigen Spalten für das Anzeigen von Requests
        /// </summary>
        private void ResetDGVRequests() {
            this.dgvTabelle.Columns.Clear();
            this.dgvTabelle.Rows.Clear();
            this.dgvTabelle.Refresh();

            this.dgvTabelle.Columns.Add("id_request", "id_request");
            this.dgvTabelle.Columns.Add("id_person", "id_person");
            this.dgvTabelle.Columns.Add("name", "name");
            this.dgvTabelle.Columns.Add("id_rolle", "id_rolle");
            this.dgvTabelle.Columns.Add("rolle", "rolle");
            this.dgvTabelle.Columns.Add("grund", "grund");
        }

        /// <summary>
        /// Füllt alle Zeilen aus einem MySqlDataReader in das DataGrid
        /// </summary>
        /// <param name="reader"></param>
        private void DataReaderInDataGrid(MySqlDataReader reader, int columnCount) {
            while (reader.Read()) {
                Object[] values = new Object[columnCount];
                reader.GetValues(values);
                this.dgvTabelle.Rows.Add(values);
            }
        }

        /// <summary>
        /// Liefert die ID der angegeben Person.<br/>
        /// Das nötige Format ist 'Nachname, Vorname'
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private int GetPersonenID(string name) {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            cmd.CommandText = $"SELECT id_person FROM personen WHERE name = '{name}'";
            MySqlDataReader data = cmd.ExecuteReader();
            int id_person;
            if (data.Read()) {
                id_person = (int)data.GetValue(0);
            }
            else {
                id_person = -1;
            }
            data.Close();
            return id_person;

        }

        /// <summary>
        /// Liefert die ID der angegebenen Rolle
        /// </summary>
        /// <param name="bezeichnung"></param>
        /// <returns></returns>
        private int GetRollenID(string bezeichnung) {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            cmd.CommandText = $"SELECT id_rolle FROM rollen WHERE bezeichnung = '{bezeichnung}'";
            MySqlDataReader data = cmd.ExecuteReader();
            int id_rolle;
            if (data.Read()) {
                id_rolle = (int)data.GetValue(0);
            }
            else {
                id_rolle = -1;
            }
            data.Close();
            return id_rolle;
        }

        /// <summary>
        /// Versucht mit den angegebenen Daten eine Verbindung zu einer MySQL-Datenbank zu erstellen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bVerbindungHerstellen_Click(object sender, EventArgs e) {
            // Prüft, ob alle nötigen Felder ausgefüllt sind
            if (this.tbServer.Text == "" || this.tbDatenbank.Text == "" || this.tbUser.Text == "" || this.tbPasswort.Text == "") {
                this.lbConnectionError.ForeColor = Color.Red;
                this.lbConnectionError.Text = "Alle Felder müssen ausgefüllt sein.";
                return;
            }
            // Baut die Verbindung zu der MySQL-Datenbank auf
            this.lbConnectionError.Text = "";
            string connectionString = $"server={this.tbServer.Text};database={this.tbDatenbank.Text};userid={this.tbUser.Text};password={this.tbPasswort.Text}";
            this.mySqlConnection.ConnectionString = connectionString;
            try {
                this.mySqlConnection.Open();
            }
            // Fehlermeldung, falls die Verbindung fehlschlägt
            catch (MySqlException) {
                this.lbConnectionError.ForeColor = Color.Red;
                this.lbConnectionError.Text = "Fehler beim Verbinden mit der Datenbank.\r\nBitte Eingaben prüfen.";
                return;
            }

            this.lbConnectionError.ForeColor = Color.Green;
            this.lbConnectionError.Text = "Erfolgreich verbunden.";
            this.tabControl1.Enabled = true;
            this.gbConnection.Enabled = false;
            this.VerwaltungAktualisieren();
        }

        /// <summary>
        /// Aktualisiert die Wertelisten der ComboBoxen im 'Verwaltung' Tab
        /// </summary>
        private void VerwaltungAktualisieren() {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;

            // Personenliste aktualisieren
            this.cbPerson.Items.Clear();
            this.cbPerson.Items.Add("");
            cmd.CommandText = "SELECT name FROM personen";
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read()) {
                this.cbPerson.Items.Add(data.GetValue(0));
            }
            data.Close();

            // Rollenliste aktualisieren
            this.cbRollen.Items.Clear();
            this.cbRollen.Items.Add("");
            cmd.CommandText = "SELECT bezeichnung FROM rollen";
            data = cmd.ExecuteReader();
            while (data.Read()) {
                this.cbRollen.Items.Add(data.GetValue(0));
            }
            data.Close();
        }

        /// <summary>
        /// Wählt den gesamten Text einer TextBox aus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllesAuswaehlen(object sender, EventArgs e) {
            if (sender.GetType() == typeof(TextBox)) {
                TextBox tb = (TextBox)sender;
                tb.SelectAll();
            }
        }

        /// <summary>
        /// Zeigt alle aktuellen Rollen-Zuweisungen im DataGrid an
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlleZuweisungenAnzeigen(object sender, EventArgs e) {
            ResetDGVZuweisungen();

            // Holt alle Rollen-Zuweisungen aus der Datenbank
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            cmd.CommandText = "SELECT id_zuweisung, personen.id_person, personen.name, rollen.id_rolle, rollen.bezeichnung FROM ((zuweisungen INNER JOIN personen ON zuweisungen.id_person = personen.id_person) INNER JOIN rollen ON zuweisungen.id_rolle = rollen.id_rolle)";
            MySqlDataReader data = cmd.ExecuteReader();

            DataReaderInDataGrid(data, 5);

            data.Close();
        }

        /// <summary>
        /// Zeigt alle gestellen Requests im DataGrid an
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlleRequestsAnzeigen(object sender, EventArgs e) {
            ResetDGVRequests();

            // Holt alle Requests aus der Datenbank
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            cmd.CommandText = "SELECT requests.id_request, personen.id_person, personen.name, rollen.id_rolle, rollen.bezeichnung, requests.grund FROM ((requests INNER JOIN personen ON requests.id_person = personen.id_person) INNER JOIN rollen ON requests.id_rolle = rollen.id_rolle)";
            MySqlDataReader data = cmd.ExecuteReader();

            DataReaderInDataGrid(data, 6);

            data.Close();
        }

        /// <summary>
        /// Listet alle Rollen der ausgewählten Person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRollenListen_Click(object sender, EventArgs e) {
            ResetDGVZuweisungen();


            string name = cbPerson.Text;
            int id_person = GetPersonenID(name);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            cmd.CommandText = "SELECT id_zuweisung, personen.id_person, personen.name, rollen.id_rolle, rollen.bezeichnung FROM ((zuweisungen INNER JOIN personen ON zuweisungen.id_person = personen.id_person) INNER JOIN rollen ON zuweisungen.id_rolle = rollen.id_rolle)";

            // Wenn eine Person gewählt wurde, soll nach ihr gefiltert werden
            if (name != "") {
                cmd.CommandText += $" WHERE personen.id_person = {id_person}";
            }
            MySqlDataReader data = cmd.ExecuteReader();

            DataReaderInDataGrid(data, 5);

            data.Close();
        }

        /// <summary>
        /// Listet alle Personen mit der ausgewählten Rolle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPersonenListen_Click(object sender, EventArgs e) {
            ResetDGVZuweisungen();

            string bezeichnung = cbRollen.Text;
            int id_rolle = GetRollenID(bezeichnung);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            cmd.CommandText = "SELECT id_zuweisung, personen.id_person, personen.name, rollen.id_rolle, rollen.bezeichnung FROM ((zuweisungen INNER JOIN personen ON zuweisungen.id_person = personen.id_person) INNER JOIN rollen ON zuweisungen.id_rolle = rollen.id_rolle)";

            // Wenn eine Rolle gewählt wurde, soll nach ihr gefiltert werden
            if (bezeichnung != "") {
                cmd.CommandText += $" WHERE rollen.id_rolle = {id_rolle}";
            }
            MySqlDataReader data = cmd.ExecuteReader();

            DataReaderInDataGrid(data, 5);

            data.Close();
        }

        /// <summary>
        /// Erstellt einen neuen 'Personen' Datensatz, wenn dieser noch nicht existiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPersonHinzufuegen_Click(object sender, EventArgs e) {
            string neue_person = cbPerson.Text;
            string error = "Fehler beim Anlegen einer neuen Person";

            // Die Person-ComboBox ist leer
            if (neue_person == "") {
                MessageBox.Show("Es wurde keine Person angegeben", error);
                return;
            }
            // Die Person existiert bereits in der Datenbank
            if (GetPersonenID(neue_person) != -1) {
                MessageBox.Show($"Die Person {neue_person} existiert bereits.", error);
                return;
            }

            string[] neue_person_arr = neue_person.Replace(", ", ",").Split(',');

            // Der eingegebene Name ist im falschen Format
            if (neue_person_arr.Length != 2) {
                MessageBox.Show("Eingegebener Name ist nicht im Format 'Nachname, Vorname'", error);
                return;
            }

            // Legt einen neuen Datensatz für die eingegebe Person an
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            cmd.CommandText = $"INSERT INTO personen (nachname, vorname) VALUES ('{neue_person_arr[0]}','{neue_person_arr[1]}')";
            cmd.ExecuteNonQuery();
            VerwaltungAktualisieren();
        }

        /// <summary>
        /// Erstellt einen neuen 'Rollen' Datensatz, wenn dieser noch nicht existiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRolleHinzufuegen_Click(object sender, EventArgs e) {
            string neue_rolle = cbRollen.Text;
            string error = "Fehler beim Anlegen einer neuen Rolle";

            // Die Rollen-Combobox ist leer
            if (neue_rolle == "") {
                MessageBox.Show("Es wurde keine Rolle angegeben", error);
                return;
            }
            // Die Rolle existiert bereits in der Datenbank
            if (GetRollenID(neue_rolle) != -1) {
                MessageBox.Show($"Die Rolle {neue_rolle} existiert bereits.", error);
                return;
            }

            // Legt einen neuen Datensatz für die eingegebene Rolle an
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            cmd.CommandText = $"INSERT INTO rollen (bezeichnung) VALUES ('{neue_rolle}')";
            cmd.ExecuteNonQuery();
            VerwaltungAktualisieren();
        }

        /// <summary>
        /// Löscht die gewählte Person und alle mit ihr assoziierten Datensätze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bPersonEntfernen_Click(object sender, EventArgs e) {
            string person = cbPerson.Text;
            int id_person = GetPersonenID(person);


            if (id_person == -1) {
                MessageBox.Show("Die angegebene Person existiert nicht", "Fehler beim Löschen einer Person");
                return;
            }

            // Bestätigungs-Dialog
            var confirmation = MessageBox.Show($"Soll die Person '{person}', sowie alle mit ihr assoziierten \r\nDatensätze wirklich gelöscht werden?", "Bestätigung", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.No) {
                return;
            }

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            // Löscht alle Requests, die von der angegebenen Person getätigt wurden
            cmd.CommandText = $"DELETE FROM requests WHERE id_person = '{id_person}'";
            cmd.ExecuteNonQuery();
            // Löscht alle Rollen-Zuweisungen mit der angegebenen Person
            cmd.CommandText = $"DELETE FROM zuweisungen WHERE id_person = '{id_person}'";
            cmd.ExecuteNonQuery();
            // Löscht den 'Person' Datensatz
            cmd.CommandText = $"DELETE FROM personen WHERE name = '{person}'";
            cmd.ExecuteNonQuery();
            // Aktualisiert die GUI
            VerwaltungAktualisieren();
            AlleZuweisungenAnzeigen(null, null);
            this.cbPerson.Text = "";
        }


        /// <summary>
        /// Löscht die gewählte Rolle und alle mit ihr assoziierten Datensätze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRolleEntfernen_Click(object sender, EventArgs e) {
            string rolle = cbRollen.Text;
            int id_rolle = GetRollenID(rolle);

            if (id_rolle == -1) {
                MessageBox.Show("Die angegebene Rolle existiert nicht", "Fehler beim Löschen einer Rolle");
                return;
            }

            // Bestätigungs-Dialog
            var confirmation = MessageBox.Show($"Soll die Rolle '{rolle}', sowie alle mit ihr assoziierten \r\nDatensätze wirklich gelöscht werden?", "Bestätigung", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.No) {
                return;
            }

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            // Löscht alle Requests, die die angegebene Rolle anfragen
            cmd.CommandText = $"DELETE FROM requests WHERE id_rolle = '{id_rolle}'";
            cmd.ExecuteNonQuery();
            // Löscht alle Zuweisungen mit der angegebenen Rolle
            cmd.CommandText = $"DELETE FROM zuweisungen WHERE id_rolle = '{id_rolle}'";
            cmd.ExecuteNonQuery();
            // Löscht den 'Rolle' Datensatz
            cmd.CommandText = $"DELETE FROM rollen WHERE bezeichnung = '{id_rolle}'";
            cmd.ExecuteNonQuery();
            // Aktualisiert die GUI
            VerwaltungAktualisieren();
            AlleZuweisungenAnzeigen(null, null);
            this.cbRollen.Text = "";
        }

        /// <summary>
        /// Erstellt eine neue Zuweisung zwischen der gewählten Person und der gewählten Rolle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRolleZuweisen_Click(object sender, EventArgs e) {

            // Prüfen ob Zuweisung getätigt werden kann
            string error = "Fehler beim Zuweisen der Rolle";
            if (this.cbPerson.Text == "") {
                MessageBox.Show("Keine Person ausgewählt", error);
                return;
            }
            if (this.cbRollen.Text == "") {
                MessageBox.Show("Keine Rolle ausgewählt", error);
                return;
            }
            int id_person = GetPersonenID(this.cbPerson.Text);
            if (id_person == -1) {
                MessageBox.Show("Die gewählte Person liegt nicht in der Datenbank vor", error);
                return;
            }
            int id_rolle = GetRollenID(this.cbRollen.Text);
            if (id_rolle == -1) {
                MessageBox.Show("Die gewählte Rolle liegt nicht in der Datenbank vor", error);
                return;
            }

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;

            cmd.CommandText = $"SELECT * FROM zuweisungen WHERE id_person = {id_person} AND id_rolle = {id_rolle}";
            MySqlDataReader data = cmd.ExecuteReader();

            if (data.Read()) {
                MessageBox.Show("Die gewählte Person besitzt die gewählte Rolle bereits", error);
                data.Close();
                return;
            }
            data.Close();

            // Zuweisung wird erstellt
            cmd.CommandText = $"INSERT INTO zuweisungen (id_person, id_rolle) VALUES ({id_person},{id_rolle})";
            cmd.ExecuteNonQuery();
            bRollenListen_Click(null, null);
        }

        private void bZuweisungEntfernen_Click(object sender, EventArgs e) {
            // Prüfen, ob die gewählte Zuweisung entfernt werden kann
            string error = "Fehler beim Löschen der Zuweisung";
            if (this.cbPerson.Text == "") {
                MessageBox.Show("Keine Person ausgewählt", error);
                return;
            }
            if (this.cbRollen.Text == "") {
                MessageBox.Show("Keine Rolle ausgewählt", error);
                return;
            }
            int id_person = GetPersonenID(this.cbPerson.Text);
            if (id_person == -1) {
                MessageBox.Show("Die gewählte Person liegt nicht in der Datenbank vor", error);
                return;
            }
            int id_rolle = GetRollenID(this.cbRollen.Text);
            if (id_rolle == -1) {
                MessageBox.Show("Die gewählte Rolle liegt nicht in der Datenbank vor", error);
                return;
            }

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;

            cmd.CommandText = $"SELECT * FROM zuweisungen WHERE id_person = {id_person} AND id_rolle = {id_rolle}";
            MySqlDataReader data = cmd.ExecuteReader();

            if (!data.Read()) {
                MessageBox.Show("Die gewählte Person besitzt die gewählte Rolle nicht", error);
                data.Close();
                return;
            }
            data.Close();

            // Zuweisung wird gelöscht
            cmd.CommandText = $"DELETE FROM zuweisungen WHERE id_person = {id_person} AND id_rolle = {id_rolle}";
            cmd.ExecuteNonQuery();
            bRollenListen_Click(null, null);
        }

        private void bAnfragenAnnehmen_Click(object sender, EventArgs e) {
            // Daten aus der gewählten Rolle holen
            DataGridViewRow row = dgvTabelle.SelectedRows[0];
            ArrayList selectedRow = new ArrayList();
            foreach (DataGridViewCell cell in row.Cells) {
                string value = cell.Value.ToString();
                selectedRow.Add(value);
            }
            // Zuweisung erstellen
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            cmd.CommandText = $"INSERT INTO zuweisungen (id_person, id_rolle) VALUES ({selectedRow[1]}, {selectedRow[3]})";
            cmd.ExecuteNonQuery();
            // Anfrage löschen
            cmd.CommandText = $"DELETE FROM requests WHERE id_request = {selectedRow[0]}";
            cmd.ExecuteNonQuery();
            AlleRequestsAnzeigen(null, null);
        }

        private void bAnfragenAblehnen_Click(object sender, EventArgs e) {
            // Daten aus der gewählten Reihe holen
            DataGridViewRow row = dgvTabelle.SelectedRows[0];
            ArrayList selectedRow = new ArrayList();
            foreach (DataGridViewCell cell in row.Cells) {
                string value = cell.Value.ToString();
                selectedRow.Add(value);
            }
            // Anfrage löschen
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            cmd.CommandText = $"DELETE FROM requests WHERE id_request = {selectedRow[0]}";
            cmd.ExecuteNonQuery();
            AlleRequestsAnzeigen(null, null);
        }

        private void bExportJSON_Click(object sender, EventArgs e) {
            Dictionary<string, Dictionary<string, object>> json_dict = new Dictionary<string, Dictionary<string, object>>();
            // Sammelt alle Zuweisungen
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.mySqlConnection;
            cmd.CommandText = "select personen.id_person, personen.vorname, personen.nachname, rollen.bezeichnung from zuweisungen inner join personen on zuweisungen.id_person = personen.id_person inner join rollen on zuweisungen.id_rolle = rollen.id_rolle";
            MySqlDataReader zuweisungen = cmd.ExecuteReader();
            // Iteriert über die Datensätze und erweitert das Dictionary
            while (zuweisungen.Read()) {
                // Datensatz to Array
                object[] data = new object[zuweisungen.FieldCount];
                zuweisungen.GetValues(data);
                // Wenn die ID der Person nicht bereits ein Key des Dictionaries ist, wird das dazugehörige Directory initialisiert
                if (!json_dict.ContainsKey(data[0].ToString())) {
                    json_dict[data[0].ToString()] = new Dictionary<string, object> {
                        {"vorname", data[1]},
                        {"nachname", data[2]},
                        {"rollen", new List<string>{data[3].ToString()}}
                    };
                }
                // Wenn die ID der Person bereits ein Key des Dictionaries ist, wird das die Rolle zu dem Rollen-Array hinzugefügt
                else {
                    ((List<string>)json_dict[data[0].ToString()]["rollen"]).Add(data[3].ToString());
                }
            }
            // Konvertiert das Dictionary-Objekt zu einem String im JSON-Format
            string json_string = JsonConvert.SerializeObject(json_dict, Formatting.Indented);
            File.WriteAllText("../../../export.json", json_string);
            zuweisungen.Close();
        }
    }
}
