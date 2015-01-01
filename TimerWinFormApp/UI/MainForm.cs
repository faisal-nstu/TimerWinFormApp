using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimerWinFormApp.BL;

namespace TimerWinFormApp.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            hourTextBox.KeyPress += Textbox_KeyPress;
            minuteTextBox.KeyPress += MinuteTextbox_KeyPress;
            secondTextbox.KeyPress += MinuteTextbox_KeyPress;
            minuteTextBox.LostFocus += checkIfOverSixty;
            secondTextbox.LostFocus += checkIfOverSixty;
        }

        private void checkIfOverSixty(object sender, EventArgs eventArgs)
        {
            int t;
            if ((sender as TextBox).Text != "")
            {
                t = Convert.ToInt32(((TextBox)sender).Text);
                if (t >= 60)
                {
                    (sender as TextBox).Text = "";
                }
            }
        }

        private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void MinuteTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            TimerUtilities.StartTimer(hourTextBox.Text, minuteTextBox.Text, secondTextbox.Text);
            this.Close();
        }

        
    }
}
