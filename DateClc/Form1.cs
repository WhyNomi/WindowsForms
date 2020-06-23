using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateClc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;
            labelResult.Text = $"{startDate.ToString()}\n {endDate.ToString()}";
            
            //TimeSpan ts = endDate - startDate;
            //labelResult.Text = ts.TotalDays.ToString();

            if(radioButtonYears.Checked)
            {
                if ((endDate - startDate).Days / 365 > 0)
                    labelResult.Text = (endDate.Year - startDate.Year).ToString() + " years";
                else
                    labelResult.Text = 0 + " years";
                
                
            }
            if (radioButtonMonthes.Checked)
            {
               labelResult.Text = (endDate.Month - startDate.Month).ToString() + " months";

            }
            if(radioButtonWeeks.Checked)
            {
                labelResult.Text = Math.Floor((endDate - startDate).TotalDays / 7).ToString() + " weeks";

            }
            if(radioButtonDays.Checked)
            {

            }
            if(radioButtonHours.Checked)
            {

            }
            if(radioButtonMinutes.Checked)
            {

            }

        }
    }
}
