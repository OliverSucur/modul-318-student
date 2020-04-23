using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            var transport = new Transport();

            var connections = transport.GetConnections(txtHaltestelleVon.Text, txtHaltestelleBis.Text);
            
            List<ConnectionPoint> from = new List<ConnectionPoint>();
            List<ConnectionPoint> to = new List<ConnectionPoint>();
            List<Station> stationFrom = new List<Station>();
            List<Station> stationTo = new List<Station>();

            foreach (var i in connections.ConnectionList)
            {
                from.Add(i.From);
                to.Add(i.To);
            }
            
            foreach(var i in from)
            {
                stationFrom.Add(i.Station);
            }

            foreach (var i in to)
            {
                stationTo.Add(i.Station);
            }

            DataTable datatable = new DataTable();

            DataColumn column;
            DataRow row;
            DataView view;

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


            foreach (var i in stationFrom)
            {
                foreach (var j in stationTo)
                {
                    foreach (var k in from)
                    {
                        foreach (var l in to)
                        {
                            row = datatable.NewRow();
                            row["Von"] = i.Name;
                            row["Nach"] = j.Name;
                            row["Abfahrtszeit"] = k.ArrivalTimestamp;
                            row["Ankunftszeit"] = l.ArrivalTimestamp;
                            datatable.Rows.Add(row);
                        }
                    }                 
                }                
            }

            view = new DataView(datatable);

            dataGridView1.DataSource = view;
            
            if(btnVerbindungenSuchen.Text == "Station suchen")
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
            if(checkVerbindungen.Checked || checkNaehe.Checked){
                checkVerbindungen.Checked = false;
                checkNaehe.Checked = false;
            }

            if (checkOrtschaft.Checked)
            {
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
    }
}
