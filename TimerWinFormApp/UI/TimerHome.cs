using System;
using System.Drawing;
using System.Windows.Forms;
using TimerWinFormApp.BL;

namespace TimerWinFormApp.UI
{
    public partial class TimerHome : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool _isRunning;
        private bool _formInitForInput;
        //33,125,92
        public TimerHome()
        {
            InitializeComponent();
            _isRunning = false;
            _formInitForInput = false;
            this.Resize += OnResize;
            alertMsgTextbox.ReadOnly = true;
            alertMsgTextbox.Hide();
            hourInputTextbox.Hide();
            minuteInputTextbox.Hide();
            secondInputTextbox.Hide();
            colonLabel1.Hide();
            colonLabel2.Hide();
            hourInputTextbox.Enabled = false;
            minuteInputTextbox.Enabled = false;
            secondInputTextbox.Enabled = false;
            hourInputTextbox.KeyPress += TextboxOnKeyPress;
            minuteInputTextbox.KeyPress += TextboxOnKeyPress;
            secondInputTextbox.KeyPress += TextboxOnKeyPress;
            minuteInputTextbox.LostFocus += CheckIfOverSixty;
            secondInputTextbox.LostFocus += CheckIfOverSixty;
            startButton.Enabled = false;
            pauseButton.Enabled = false;
            //notifyIcon.BalloonTipText = "My application still working...";
            //notifyIcon.BalloonTipTitle = "My Sample Application";
            //notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.Visible = false;
        }

#region Button Activities
        private void addTimerButton_Click(object sender, EventArgs e)
        {
            if (_isRunning == false)
            {
                InitializeFormForTimer();
            }
            if (_isRunning == true)
            {
                TimerUtilities.StopTimer();
                ResetTimerHome();
                _isRunning = false;
            }
        }

        
        private void startButton_Click(object sender, EventArgs e)
        {
            if (hourInputTextbox.Text == "" && minuteInputTextbox.Text == "" && secondInputTextbox.Text == "")
            {
                return;
            }
            else
            {
                if (_isRunning == false)
                {
                    addTimerButton.Text = "■";
                    alertMsgTextbox.ReadOnly = true;
                    TimerUtilities.StartTimer(hourInputTextbox.Text, minuteInputTextbox.Text, secondInputTextbox.Text, alertMsgTextbox.Text);
                    _isRunning = true;
                    TimerUtilities.RefToHome(this);
                }
                else
                {
                    TimerUtilities.RunTimer();
                }
                
            }
            
            startButton.Enabled = false;
            pauseButton.Enabled = true;
            pauseButton.Focus();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            TimerUtilities.PauseTimer();
            pauseButton.Enabled = false;
            startButton.Enabled = true;
            startButton.Focus();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            
        }

        private void NotifyIconOnMouseClick(object sender, MouseEventArgs mouseEventArgs)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
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

#endregion

#region Methods
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

        private void InitializeFormForTimer()
        {
            if (_formInitForInput == false)
            {
                for (int i = 0; i < 92; i++)
                {
                    this.Height++;
                    alertMsgTextbox.ReadOnly = false;
                    addTimerButton.Location = new Point(addTimerButton.Location.X, addTimerButton.Location.Y + 1);
                    startButton.Location = new Point(startButton.Location.X, startButton.Location.Y + 1);
                    pauseButton.Location = new Point(pauseButton.Location.X, pauseButton.Location.Y + 1);
                }
                alertMsgTextbox.Show();
                hourInputTextbox.Show();
                minuteInputTextbox.Show();
                secondInputTextbox.Show();
                colonLabel1.Show();
                colonLabel2.Show();
                _formInitForInput = true;
                // *********** pasted
                alertMsgTextbox.Text = "";
                hourInputTextbox.Enabled = true;
                minuteInputTextbox.Enabled = true;
                secondInputTextbox.Enabled = true;
                hourInputTextbox.Focus();
                startButton.Enabled = true;
            }
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
                this.ShowInTaskbar = false;
                notifyIcon.MouseClick += NotifyIconOnMouseClick;
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

            //CHANGE BACK TO INITIAL STATE
            if (_formInitForInput == true)
            {
                for (int i = 0; i < 92; i++)
                {
                    this.Height--;
                    addTimerButton.Location = new Point(addTimerButton.Location.X, addTimerButton.Location.Y - 1);
                    startButton.Location = new Point(startButton.Location.X, startButton.Location.Y - 1);
                    pauseButton.Location = new Point(pauseButton.Location.X, pauseButton.Location.Y - 1);
                }
                alertMsgTextbox.Hide();
                hourInputTextbox.Hide();
                minuteInputTextbox.Hide();
                secondInputTextbox.Hide();
                colonLabel1.Hide();
                colonLabel2.Hide();
                _formInitForInput = false;
            }

        }

        public void UpdateTime(int hour, int minute, int second)
        {
            hourInputTextbox.Text = hour.ToString();
            minuteInputTextbox.Text = minute.ToString();
            secondInputTextbox.Text = second.ToString();
            notifyIcon.Text = hour + ":" + minute + ":" + second + " left";
        }
#endregion
    }
}
