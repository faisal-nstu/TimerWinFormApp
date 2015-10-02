using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using TimerWinFormApp.BL;

namespace TimerWinFormApp.UI
{
    public partial class AlertForm : Form
    {
        //E:\Faisal\songs\[eNgLiSh]\Blind Guardian - Road Of No Release.mp3
        SoundPlayer alertSound = new SoundPlayer(@"c:\Windows\Media\Alarm10.wav");
        public AlertForm()
        {
            InitializeComponent();
            closeButton.MouseEnter += CloseButtonOnMouseHover;
            closeButton.MouseLeave += CloseButtonOnMouseLeave;
            newButton.MouseEnter += CloseButtonOnMouseHover;
            newButton.MouseLeave += CloseButtonOnMouseLeave;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            int closeButtonOffset = (this.Width/2) + 25;
            closeButton.Location = new System.Drawing.Point(closeButtonOffset, 206);
            int newButtonOffset = (this.Width/2) - newButton.Width - 20;
            newButton.Location = new System.Drawing.Point(newButtonOffset, 206);
            UpdateLabel();
            int timeUpLabelHorizontalOffset = (this.Width / 2) - (timeUpLabel.Width / 2);
            int timeUpLabelVerticalOffset = (this.Height / 2) - (timeUpLabel.Height / 2);
            timeUpLabel.Location = new System.Drawing.Point(timeUpLabelHorizontalOffset, timeUpLabelVerticalOffset);
            alertSound.PlayLooping();
        }

        private void UpdateLabel()
        {
             timeUpLabel.Text = TimerUtilities.ReadAlertMsgFromFile();
        }

        private void CloseButtonOnMouseLeave(object sender, EventArgs eventArgs)
        {
            (sender as Button).BackColor = Color.Transparent;
            (sender as Button).ForeColor = Color.Black;
        }

        private void CloseButtonOnMouseHover(object sender, EventArgs eventArgs)
        {
            (sender as Button).BackColor = Color.Yellow;
            (sender as Button).ForeColor = Color.OrangeRed;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            alertSound.Stop();
            Application.Exit();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //var newTimer = new TimerHome();
            //newTimer.Show();
            TimerUtilities.ResetTimerHome();
            this.Dispose();
        }
    }
}
