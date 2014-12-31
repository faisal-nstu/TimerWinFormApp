using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimerWinFormApp.UI;

namespace TimerWinFormApp.BL
{
    class TimerUtilities
    {
        private static int _time;
        public static int GetTotalSeconds(string hour, string minute, string second)
        {
            if (hour == String.Empty)
            {
                hour = 0.ToString();
            }
            if (minute == String.Empty)
            {
                minute = 0.ToString();
            }
            if (second == String.Empty)
            {
                second = 0.ToString();
            }
            return Convert.ToInt32(second) + (Convert.ToInt32(minute) * 60) + (Convert.ToInt32(hour) * 3600);
        }

        public static void WriteTimeToFile(int time)
        {
            try
            {
                StreamWriter sw = new StreamWriter("d:\\time.t");
                sw.WriteLine(time);
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
        }

        public static void StartTimer(string hour, string minute, string second)
        {
            _time = GetTotalSeconds(hour, minute, second);
            WriteTimeToFile(_time);
            TimeCounter();
        }

        private static void TimeCounter()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
            timer.Tick += timer_tick;
        }

        private static void timer_tick(object sender, EventArgs e)
        {
            _time--;

            if (_time == 0)
            {
                AlertForm alert = new AlertForm();
                alert.ShowDialog();
            }
        }


    }
}
