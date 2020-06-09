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
        Font font_default;
        public Form1()
        {
            InitializeComponent();
            font_default = cb_show_date.Font;
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
            this.cb_show_date.ForeColor = Color.Red;
        }

        private void cb_show_date_MouseLeave(object sender, EventArgs e)
        {
            this.cb_show_date.Font = new Font(font_default, FontStyle.Regular);
            this.cb_show_date.ForeColor = Color.Yellow;
        }
    }
}
