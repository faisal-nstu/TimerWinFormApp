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
    public partial class TimerHome : Form
    {
        public TimerHome()
        {
            InitializeComponent();
        }

        private void addTimerButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            ButtonDisable();
        }

        private void ButtonDisable()
        {
            addTimerButton.Enabled = false;
        }
    }
}
