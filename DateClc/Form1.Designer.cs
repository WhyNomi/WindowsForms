namespace DateClc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.radioButtonYears = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthes = new System.Windows.Forms.RadioButton();
            this.radioButtonWeeks = new System.Windows.Forms.RadioButton();
            this.radioButtonDays = new System.Windows.Forms.RadioButton();
            this.radioButtonHours = new System.Windows.Forms.RadioButton();
            this.radioButtonMinutes = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.radioButtonFull = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(12, 12);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(253, 12);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // radioButtonYears
            // 
            this.radioButtonYears.AutoSize = true;
            this.radioButtonYears.Location = new System.Drawing.Point(12, 46);
            this.radioButtonYears.Name = "radioButtonYears";
            this.radioButtonYears.Size = new System.Drawing.Size(52, 17);
            this.radioButtonYears.TabIndex = 2;
            this.radioButtonYears.TabStop = true;
            this.radioButtonYears.Text = "Years";
            this.radioButtonYears.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonthes
            // 
            this.radioButtonMonthes.AutoSize = true;
            this.radioButtonMonthes.Location = new System.Drawing.Point(12, 69);
            this.radioButtonMonthes.Name = "radioButtonMonthes";
            this.radioButtonMonthes.Size = new System.Drawing.Size(66, 17);
            this.radioButtonMonthes.TabIndex = 3;
            this.radioButtonMonthes.TabStop = true;
            this.radioButtonMonthes.Text = "Monthes";
            this.radioButtonMonthes.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeeks
            // 
            this.radioButtonWeeks.AutoSize = true;
            this.radioButtonWeeks.Location = new System.Drawing.Point(12, 92);
            this.radioButtonWeeks.Name = "radioButtonWeeks";
            this.radioButtonWeeks.Size = new System.Drawing.Size(59, 17);
            this.radioButtonWeeks.TabIndex = 4;
            this.radioButtonWeeks.TabStop = true;
            this.radioButtonWeeks.Text = "Weeks";
            this.radioButtonWeeks.UseVisualStyleBackColor = true;
            // 
            // radioButtonDays
            // 
            this.radioButtonDays.AutoSize = true;
            this.radioButtonDays.Location = new System.Drawing.Point(12, 115);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(49, 17);
            this.radioButtonDays.TabIndex = 5;
            this.radioButtonDays.TabStop = true;
            this.radioButtonDays.Text = "Days";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // radioButtonHours
            // 
            this.radioButtonHours.AutoSize = true;
            this.radioButtonHours.Location = new System.Drawing.Point(12, 138);
            this.radioButtonHours.Name = "radioButtonHours";
            this.radioButtonHours.Size = new System.Drawing.Size(53, 17);
            this.radioButtonHours.TabIndex = 6;
            this.radioButtonHours.TabStop = true;
            this.radioButtonHours.Text = "Hours";
            this.radioButtonHours.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinutes
            // 
            this.radioButtonMinutes.AutoSize = true;
            this.radioButtonMinutes.Location = new System.Drawing.Point(12, 161);
            this.radioButtonMinutes.Name = "radioButtonMinutes";
            this.radioButtonMinutes.Size = new System.Drawing.Size(62, 17);
            this.radioButtonMinutes.TabIndex = 7;
            this.radioButtonMinutes.TabStop = true;
            this.radioButtonMinutes.Text = "Minutes";
            this.radioButtonMinutes.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(263, 163);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(127, 38);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(148, 50);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(100, 40);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "label1";
            // 
            // radioButtonFull
            // 
            this.radioButtonFull.AutoSize = true;
            this.radioButtonFull.Location = new System.Drawing.Point(12, 184);
            this.radioButtonFull.Name = "radioButtonFull";
            this.radioButtonFull.Size = new System.Drawing.Size(62, 17);
            this.radioButtonFull.TabIndex = 10;
            this.radioButtonFull.TabStop = true;
            this.radioButtonFull.Text = "Full Info";
            this.radioButtonFull.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 207);
            this.Controls.Add(this.radioButtonFull);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.radioButtonMinutes);
            this.Controls.Add(this.radioButtonHours);
            this.Controls.Add(this.radioButtonDays);
            this.Controls.Add(this.radioButtonWeeks);
            this.Controls.Add(this.radioButtonMonthes);
            this.Controls.Add(this.radioButtonYears);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.RadioButton radioButtonYears;
        private System.Windows.Forms.RadioButton radioButtonMonthes;
        private System.Windows.Forms.RadioButton radioButtonWeeks;
        private System.Windows.Forms.RadioButton radioButtonDays;
        private System.Windows.Forms.RadioButton radioButtonHours;
        private System.Windows.Forms.RadioButton radioButtonMinutes;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.RadioButton radioButtonFull;
    }
}

