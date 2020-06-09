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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void main_timer_Tick(object sender, EventArgs e)
        {
            this.lb_time.Text = DateTime.Now.ToLongTimeString(); //DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;

            this.lb_date.Text = DateTime.Now.ToLongDateString(); //DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year;

            //if (cb_show_date.Checked)
            //{
            //    this.lb_date.Visible = true;
            //}
            //else
            //{
            //    this.lb_date.Visible = false;
            //}

        }

        private void cb_show_date_CheckedChanged(object sender, EventArgs e)
        {
            this.lb_date.Visible = this.cb_show_date.Checked;
        }

 
    }
}
