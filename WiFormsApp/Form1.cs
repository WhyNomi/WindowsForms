using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiFormsApp
{
    public partial class Form1 : Form
    {
        DateTime timeToShutdown;
        Font font_default;
        public System.Windows.Forms.ToolStripMenuItem AlwaysOnTopToolStripMenuItem
        {
            get
            {
                return alwaysOnTopToolStripMenuItem;
            }
        }

        public Label Lb_date
        {
            get
            {
                return lb_date;
            }
            set
            {
                lb_date = value;
            }
        }

        public DateTime TimeToShutDown
        {
            get => timeToShutdown;
            set => timeToShutdown = value;
        }

        ///////////////////////////////////////////////////////


        public Form1()
        {
            InitializeComponent();
            font_default = cb_show_date.Font;
            timeToShutdown = DateTime.MaxValue;
        }

        private void main_timer_Tick(object sender, EventArgs e)
        {
            this.lb_time.Text = DateTime.Now.ToLongTimeString(); //DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;

            this.lb_date.Text = DateTime.Now.ToLongDateString(); //DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;
        }

        private void cb_show_date_CheckedChanged(object sender, EventArgs e)
        {
            this.lb_date.Visible = this.cb_show_date.Checked;
        }

        private void cb_show_date_MouseHover(object sender, EventArgs e)
        {

            // font_default.Bold = true;
            this.cb_show_date.Font = new Font(font_default, FontStyle.Bold);
            this.cb_show_date.ForeColor = Color.Yellow;
        }

        private void cb_show_date_MouseLeave(object sender, EventArgs e)
        {
            this.cb_show_date.Font = new Font(font_default, FontStyle.Bold);
            this.cb_show_date.ForeColor = Color.Ivory;
        }

        ////////////////////////////MENU////////////////////////////////////

        public void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {

            alwaysOnTopToolStripMenuItem.Checked = this.TopMost = !TopMost;
            //this.TopMost = this.TopMost ? false : true;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MyClockSettings mcs = new MyClockSettings(this);
            mcs.Show();
        }

        private void shotdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShutdownForm sf = new ShutdownForm(this);
            sf.Show();
        }
        ////////////////////////////MENU////////////////////////////////////
    }
}
