using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;


namespace ShutdownTimers
{
    //string[] action = new string[]
    //    {
    //        "Lock screen",
    //        "Log off",
    //        "Hibernate",
    //        "Shutdown"
    //    };
    public partial class MainForm : Form
    {
        DateTime time;
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();

        [DllImport("user32.dll")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        public MainForm()
        {
            InitializeComponent();
            comboBoxAction.SelectedIndex = 1;
        }

        private void systemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            systemTray.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccury_Click(object sender, EventArgs e)
        {

            time = DateTime.Parse(labelTime.Text);
            if (time < DateTime.Now)
            {
                MessageBox.Show("Set another time.", "Incorrect time to shutdown!!");
            }

          //  MessageBox.Show(comboBoxAction.SelectedItem.ToString());
            this.Hide();
            systemTray.Text =comboBoxAction.SelectedItem.ToString()+ " at " + labelTime.Text;
            systemTray.Visible = true;

            MessageBox.Show(time.ToString(), comboBoxAction.SelectedItem.ToString() + "Time to shutdown");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void systemTray_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            systemTray.Visible = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            systemTray_DoubleClick(sender, e);
        }

        private void trackBarHours_ValueChanged(object sender, EventArgs e)
        {
            string hours = labelTime.Text.Split(':').First();
            string minutes = labelTime.Text.Split(':').Last();

            if (trackBarHours.Value < 10) hours = "0" + trackBarHours.Value.ToString();
            else hours = trackBarHours.Value.ToString();

            labelTime.Text = $"{hours}:{minutes}";
        }

        private void trackBarMinuts_ValueChanged(object sender, EventArgs e)
        {
            string hours = labelTime.Text.Split(':').First();
            string minutes = labelTime.Text.Split(':').Last();

            if (trackBarMinuts.Value < 10) minutes = "0" + trackBarMinuts.Value.ToString();
            else minutes = trackBarMinuts.Value.ToString();

            labelTime.Text = $"{hours}:{minutes}";
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
            //systemTray.Text = DateTime.Now.ToString();
            if(time.Hour == DateTime.Now.Hour && time.Minute == DateTime.Now.Minute && DateTime.Now.Second == 0)
            {
                // MessageBox.Show("Time to shutdown");
                switch (comboBoxAction.SelectedIndex)
                { 
                    case 0: LockWorkStation();break;
                    case 1: ExitWindowsEx(0, 0);break;
                }

            }
        }
    }
}
