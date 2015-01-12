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
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            int buttonOffset = (this.Width/2) - (closeButton.Width/2);
            closeButton.Location = new System.Drawing.Point(buttonOffset, 206);
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
    }
}
