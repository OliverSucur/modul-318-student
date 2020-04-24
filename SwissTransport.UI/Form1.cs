using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataView view;
        private void btnVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnVerbindungenSuchen.Text == "Verbindungen suchen")
                {
                    FindConnections();
                }

                if (btnVerbindungenSuchen.Text == "Station suchen")
                {
                    FindStation();
                }

                if (btnVerbindungenSuchen.Text == "Station in der Nähe suchen")
                {
                    FindNearestStations();
                }

                if (btnVerbindungenSuchen.Text == "Verbindungen ab einer Haltestelle suchen")
                {
                    FindConnectionsOfOneStation();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void FindConnections()
        {
            //Instanzierung der Variablen/Objekten
            var transport = new Transport();
            var connections = transport.GetConnections(txtHaltestelleVon.Text, txtHaltestelleBis.Text, datePicker.Text, timePicker.Text);

            DataTable datatable;
            DataColumn column;
            DataRow row;

            datatable = new DataTable();

            //Spaltengenerierung
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Von";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Nach";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Abfahrtszeit";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Ankunftszeit";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Dauer";
            datatable.Columns.Add(column);

            string arrival = "";
            string departure = "";
            string duration = "";

            //Eine Liste iterieren mit den Verbindungen
            foreach (var i in connections.ConnectionList)
            {
                //Stringbearbeitung
                arrival = i.To.Arrival;
                arrival = arrival.Remove(arrival.Length - 8);
                arrival = arrival.Substring(11);
                duration = i.Duration.Substring(3, 8).Replace(":00", "min").Replace(":", "h");

                departure = i.From.Departure;
                departure = departure.Remove(departure.Length - 8);
                departure = departure.Substring(11);

                //Zeilengenerierung der Tabelle
                row = datatable.NewRow();
                row["Von"] = i.From.Station.Name;
                row["Ankunftszeit"] = arrival;
                row["Nach"] = i.To.Station.Name;
                row["Abfahrtszeit"] = departure;
                row["Dauer"] = duration;

                datatable.Rows.Add(row);
            }

            //Eine View der Tabelle generieren
            view = new DataView(datatable);
            dataGridView1.DataSource = view;

            //Objektinstanzierung der Email und der Datensetzung des Objekts
            var email = Email.getInstance();
            email.data = GetDataGridData();
        }
        public void FindStation()
        {
            //Variable-/Objektinstanzierung        
            var transport = new Transport();
            var stations = transport.GetStations(txtHaltestelleVon.Text);

            List<Station> station = new List<Station>();

            //Stationen werden zur List station hinzugefügt
            foreach (var i in stations.StationList)
            {
                station.Add(i);
            }

            //Objektabfrage der Koordinaten
            var coordinate = station[0].Coordinate;

            var xCoord = coordinate.XCoordinate;
            var yCoord = coordinate.YCoordinate;

            //Den Standort einer Station über ein neues Fenster abfragen
            System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + xCoord + "+" + yCoord);
        }
        public void FindConnectionsOfOneStation()
        {
            //Variable-/Objektinstanzierung
            DataTable datatable;
            DataColumn column;
            DataRow row;

            var transport = new Transport();
            var stationboard = transport.GetStationBoard(txtHaltestelleVon.Text);

            datatable = new DataTable();

            //Spaltengenerierung der Tabelle
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Nach";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Abfahrtsdatum";
            datatable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Abfahrtszeit";
            datatable.Columns.Add(column);

            var departureTime = "";
            var departureDate = "";

            foreach (var i in stationboard.Entries)
            {
                //Iteration von der List Entries
                departureDate = i.Stop.Departure.ToString().Substring(0, 10);
                departureTime = i.Stop.Departure.ToString().Substring(10, 6);

                //Zeilensetzung
                row = datatable.NewRow();
                row["Nach"] = i.To;
                row["Abfahrtszeit"] = departureTime;
                row["Abfahrtsdatum"] = departureDate;

                datatable.Rows.Add(row);
            }

            //View der Tabelle erstellen und ausgeben
            view = new DataView(datatable);
            dataGridView1.DataSource = view;
        }
        public string GetDataGridData()
        {
            //Formatiert den Inhalt des DataGrids zu String
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewRow rowTemp in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in rowTemp.Cells)
                {
                    sb.Append(cell.Value);
                    sb.Append(';');
                }
                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public void FindNearestStations()
        {
            //Koordinater des momentanen Standorts des Users bekommen
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = watcher.Position.Location;

            //Verzweigung, um Fehler zu vermeiden
            if (coord.IsUnknown != true)
            {
                //Link mit deinen Koordinaten öffnen
                System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + coord.Latitude + "+" + coord.Longitude);
            }
            else
            {
                //Ausgabe bei Fehler
                MessageBox.Show("Koordinaten sind unbekannt.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Die Listen verstecken
            listHaltestelleVon.Hide();
            listHaltestelleBis.Hide();
        }

        private void listHaltestelleBis_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Updaten der Haltestelleneingabe der Liste
            Station selectedItem = (Station)listHaltestelleBis.SelectedItem;
            txtHaltestelleBis.Text = selectedItem.Name;
            listHaltestelleBis.Hide();
        }

        private void txtHaltestelleVon_Suchen(object sender, EventArgs e)
        {
            //Input der Stationen für die Liste
            var transport = new Transport();
            var station = new Stations();

            station = transport.GetStations(txtHaltestelleVon.Text);

            listHaltestelleVon.DataSource = station.StationList;
            listHaltestelleVon.DisplayMember = "Name";

            listHaltestelleVon.Show();
        }

        private void listHaltestelleVon_Click(object sender, EventArgs e)
        {
            //Updaten der Haltestelleneingabe der Liste
            Station selectedItem = (Station)listHaltestelleVon.SelectedItem;
            txtHaltestelleVon.Text = selectedItem.Name;
            listHaltestelleVon.Hide();
        }

        private void checkVerbindungen_CheckedChanged(object sender, EventArgs e)
        {
            //Kontrolle und Setzung der Checkboxen, falls noch andere checked sind
            if (checkVerbindungen.Checked)
            {
                txtHaltestelleBis.Text = "";
                listHaltestelleBis.Hide();
                btnVerbindungenSuchen.Text = "Verbindungen ab einer Haltestelle suchen";
                txtHaltestelleBis.ReadOnly = true;
            }
            else
            {
                btnVerbindungenSuchen.Text = "Verbindungen suchen";
                txtHaltestelleBis.ReadOnly = false;
            }
        }

        private void txtHaltestelleBis_TextChanged(object sender, EventArgs e)
        {
            //Updaten der Liste bei der Veränderung des Textes in der TextBox
            var transport = new Transport();
            var station = new Stations();

            station = transport.GetStations(txtHaltestelleBis.Text);

            listHaltestelleBis.DataSource = station.StationList;
            listHaltestelleBis.DisplayMember = "Name";

            listHaltestelleBis.Show();
        }

        private void checkOrtschaft_CheckedChanged(object sender, EventArgs e)
        {
            //Kontrolle und Setzung der Checkboxen, falls noch andere checked sind
            if (checkOrtschaft.Checked)
            {
                checkOrtschaft.Checked = true;
                txtHaltestelleBis.Text = "";
                listHaltestelleBis.Hide();
                txtHaltestelleBis.ReadOnly = true;
                btnVerbindungenSuchen.Text = "Station suchen";
            }
            else
            {
                txtHaltestelleBis.ReadOnly = false;
                btnVerbindungenSuchen.Text = "Verbindungen suchen";
                return;
            }
        }

        private void checkNaehe_CheckedChanged(object sender, EventArgs e)
        {
            //Kontrolle und Setzung der Checkboxen, falls noch andere checked sind
            if (checkNaehe.Checked)
            {
                txtHaltestelleBis.Text = "";
                listHaltestelleBis.Hide();
                txtHaltestelleVon.ReadOnly = true;
                txtHaltestelleBis.ReadOnly = true;
                btnVerbindungenSuchen.Text = "Station in der Nähe suchen";
            }
            else
            {
                txtHaltestelleVon.ReadOnly = false;
                txtHaltestelleBis.ReadOnly = false;
                btnVerbindungenSuchen.Text = "Verbindungen suchen";
                return;
            }
        }

        private void btnWeiterleiten_Click(object sender, EventArgs e)
        {
            //Form zur Sendung der E-Mail öffnen
            SwissTransport.Send.FormSend form = new SwissTransport.Send.FormSend();
            form.Show();
        }

        private void listHaltestelleVon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Auswahl der Liste einfügen
            Station selectedItem = (Station)listHaltestelleVon.SelectedItem;
            txtHaltestelleVon.Text = selectedItem.Name;
            listHaltestelleVon.Hide();
        }

        private void btnMeinung_Click(object sender, EventArgs e)
        {
            //Form zur Sendung der Meinung öffnen
            SwissTransport.Kritik.Form1 form = new SwissTransport.Kritik.Form1();

            form.Show();
        }
    }
}
