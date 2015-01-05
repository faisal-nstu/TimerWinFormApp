using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TimerWinFormApp.UI;

namespace TimerWinFormApp.BL
{
    class TimerUtilities
    {
        private static int _time;
        public static Timer timer;
        public static TimerHome _timerHome;
        private static TimeSpan timeSpan;
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

        public static void WriteTimeToFile(string time)
        {
            try
            {
                StreamWriter sw = new StreamWriter("c:\\ProgramData\\time.t");
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
            if (hour == "")
            {
                hour = "0";
            }
            if (minute == "")
            {
                minute = "0";
            }
            if (second == "")
            {
                second = "0";
            }
            _time = GetTotalSeconds(hour, minute, second);
            timeSpan = new TimeSpan(Convert.ToInt32(hour), Convert.ToInt32(minute), Convert.ToInt32(second));
            WriteTimeToFile(timeSpan.ToString());
            TimeInitialize();
            RunTimer();
        }

        private static void TimeInitialize()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += timer_tick;
        }

        public static void RunTimer()
        {
            timer.Start();
        }

        public static void PauseTimer()
        {
            timer.Stop();
        }

        public static void StopTimer()
        {
            timer.Enabled = false;
            timer.Dispose();
        }
        private static void timer_tick(object sender, EventArgs e)
        {
            TimeSpan sec = new TimeSpan(0,0,1);
            _time--;
            timeSpan = timeSpan.Subtract(sec);
            _timerHome.UpdateTime(timeSpan.Hours,timeSpan.Minutes,timeSpan.Seconds);
            if (_time == 0)
            {
                AlertForm alert = new AlertForm();
                alert.ShowDialog();
                timer.Stop();
            }
        }

        public static void Referene(TimerHome form)
        {
            _timerHome = form;
        }
    }
}
