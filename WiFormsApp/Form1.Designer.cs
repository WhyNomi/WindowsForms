namespace WiFormsApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_time = new System.Windows.Forms.Label();
            this.main_timer = new System.Windows.Forms.Timer(this.components);
            this.second_timer = new System.Windows.Forms.Timer(this.components);
            this.cb_show_date = new System.Windows.Forms.CheckBox();
            this.lb_date = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.BackColor = System.Drawing.Color.Transparent;
            this.lb_time.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_time.ForeColor = System.Drawing.Color.Ivory;
            this.lb_time.Location = new System.Drawing.Point(391, 77);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(94, 45);
            this.lb_time.TabIndex = 1;
            this.lb_time.Text = "Time";
            // 
            // main_timer
            // 
            this.main_timer.Enabled = true;
            this.main_timer.Interval = 1000;
            this.main_timer.Tick += new System.EventHandler(this.main_timer_Tick);
            // 
            // second_timer
            // 
            this.second_timer.Enabled = true;
            this.second_timer.Interval = 1000;
            // 
            // cb_show_date
            // 
            this.cb_show_date.AutoSize = true;
            this.cb_show_date.BackColor = System.Drawing.Color.Transparent;
            this.cb_show_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_show_date.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_show_date.ForeColor = System.Drawing.Color.Ivory;
            this.cb_show_date.Location = new System.Drawing.Point(399, 203);
            this.cb_show_date.Name = "cb_show_date";
            this.cb_show_date.Size = new System.Drawing.Size(179, 44);
            this.cb_show_date.TabIndex = 2;
            this.cb_show_date.Text = "Show date";
            this.cb_show_date.UseVisualStyleBackColor = false;
            this.cb_show_date.CheckedChanged += new System.EventHandler(this.cb_show_date_CheckedChanged);
            this.cb_show_date.MouseLeave += new System.EventHandler(this.cb_show_date_MouseLeave);
            this.cb_show_date.MouseHover += new System.EventHandler(this.cb_show_date_MouseHover);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.BackColor = System.Drawing.Color.Transparent;
            this.lb_date.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_date.ForeColor = System.Drawing.Color.Ivory;
            this.lb_date.Location = new System.Drawing.Point(280, 148);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(90, 45);
            this.lb_date.TabIndex = 4;
            this.lb_date.Text = "Date";
            this.lb_date.Visible = false;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.Ivory;
            this.Welcome.Location = new System.Drawing.Point(280, 9);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(360, 47);
            this.Welcome.TabIndex = 5;
            this.Welcome.Text = "Добро пожаловать!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::WiFormsApp.Properties.Resources.chemistry__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(673, 259);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.cb_show_date);
            this.Controls.Add(this.lb_time);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1255, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TIME&DATA";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.GrayText;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Timer main_timer;
        private System.Windows.Forms.Timer second_timer;
        private System.Windows.Forms.CheckBox cb_show_date;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label Welcome;
    }
}

