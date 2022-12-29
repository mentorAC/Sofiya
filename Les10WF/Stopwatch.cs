using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les10WF
{
    internal class Stopwatch
    {
        private int msecond;
        private int seconds;
        private int minutes;

       public void Timer_start()
        {
            msecond++;
            if(msecond == 10)
            {
                seconds++;
                msecond = 0;
            }
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
        }
        public string Todisplay()
        {
            return $"{minutes}:{seconds}.{msecond}";
        }
        public void Timerstop()
        {
            minutes = 0;
            seconds = 0;
            msecond = 0;
        }

            
    }
}
