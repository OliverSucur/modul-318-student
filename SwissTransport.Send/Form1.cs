using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport.Send
{
    public partial class FormSend : Form
    {
        public FormSend()
        {
            InitializeComponent();
        }

        private void btnSenden_Click(object sender, EventArgs e)
        {
            try
            {
                //Objekt der Klasse Email bekommen und Members setzen
                var email = Email.getInstance();
                email.emailTo = txtEmailTo.Text;
                email.subject = txtSubject.Text;

                //Email senden
                email.SendEmailConnections();
                //Form schliessen
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
