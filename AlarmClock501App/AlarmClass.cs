using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock501App
{
   public class AlarmClass
    {
        public int Hour;
        public int Minute;
        public int Seconds;
        public bool status;
        public DateTime Time;
        public AlarmClass(int H, int M, bool On, int s, DateTime T)
        {
            Time = T;
            Hour = H;
            Minute = M;
            Seconds = s;
            status = On;
            
        }

        public void Ring()
        {
            Console.WriteLine("Hello World");
        }


        //Returns the number of minutes until the timer needs to ring from midnight
        public int getTime()
        {                    
            return (60 * Hour *60 + Minute * 60 + Seconds);
        }

        //WIll Add 5 minutes to the Time property
        public void Snooze()
        {
            Time.AddMinutes(5);
        }


        //Will check if it is time to ring
        public bool isItTime(DateTime T)
        {
            if(Time == T)
            {
                return true;
            }
            return false;
        }

        //Returns a readable Alarm string for the Alarm List
        public override string ToString()
        {
            if (Hour <= 11)
            {
                if (this.Hour != 0){
                    return (String.Format("{0}:{1} AM", this.Hour, this.Minute));
                }
                return (String.Format("12:{0} AM", this.Minute));
            }
            if (status)
            {
                if (Hour == 0) { return (String.Format("12:{0} AM ON", this.Minute)); }
                if (Hour == 12) { return (String.Format("12:{0} PM ON", this.Minute)); }
                return (String.Format("{0}:{1} PM ON", this.Hour - 12, this.Minute));
            }

            if (Hour == 0) { return (String.Format("12:{0} AM OFF", this.Minute)); }
            if (Hour == 12) { return (String.Format("12:{0} PM OFF", this.Minute)); }
            return (String.Format("{0}:{1} PM OFF", this.Hour - 12, this.Minute));
        }
    }
}
