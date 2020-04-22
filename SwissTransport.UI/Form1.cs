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
            var station = new Stations();

            station = transport.GetStations(txtHaltestelleBis.Text);

            listHaltestelleBis.DataSource = station.StationList;
            listHaltestelleBis.DisplayMember = "Name";

            listHaltestelleBis.Show();
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
    }
}
