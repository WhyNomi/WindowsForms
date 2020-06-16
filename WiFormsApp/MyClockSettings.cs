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
        Form1 parent;
        public MyClockSettings(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.cb_ClockTopMost.Checked = parent.AlwaysOnTopToolStripMenuItem.Checked;
            this.cb_ShowData.Checked = parent.Lb_date.Visible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_ClockTopMost_Click(object sender, EventArgs e)
        {
            //   cb_ClockTopMost.Checked = Application.OpenForms[0].TopMost = Application.OpenForms[0].TopMost?false:true;
            parent.alwaysOnTopToolStripMenuItem_Click(sender, e);
            cb_ClockTopMost.Checked = parent.AlwaysOnTopToolStripMenuItem.Checked;
        }

        private void cb_ShowData_Click(object sender, EventArgs e)
        {
            this.cb_ShowData.Checked = parent.Lb_date.Visible =parent.Lb_date.Visible ? false : true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(cb_ClockTopMost.Checked)cb_ClockTopMost_Click(sender, e);
            if(cb_ShowData.Checked)cb_ShowData_Click(sender, e);
            this.Close();
        }
    }
}
