using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimerWinFormApp.BL;
using TimerWinFormApp.Properties;

namespace TimerWinFormApp.UI
{
    public partial class TimerHome : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool _isRunning;

        public TimerHome()
        {
            InitializeComponent();
            this.Resize += OnResize;
            hourInputTextbox.Enabled = false;
            minuteInputTextbox.Enabled = false;
            secondInputTextbox.Enabled = false;
            hourInputTextbox.KeyPress += TextboxOnKeyPress;
            minuteInputTextbox.KeyPress += TextboxOnKeyPress;
            secondInputTextbox.KeyPress += TextboxOnKeyPress;
            minuteInputTextbox.LostFocus += CheckIfOverSixty;
            secondInputTextbox.LostFocus += CheckIfOverSixty;
            _isRunning = false;
            startButton.Enabled = false;
            pauseButton.Enabled = false;
            notifyIcon.Icon = Properties.Resources.clock_512;
            notifyIcon.BalloonTipText = "My application still working...";
            notifyIcon.BalloonTipTitle = "My Sample Application";
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.Visible = false;
        }

        private void CheckIfOverSixty(object sender, EventArgs eventArgs)
        {
            int t;
            if ((sender as TextBox).Text != "")
            {
                t = Convert.ToInt32(((TextBox)sender).Text);
                if (t >= 60)
                {
                    MessageBox.Show("Input should be less than 60");
                    (sender as TextBox).Text = "";
                }
            }
        }

        private void TextboxOnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void OnResize(object sender, EventArgs eventArgs)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
                notifyIcon.MouseClick += NotifyIconOnMouseClick;
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
                    break;
            }
            base.WndProc(ref m);
        }

        private void addTimerButton_Click(object sender, EventArgs e)
        {
            if (_isRunning == false)
            {
                hourInputTextbox.Enabled = true;
                minuteInputTextbox.Enabled = true;
                secondInputTextbox.Enabled = true;
                hourInputTextbox.Focus();
                startButton.Enabled = true;
            }
            if (_isRunning == true)
            {
                TimerUtilities.StopTimer();
                ResetTimerHome();
                _isRunning = false;
            }
        }

        private void ResetTimerHome()
        {
            hourInputTextbox.Text = "";
            minuteInputTextbox.Text = "";
            secondInputTextbox.Text = "";
            addTimerButton.Text = "+";
            startButton.Enabled = false;
            pauseButton.Enabled = false;

        }


        private void startButton_Click(object sender, EventArgs e)
        {
            addTimerButton.Text = "■";
            if (_isRunning == false)
            {
                TimerUtilities.StartTimer(hourInputTextbox.Text,minuteInputTextbox.Text,secondInputTextbox.Text);
                _isRunning = true;
                TimerUtilities.Referene(this);
            }
            else
            {
                TimerUtilities.RunTimer();
            }
            startButton.Enabled = false;
            pauseButton.Enabled = true;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            TimerUtilities.PauseTimer();
            pauseButton.Enabled = false;
            startButton.Enabled = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void NotifyIconOnMouseClick(object sender, MouseEventArgs mouseEventArgs)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                var desktopWorkingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
                this.Left = desktopWorkingArea.Right - this.Width;
                this.Top = desktopWorkingArea.Bottom - this.Height;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        public void UpdateTime(int hour, int minute, int second)
        {
            hourInputTextbox.Text = hour.ToString();
            minuteInputTextbox.Text = minute.ToString();
            secondInputTextbox.Text = second.ToString();
        }
    }
}
