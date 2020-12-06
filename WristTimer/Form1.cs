using Microsoft.Win32;
using Squirrel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WristTimer.Settings;

namespace WristTimer
{
    public partial class Form1 : Form
    {
        static readonly TimeSpan UpdateInterval = TimeSpan.FromHours(12);
        DateTime alarmTime, lastUpdateCheck = DateTime.Now;
        Settings settings = Settings.Load();
        MouseUsageMonitor mouseUsageMonitor = new MouseUsageMonitor(5);

        public bool allowClose = false;

        public Form1()
        {
            InitializeComponent();
            ShowInTaskbar = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            settings.Interval = numericUpDown1.Value;
            settings.Save();
            scheduleAlarm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(alarmTime == DateTime.Now || alarmTime < DateTime.Now)
            {
                scheduleAlarm();
                alarm();
            }
            label2.Text = (alarmTime - DateTime.Now).ToString("mm\\:ss");
            checkDoUpdate();

            label4.Text = $"One minute average mouse usage: {Math.Round(mouseUsageMonitor.GetUsageSample() / MouseUsageMonitor.SampleTime.TotalSeconds, 1)} pixels per second";
        }

        private void checkDoUpdate()
        {
            if(DateTime.Now - lastUpdateCheck > UpdateInterval)
            {
                checkUpdates();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                Hide();
                Opacity = 1;
                ShowInTaskbar = true;
            }));

            Version v = Assembly.GetExecutingAssembly().GetName().Version;

            this.Text += $" {v.Major}.{v.Minor}.{v.Build}";

            numericUpDown1.Value = settings.Interval;
            label3.Text = settings.SoundFile;
            checkBox1.Checked = settings.RunAtLogon;
            playSoundCheckBox.Checked = settings.PlaySound;
            ForceWaitCheckBox.Checked = settings.ForceWait;
            ForceWaitSeconds.Value = settings.ForceWaitSeconds;
            topMostCheckBox.Checked = settings.TopMost;
            forceFocusCheckBox.Checked = settings.ForceFocus;
            preWarningCheckbox.Checked = settings.PreWarning;
            preWarningTime.Value = settings.PreWarningTime;

            switch(settings.Notifications)
            {
                case NotificationMode.WindowsDefault:
                    windowsNotification.Checked = true;
                    break;
                case NotificationMode.Custom:
                    customNotification.Checked = true;
                    break;
                case NotificationMode.None:
                    noNotification.Checked = true;
                    break;
            }

            scheduleAlarm();
            checkUpdates();
            checkRunAtLogon();
        }

        private void scheduleAlarm()
        {
            alarmTime = DateTime.Now.AddMinutes((double)numericUpDown1.Value);
        }

        private void alarm()
        {
            if(settings.PlaySound)
            {
                SoundPlayer sp = new SoundPlayer(settings.SoundFile);
                sp.Play();
            }

            if (settings.Notifications == NotificationMode.WindowsDefault)
                notifyIcon1.ShowBalloonTip(10);
            else if (settings.Notifications == NotificationMode.Custom)
                new NotificationForm(settings.ForceWaitSeconds, settings.ForceWait, settings.TopMost, settings.ForceFocus, settings.PreWarning, settings.PreWarningTime);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                settings.SoundFile = openFileDialog1.FileName;
                label3.Text = settings.SoundFile;
                settings.Save();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!allowClose)
                e.Cancel = true;
            Hide();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowClose = true;
            Application.Exit();
        }

        private async void checkUpdates()
        {
            lastUpdateCheck = DateTime.Now;
            using (UpdateManager manager = new UpdateManager("https://nightfish.co/software/wristtimer"))
            {
                try
                {
                    await manager.UpdateApp();
                }
                catch { }
            }
        }

        private void checkRunAtLogon()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);


            using (UpdateManager manager = new UpdateManager("https://nightfish.co/software/wristtimer"))
            {
                if (settings.RunAtLogon)
                    rk.SetValue("WristTimer", Path.Combine(manager.RootAppDirectory, "WristTimer.exe"));
                else
                    rk.DeleteValue("WristTimer", false);
            }
        }

        private async void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (UpdateManager manager = new UpdateManager("https://nightfish.co/software/wristtimer"))
            {
                try
                {
                    var updateInfo = await manager.CheckForUpdate();

                    if (updateInfo.ReleasesToApply.Any())
                    {
                        var versionCount = updateInfo.ReleasesToApply.Count;

                        var versionWord = versionCount > 1 ? "versions" : "version";
                        var message = new StringBuilder().AppendLine($"Wrist Timer is {versionCount} {versionWord} behind.").
                                                          AppendLine("If you choose to update, changes wont take affect until App is restarted.").
                                                          AppendLine("Would you like to download and install them?").
                                                          ToString();

                        var result = MessageBox.Show(message, "App Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result != DialogResult.Yes)
                            return;

                        var updateResult = await manager.UpdateApp();
                        MessageBox.Show($"Update complete!\r\nClick OK to restart the app.", "App Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateManager.RestartApp();
                    }
                    else
                    {
                        var result = MessageBox.Show($"You are on the latest version ({updateInfo.CurrentlyInstalledVersion.Version.ToString()})", "App Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking for updates: " + ex.Message, "Error checking for updates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            settings.RunAtLogon = checkBox1.Checked;
            settings.Save();
            checkRunAtLogon();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void playSoundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.PlaySound = playSoundCheckBox.Checked;
            settings.Save();
        }

        private void windowsNotification_CheckedChanged(object sender, EventArgs e)
        {
            settings.Notifications = NotificationMode.WindowsDefault;
            settings.Save();
        }

        private void customNotification_CheckedChanged(object sender, EventArgs e)
        {
            settings.Notifications = NotificationMode.Custom;
            settings.Save();
        }

        private void monitorTimerTick(object sender, EventArgs e)
        {
            mouseUsageMonitor.Monitor();
        }

        private void ForceWaitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.ForceWait = ForceWaitCheckBox.Checked;
            settings.Save();
        }

        private void ForceWaitSeconds_ValueChanged(object sender, EventArgs e)
        {
            settings.ForceWaitSeconds = (int)ForceWaitSeconds.Value;
            settings.Save();
        }

        private void topMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.TopMost = topMostCheckBox.Checked;
            settings.Save();
        }

        private void forceFocusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.ForceFocus = forceFocusCheckBox.Checked;
            settings.Save();
        }

        private void preWarningCheckbox_Changed(object sender, EventArgs e)
        {
            settings.PreWarning = preWarningCheckbox.Checked;
            settings.Save();
        }

        private void preWarningTime_ValueChanged(object sender, EventArgs e)
        {
            settings.PreWarningTime = (int)preWarningTime.Value;
            settings.Save();
        }

        private void noNotification_CheckedChanged(object sender, EventArgs e)
        {
            settings.Notifications = NotificationMode.None;
            settings.Save();
        }
    }
}
