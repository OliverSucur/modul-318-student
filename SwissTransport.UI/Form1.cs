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
            var transport = new Transport();

            string date = datePicker.Text;
            string time = timePicker.Text;

            DataTable datatable = new DataTable();

            DataColumn column;
            DataRow row;

            

            if (btnVerbindungenSuchen.Text == "Verbindungen suchen")
            {
                var connections = transport.GetConnections(txtHaltestelleVon.Text, txtHaltestelleBis.Text, date, time);

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

                StringBuilder sb = new StringBuilder(duration);

                foreach (var i in connections.ConnectionList)
                {
                    arrival = i.To.Arrival;
                    arrival = arrival.Remove(arrival.Length - 8);
                    arrival = arrival.Substring(11);
                    duration = i.Duration.Substring(3, 8).Replace(":00", "min").Replace(":", "h");

                    departure = i.From.Departure;
                    departure = departure.Remove(departure.Length - 8);
                    departure = departure.Substring(11);
                    
                    row = datatable.NewRow();
                    row["Von"] = i.From.Station.Name;
                    row["Ankunftszeit"] = arrival;
                    row["Nach"] = i.To.Station.Name;
                    row["Abfahrtszeit"] = departure;
                    row["Dauer"] = duration;
                    
                    datatable.Rows.Add(row);
                }

                view = new DataView(datatable);
                dataGridView1.DataSource = view;

                var email = Email.getInstance();
                email.data = GetDataGridData();
            }


            if (btnVerbindungenSuchen.Text == "Station suchen")
            {
                var stations = transport.GetStations(txtHaltestelleVon.Text);

                List<Station> station = new List<Station>();

                foreach (var i in stations.StationList)
                {
                    station.Add(i);
                }

                var coordinate = station[0].Coordinate;

                var xCoord = coordinate.XCoordinate;
                var yCoord = coordinate.YCoordinate;

                System.Diagnostics.Process.Start("https://www.google.com/maps/place/" + xCoord + "+" + yCoord);
            }

            if (btnVerbindungenSuchen.Text == "Station in der Nähe suchen")
            {
                
                GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

                watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

                GeoCoordinate coord = watcher.Position.Location;

                if (coord.IsUnknown != true)
                {
                    Console.WriteLine("Lat: {0}, Long: {1}",
                        coord.Latitude,
                        coord.Longitude);
                }
                else
                {
                    Console.WriteLine("Unknown latitude and longitude.");
                }
            }

            if (btnVerbindungenSuchen.Text == "Verbindungen ab einer Haltestelle suchen")
            {
                var stationboard = transport.GetStationBoard(txtHaltestelleVon.Text);
                dataGridView1.DataSource = stationboard.Entries;
            }

        }

        public string GetDataGridData()
        {
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
        private void Form1_Load(object sender, EventArgs e)
        {
            listHaltestelleVon.Hide();
            listHaltestelleBis.Hide();
        }

        private void listHaltestelleBis_SelectedIndexChanged(object sender, EventArgs e)
        {
            Station selectedItem = (Station)listHaltestelleBis.SelectedItem;
            txtHaltestelleBis.Text = selectedItem.Name;
            listHaltestelleBis.Hide();
        }

        private void txtHaltestelleVon_Suchen(object sender, EventArgs e)
        {
            var transport = new Transport();
            var station = new Stations();

            station = transport.GetStations(txtHaltestelleVon.Text);

            listHaltestelleVon.DataSource = station.StationList;
            listHaltestelleVon.DisplayMember = "Name";

            listHaltestelleVon.Show();
        }

        private void listHaltestelleVon_Click(object sender, EventArgs e)
        {
            Station selectedItem = (Station)listHaltestelleVon.SelectedItem;
            txtHaltestelleVon.Text = selectedItem.Name;
            listHaltestelleVon.Hide();
        }

        private void checkVerbindungen_CheckedChanged(object sender, EventArgs e)
        {
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
            var transport = new Transport();
            var station = new Stations();

            station = transport.GetStations(txtHaltestelleBis.Text);

            listHaltestelleBis.DataSource = station.StationList;
            listHaltestelleBis.DisplayMember = "Name";

            listHaltestelleBis.Show();
        }

        private void checkOrtschaft_CheckedChanged(object sender, EventArgs e)
        {
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
            if (checkNaehe.Checked)
            {
                txtHaltestelleBis.Text = "";
                listHaltestelleBis.Hide();
                txtHaltestelleBis.ReadOnly = true;
                btnVerbindungenSuchen.Text = "Station in der Nähe suchen";
            }
            else
            {
                txtHaltestelleBis.ReadOnly = false;
                btnVerbindungenSuchen.Text = "Verbindungen suchen";
                return;
            }
        }

        private void btnWeiterleiten_Click(object sender, EventArgs e)
        {
            SwissTransport.Send.FormSend form = new SwissTransport.Send.FormSend();
            form.Show();
        }

        private void listHaltestelleVon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Station selectedItem = (Station)listHaltestelleVon.SelectedItem;
            txtHaltestelleVon.Text = selectedItem.Name;
            listHaltestelleVon.Hide();
        }

        private void btnWeiterleiten_Click_1(object sender, EventArgs e)
        {
            SwissTransport.Send.FormSend form = new SwissTransport.Send.FormSend();
            form.Show();
        }

        private void btnMeinung_Click(object sender, EventArgs e)
        {
            SwissTransport.Kritik.Form1 form = new SwissTransport.Kritik.Form1();

            form.Show();
        }
    }
}
