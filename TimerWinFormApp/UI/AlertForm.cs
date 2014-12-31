using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerWinFormApp.UI
{
    public partial class AlertForm : Form
    {
        public AlertForm()
        {
            InitializeComponent();
            closeButton.MouseEnter += CloseButtonOnMouseHover;
            closeButton.MouseLeave += CloseButtonOnMouseLeave;
            timeUpLabel.Text = "Time Up";
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            int buttonOffset = (this.Width/2) - (closeButton.Width/2);
            int timeUpLabelHorizontalOffset = (this.Width / 2) - (timeUpLabel.Width / 2);
            int timeUpLabelVerticalOffset = (this.Height / 2) - (timeUpLabel.Height / 2);
            timeUpLabel.Location = new System.Drawing.Point(timeUpLabelHorizontalOffset, timeUpLabelVerticalOffset);
            closeButton.Location = new System.Drawing.Point(buttonOffset, 206);
        }

        private void CloseButtonOnMouseLeave(object sender, EventArgs eventArgs)
        {
            (sender as Button).BackColor = Color.Transparent;
            (sender as Button).ForeColor = Color.Black;
        }

        private void CloseButtonOnMouseHover(object sender, EventArgs eventArgs)
        {
            (sender as Button).BackColor = Color.Tomato;
            (sender as Button).ForeColor = Color.White;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
