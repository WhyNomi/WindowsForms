namespace WiFormsApp
{
    partial class ShutdownForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.labelTimeToShutdown = new System.Windows.Forms.Label();
            this.trackBarHours = new System.Windows.Forms.TrackBar();
            this.trackBarMinutes = new System.Windows.Forms.TrackBar();
            this.lb_hours = new System.Windows.Forms.Label();
            this.lb_minutes = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lock screen",
            "Log out",
            "Sleep",
            "Shotdown"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(319, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "в";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(72, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "через";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // labelTimeToShutdown
            // 
            this.labelTimeToShutdown.AutoSize = true;
            this.labelTimeToShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeToShutdown.Location = new System.Drawing.Point(150, 53);
            this.labelTimeToShutdown.Name = "labelTimeToShutdown";
            this.labelTimeToShutdown.Size = new System.Drawing.Size(57, 20);
            this.labelTimeToShutdown.TabIndex = 3;
            this.labelTimeToShutdown.Text = "label1";
            // 
            // trackBarHours
            // 
            this.trackBarHours.LargeChange = 1;
            this.trackBarHours.Location = new System.Drawing.Point(72, 96);
            this.trackBarHours.Maximum = 24;
            this.trackBarHours.Name = "trackBarHours";
            this.trackBarHours.Size = new System.Drawing.Size(259, 45);
            this.trackBarHours.TabIndex = 4;
            this.trackBarHours.Scroll += new System.EventHandler(this.trackBarHours_Scroll);
            // 
            // trackBarMinutes
            // 
            this.trackBarMinutes.LargeChange = 10;
            this.trackBarMinutes.Location = new System.Drawing.Point(72, 147);
            this.trackBarMinutes.Maximum = 60;
            this.trackBarMinutes.Name = "trackBarMinutes";
            this.trackBarMinutes.Size = new System.Drawing.Size(259, 45);
            this.trackBarMinutes.TabIndex = 5;
            // 
            // lb_hours
            // 
            this.lb_hours.AutoSize = true;
            this.lb_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_hours.Location = new System.Drawing.Point(12, 96);
            this.lb_hours.Name = "lb_hours";
            this.lb_hours.Size = new System.Drawing.Size(37, 15);
            this.lb_hours.TabIndex = 6;
            this.lb_hours.Text = "Часы";
            // 
            // lb_minutes
            // 
            this.lb_minutes.AutoSize = true;
            this.lb_minutes.Location = new System.Drawing.Point(9, 147);
            this.lb_minutes.Name = "lb_minutes";
            this.lb_minutes.Size = new System.Drawing.Size(46, 13);
            this.lb_minutes.TabIndex = 7;
            this.lb_minutes.Text = "Минуты";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(24, 214);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(128, 36);
            this.buttonApply.TabIndex = 8;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(185, 214);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 36);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ShutdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 262);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.lb_minutes);
            this.Controls.Add(this.lb_hours);
            this.Controls.Add(this.trackBarMinutes);
            this.Controls.Add(this.trackBarHours);
            this.Controls.Add(this.labelTimeToShutdown);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShutdownForm";
            this.Text = "ShutdownForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label labelTimeToShutdown;
        private System.Windows.Forms.TrackBar trackBarHours;
        private System.Windows.Forms.TrackBar trackBarMinutes;
        private System.Windows.Forms.Label lb_hours;
        private System.Windows.Forms.Label lb_minutes;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
    }
}