namespace WristTimer
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noNotification = new System.Windows.Forms.RadioButton();
            this.customNotification = new System.Windows.Forms.RadioButton();
            this.windowsNotification = new System.Windows.Forms.RadioButton();
            this.MonitorTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.preWarningTime = new System.Windows.Forms.NumericUpDown();
            this.preWarningCheckbox = new System.Windows.Forms.CheckBox();
            this.forceFocusCheckBox = new System.Windows.Forms.CheckBox();
            this.topMostCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ForceWaitSeconds = new System.Windows.Forms.NumericUpDown();
            this.ForceWaitCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preWarningTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForceWaitSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(61, 11);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interval";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set sound file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Stretch ur wrist bro";
            this.notifyIcon1.BalloonTipTitle = "Wrist Timer";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Wrist Timer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(573, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Run at logon";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // playSoundCheckBox
            // 
            this.playSoundCheckBox.AutoSize = true;
            this.playSoundCheckBox.Location = new System.Drawing.Point(6, 100);
            this.playSoundCheckBox.Name = "playSoundCheckBox";
            this.playSoundCheckBox.Size = new System.Drawing.Size(78, 17);
            this.playSoundCheckBox.TabIndex = 7;
            this.playSoundCheckBox.Text = "Play sound";
            this.playSoundCheckBox.UseVisualStyleBackColor = true;
            this.playSoundCheckBox.CheckedChanged += new System.EventHandler(this.playSoundCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noNotification);
            this.groupBox1.Controls.Add(this.customNotification);
            this.groupBox1.Controls.Add(this.windowsNotification);
            this.groupBox1.Controls.Add(this.playSoundCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(296, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 167);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notifications";
            // 
            // noNotification
            // 
            this.noNotification.AutoSize = true;
            this.noNotification.Location = new System.Drawing.Point(6, 65);
            this.noNotification.Name = "noNotification";
            this.noNotification.Size = new System.Drawing.Size(51, 17);
            this.noNotification.TabIndex = 9;
            this.noNotification.TabStop = true;
            this.noNotification.Text = "None";
            this.noNotification.UseVisualStyleBackColor = true;
            this.noNotification.CheckedChanged += new System.EventHandler(this.noNotification_CheckedChanged);
            // 
            // customNotification
            // 
            this.customNotification.AutoSize = true;
            this.customNotification.Location = new System.Drawing.Point(6, 42);
            this.customNotification.Name = "customNotification";
            this.customNotification.Size = new System.Drawing.Size(116, 17);
            this.customNotification.TabIndex = 8;
            this.customNotification.TabStop = true;
            this.customNotification.Text = "Custom Notification";
            this.customNotification.UseVisualStyleBackColor = true;
            this.customNotification.CheckedChanged += new System.EventHandler(this.customNotification_CheckedChanged);
            // 
            // windowsNotification
            // 
            this.windowsNotification.AutoSize = true;
            this.windowsNotification.Location = new System.Drawing.Point(6, 19);
            this.windowsNotification.Name = "windowsNotification";
            this.windowsNotification.Size = new System.Drawing.Size(125, 17);
            this.windowsNotification.TabIndex = 0;
            this.windowsNotification.TabStop = true;
            this.windowsNotification.Text = "Windows Notification";
            this.windowsNotification.UseVisualStyleBackColor = true;
            this.windowsNotification.CheckedChanged += new System.EventHandler(this.windowsNotification_CheckedChanged);
            // 
            // MonitorTimer
            // 
            this.MonitorTimer.Enabled = true;
            this.MonitorTimer.Interval = 5;
            this.MonitorTimer.Tick += new System.EventHandler(this.monitorTimerTick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(740, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.preWarningTime);
            this.groupBox2.Controls.Add(this.preWarningCheckbox);
            this.groupBox2.Controls.Add(this.forceFocusCheckBox);
            this.groupBox2.Controls.Add(this.topMostCheckBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ForceWaitSeconds);
            this.groupBox2.Controls.Add(this.ForceWaitCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(454, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 184);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Notification";
            // 
            // preWarningTime
            // 
            this.preWarningTime.Location = new System.Drawing.Point(97, 127);
            this.preWarningTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.preWarningTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.preWarningTime.Name = "preWarningTime";
            this.preWarningTime.Size = new System.Drawing.Size(78, 20);
            this.preWarningTime.TabIndex = 14;
            this.preWarningTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.preWarningTime.ValueChanged += new System.EventHandler(this.preWarningTime_ValueChanged);
            // 
            // preWarningCheckbox
            // 
            this.preWarningCheckbox.AutoSize = true;
            this.preWarningCheckbox.Location = new System.Drawing.Point(6, 128);
            this.preWarningCheckbox.Name = "preWarningCheckbox";
            this.preWarningCheckbox.Size = new System.Drawing.Size(85, 17);
            this.preWarningCheckbox.TabIndex = 13;
            this.preWarningCheckbox.Text = "Pre-Warning";
            this.preWarningCheckbox.UseVisualStyleBackColor = true;
            this.preWarningCheckbox.CheckedChanged += new System.EventHandler(this.preWarningCheckbox_Changed);
            // 
            // forceFocusCheckBox
            // 
            this.forceFocusCheckBox.AutoSize = true;
            this.forceFocusCheckBox.Location = new System.Drawing.Point(6, 105);
            this.forceFocusCheckBox.Name = "forceFocusCheckBox";
            this.forceFocusCheckBox.Size = new System.Drawing.Size(85, 17);
            this.forceFocusCheckBox.TabIndex = 12;
            this.forceFocusCheckBox.Text = "Force Focus";
            this.forceFocusCheckBox.UseVisualStyleBackColor = true;
            this.forceFocusCheckBox.CheckedChanged += new System.EventHandler(this.forceFocusCheckBox_CheckedChanged);
            // 
            // topMostCheckBox
            // 
            this.topMostCheckBox.AutoSize = true;
            this.topMostCheckBox.Location = new System.Drawing.Point(6, 82);
            this.topMostCheckBox.Name = "topMostCheckBox";
            this.topMostCheckBox.Size = new System.Drawing.Size(98, 17);
            this.topMostCheckBox.TabIndex = 11;
            this.topMostCheckBox.Text = "Always On Top";
            this.topMostCheckBox.UseVisualStyleBackColor = true;
            this.topMostCheckBox.CheckedChanged += new System.EventHandler(this.topMostCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Display Time (s)";
            // 
            // ForceWaitSeconds
            // 
            this.ForceWaitSeconds.Location = new System.Drawing.Point(6, 56);
            this.ForceWaitSeconds.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ForceWaitSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ForceWaitSeconds.Name = "ForceWaitSeconds";
            this.ForceWaitSeconds.Size = new System.Drawing.Size(78, 20);
            this.ForceWaitSeconds.TabIndex = 9;
            this.ForceWaitSeconds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ForceWaitSeconds.ValueChanged += new System.EventHandler(this.ForceWaitSeconds_ValueChanged);
            // 
            // ForceWaitCheckBox
            // 
            this.ForceWaitCheckBox.AutoSize = true;
            this.ForceWaitCheckBox.Location = new System.Drawing.Point(6, 20);
            this.ForceWaitCheckBox.Name = "ForceWaitCheckBox";
            this.ForceWaitCheckBox.Size = new System.Drawing.Size(78, 17);
            this.ForceWaitCheckBox.TabIndex = 8;
            this.ForceWaitCheckBox.Text = "Force Wait";
            this.ForceWaitCheckBox.UseVisualStyleBackColor = true;
            this.ForceWaitCheckBox.CheckedChanged += new System.EventHandler(this.ForceWaitCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Text = "Wrist Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preWarningTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForceWaitSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.CheckBox playSoundCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton noNotification;
        private System.Windows.Forms.RadioButton customNotification;
        private System.Windows.Forms.RadioButton windowsNotification;
        private System.Windows.Forms.Timer MonitorTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ForceWaitSeconds;
        private System.Windows.Forms.CheckBox ForceWaitCheckBox;
        private System.Windows.Forms.CheckBox topMostCheckBox;
        private System.Windows.Forms.CheckBox forceFocusCheckBox;
        private System.Windows.Forms.CheckBox preWarningCheckbox;
        private System.Windows.Forms.NumericUpDown preWarningTime;
    }
}

