using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiFormsApp
{
    public partial class MyClockSettings : Form
    {
        public MyClockSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_ClockTopMost_Click(object sender, EventArgs e)
        {
            cb_ClockTopMost.Checked = Application.OpenForms[0].TopMost = Application.OpenForms[0].TopMost?false:true;
        }
    }
}
