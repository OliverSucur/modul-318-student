using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport.UI
{
    public partial class Form : Component
    {
        public Form()
        {
            InitializeComponent();
        }

        public Form(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
