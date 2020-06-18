namespace ShutdownTimers
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.radioButtonAccurateTime = new System.Windows.Forms.RadioButton();
            this.radioButtonIn = new System.Windows.Forms.RadioButton();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMinuts = new System.Windows.Forms.Label();
            this.trackBarMinuts = new System.Windows.Forms.TrackBar();
            this.trackBarHours = new System.Windows.Forms.TrackBar();
            this.buttonAccury = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.systemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.sysTrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinuts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHours)).BeginInit();
            this.sysTrayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Items.AddRange(new object[] {
            "Lock screen",
            "Log off",
            "Hibernate",
            "Shutdown"});
            this.comboBoxAction.Location = new System.Drawing.Point(12, 12);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(182, 21);
            this.comboBoxAction.TabIndex = 0;
            // 
            // radioButtonAccurateTime
            // 
            this.radioButtonAccurateTime.AutoSize = true;
            this.radioButtonAccurateTime.Location = new System.Drawing.Point(12, 48);
            this.radioButtonAccurateTime.Name = "radioButtonAccurateTime";
            this.radioButtonAccurateTime.Size = new System.Drawing.Size(31, 17);
            this.radioButtonAccurateTime.TabIndex = 1;
            this.radioButtonAccurateTime.TabStop = true;
            this.radioButtonAccurateTime.Text = "в";
            this.radioButtonAccurateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonAccurateTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonIn
            // 
            this.radioButtonIn.AutoSize = true;
            this.radioButtonIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonIn.Location = new System.Drawing.Point(66, 48);
            this.radioButtonIn.Name = "radioButtonIn";
            this.radioButtonIn.Size = new System.Drawing.Size(57, 19);
            this.radioButtonIn.TabIndex = 2;
            this.radioButtonIn.TabStop = true;
            this.radioButtonIn.Text = "через";
            this.radioButtonIn.UseVisualStyleBackColor = true;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(213, 2);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(148, 65);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "00:00";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHours.Location = new System.Drawing.Point(12, 94);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(38, 15);
            this.labelHours.TabIndex = 4;
            this.labelHours.Text = "Часы";
            // 
            // labelMinuts
            // 
            this.labelMinuts.AutoSize = true;
            this.labelMinuts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinuts.Location = new System.Drawing.Point(12, 135);
            this.labelMinuts.Name = "labelMinuts";
            this.labelMinuts.Size = new System.Drawing.Size(54, 15);
            this.labelMinuts.TabIndex = 5;
            this.labelMinuts.Text = "Минуты";
            // 
            // trackBarMinuts
            // 
            this.trackBarMinuts.Location = new System.Drawing.Point(94, 125);
            this.trackBarMinuts.Maximum = 59;
            this.trackBarMinuts.Name = "trackBarMinuts";
            this.trackBarMinuts.Size = new System.Drawing.Size(327, 45);
            this.trackBarMinuts.TabIndex = 6;
            this.trackBarMinuts.ValueChanged += new System.EventHandler(this.trackBarMinuts_ValueChanged);
            // 
            // trackBarHours
            // 
            this.trackBarHours.LargeChange = 1;
            this.trackBarHours.Location = new System.Drawing.Point(94, 83);
            this.trackBarHours.Maximum = 23;
            this.trackBarHours.Name = "trackBarHours";
            this.trackBarHours.Size = new System.Drawing.Size(327, 45);
            this.trackBarHours.TabIndex = 6;
            this.trackBarHours.ValueChanged += new System.EventHandler(this.trackBarHours_ValueChanged);
            // 
            // buttonAccury
            // 
            this.buttonAccury.Location = new System.Drawing.Point(224, 187);
            this.buttonAccury.Name = "buttonAccury";
            this.buttonAccury.Size = new System.Drawing.Size(82, 23);
            this.buttonAccury.TabIndex = 7;
            this.buttonAccury.Text = "Применить";
            this.buttonAccury.UseVisualStyleBackColor = true;
            this.buttonAccury.Click += new System.EventHandler(this.buttonAccury_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(325, 187);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // systemTray
            // 
            this.systemTray.ContextMenuStrip = this.sysTrayContextMenu;
            this.systemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTray.Icon")));
            this.systemTray.Text = "Shutdown timer";
            this.systemTray.DoubleClick += new System.EventHandler(this.systemTray_DoubleClick);
            this.systemTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.systemTray_MouseDoubleClick);
            // 
            // sysTrayContextMenu
            // 
            this.sysTrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.sysTrayContextMenu.Name = "sysTrayContextMenu";
            this.sysTrayContextMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 226);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccury);
            this.Controls.Add(this.trackBarHours);
            this.Controls.Add(this.trackBarMinuts);
            this.Controls.Add(this.labelMinuts);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.radioButtonIn);
            this.Controls.Add(this.radioButtonAccurateTime);
            this.Controls.Add(this.comboBoxAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ShutdownTimeToShmoke";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinuts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHours)).EndInit();
            this.sysTrayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.RadioButton radioButtonAccurateTime;
        private System.Windows.Forms.RadioButton radioButtonIn;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMinuts;
        private System.Windows.Forms.TrackBar trackBarMinuts;
        private System.Windows.Forms.TrackBar trackBarHours;
        private System.Windows.Forms.Button buttonAccury;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NotifyIcon systemTray;
        private System.Windows.Forms.ContextMenuStrip sysTrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Timer mainTimer;
    }
}

