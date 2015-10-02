using System;
using System.Drawing;
using System.Runtime.InteropServices;
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
        private bool _addClicked;

        // move with label
        public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        
        public TimerHome()
        {
            InitializeComponent();
            _isRunning = false;
            _formInitForInput = false;
            _addClicked = false;
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
            label3.MouseDown += MoveOnMouseDown;
            colonLabel1.MouseDown += MoveOnMouseDown;
            colonLabel2.MouseDown += MoveOnMouseDown;
            titlebarLogo.MouseDown += MoveOnMouseDown;
        }

        

        #region Button Activities
        private void addTimerButton_Click(object sender, EventArgs e)
        {
            if (hourInputTextbox.Text == "" && minuteInputTextbox.Text == "" && secondInputTextbox.Text == "" && _addClicked == true)
            {
                ResetTimerHome();
                _addClicked = false;
            }
            else
            {
                this.addTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                addTimerButton.Text = "X";
                if (_isRunning == false && _addClicked == false)
                {
                    _addClicked = true;
                    InitializeFormForTimer();
                }
                if (_isRunning == true)
                {
                    TimerUtilities.StopTimer();
                    ResetTimerHome();
                    _isRunning = false;
                }
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
            }
            base.WndProc(ref m);
        }

        private void MoveOnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void InitializeFormForTimer()
        {
            if (_formInitForInput == false)
            {
                for (int i = 0; i < 92; i+=2)
                {
                    this.Height+=2;
                    alertMsgTextbox.ReadOnly = false;
                    addTimerButton.Location = new Point(addTimerButton.Location.X, addTimerButton.Location.Y + 2);
                    startButton.Location = new Point(startButton.Location.X, startButton.Location.Y + 2);
                    pauseButton.Location = new Point(pauseButton.Location.X, pauseButton.Location.Y + 2);
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
            this.addTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //CHANGE BACK TO INITIAL STATE
            if (_formInitForInput == true)
            {
                for (int i = 0; i < 92; i+=2)
                {
                    this.Height-=2;
                    addTimerButton.Location = new Point(addTimerButton.Location.X, addTimerButton.Location.Y - 2);
                    startButton.Location = new Point(startButton.Location.X, startButton.Location.Y - 2);
                    pauseButton.Location = new Point(pauseButton.Location.X, pauseButton.Location.Y - 2);
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

        public void ResetLabel()
        {
           ResetTimerHome();
        }

        #endregion
    }
}
