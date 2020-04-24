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
            var email = Email.getInstance();
            email.fromName = txtFromName.Text;
            email.emailTo = txtEmailTo.Text;
            email.subject = txtSubject.Text;

            email.SendEmailConnections();
        }
    }
}
