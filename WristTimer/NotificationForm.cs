using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WristTimer
{
    public partial class NotificationForm : Form
    {
        private DateTime openTime = DateTime.Now;
        private bool forceWait;
        private int waitSeconds;
        private bool forceFocus;
        private bool preWarning;
        private int preWarningTime;

        public NotificationForm(int waitSeconds, bool forceWait, bool topMost, bool forceFocus, bool preWarning, int preWarningTime)
        {
            InitializeComponent();
            this.forceWait = forceWait;
            this.forceFocus = forceFocus;
            this.waitSeconds = waitSeconds;
            this.preWarning = preWarning;
            this.preWarningTime = preWarning ? preWarningTime : 0;
            closeButton.Enabled = !forceWait;
            TopMost = topMost;
            setLocation();
            setCloseTimeMessage();
            Show();
        }

        private void setLocation()
        {
            Rectangle rect = Screen.PrimaryScreen.WorkingArea;

            Location = new Point(
                rect.Right - Width,
                rect.Bottom - Height
                );
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {

        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now - openTime).TotalSeconds >= waitSeconds + preWarningTime)
            {
                end();
            }
            else
            {
                setCloseTimeMessage();
            }
        }

        private void setCloseTimeMessage()
        {
            if (forceWait)
            {
                if ((int)(DateTime.Now - openTime).TotalSeconds < preWarningTime)
                    closeButton.Text = Math.Round(preWarningTime - (DateTime.Now - openTime).TotalSeconds, 0).ToString();
                else
                    closeButton.Text = Math.Round(waitSeconds - (DateTime.Now - openTime).TotalSeconds + preWarningTime, 0).ToString();
            }
            else
                closeButton.Text = "close";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (!forceWait) 
                end();
        }

        private void NotificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (forceWait)
                e.Cancel = true;
        }

        private void end()
        {
            forceWait = false;
            Cursor.Clip = new Rectangle();
            Close();
        }

        private void forceTimer_Tick(object sender, EventArgs e)
        {
            if (forceWait)
            {
                if ((int)(DateTime.Now - openTime).TotalSeconds >= preWarningTime)
                {
                    if (forceFocus)
                    {
                        Activate();
                        Focus();
                    }
                    Cursor.Clip = Bounds;
                }
            }
        }
    }
}
