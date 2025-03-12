using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_11
{
    public class task4
    {
        private int hours;
        private int minutes;
        private int seconds;

        public task4()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }

        public void SetTime(int h, int m, int s)
        {
            if (h < 0 || m < 0 || s < 0)
                throw new ArgumentException("Время не может быть отрицательным.");
            if (m >= 60 || s >= 60)
                throw new ArgumentException("Минуты и секунды не могут превышать 59.");
            hours = h;
            minutes = m;
            seconds = s;
        }

        public int GetHours() => hours;
        public int GetMinutes() => minutes;
        public int GetSeconds() => seconds;

        public int TimeToDay()
        {
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            return totalSeconds / (24 * 3600);
        }
    }
}
