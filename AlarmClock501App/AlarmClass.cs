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
        public bool status;

        public AlarmClass(int H, int M, bool On)
        {
            Hour = H;
            Minute = M;
            status = On;
        }

        //Returns the number of minutes until the timer needs to ring from midnight
        public double getTime()
        {
                    
            return (60 * Hour + Minute);
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
        
            if(Hour == 0) { return (String.Format("12:{0} AM", this.Minute)); }
            if (Hour == 12) { return (String.Format("12:{0} PM", this.Minute)); }
            return (String.Format("{0}:{1} PM", this.Hour - 12, this.Minute));
        }
    }
}
