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
    public partial class ShutdownForm : Form
    {
        Form1 parent;
        public ShutdownForm(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
            labelTimeToShutdown.Text = parent.TimeToShutDown.ToString();
        }

        private void trackBarHours_Scroll(object sender, EventArgs e)
        {
            // labelTimeToShutdown.Text = trackBarHours.Value.ToString();
            int hours = trackBarHours.Value;
            
        }
    }
}
