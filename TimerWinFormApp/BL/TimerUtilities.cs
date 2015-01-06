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
        public static Timer timer;
        public static TimerHome _timerHome;
        private static TimeSpan timeSpan;
        private static TimeSpan sec = new TimeSpan(0, 0, 1);
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
            timeSpan = new TimeSpan(Convert.ToInt32(hour), Convert.ToInt32(minute), Convert.ToInt32(second));
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
            timeSpan = timeSpan.Subtract(sec);
            _timerHome.UpdateTime(timeSpan.Hours,timeSpan.Minutes,timeSpan.Seconds);
            if (timeSpan.Hours == 0 && timeSpan.Minutes == 0 && timeSpan.Seconds == 0)
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
