using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        private DateTime start;
        private DateTime end;

        public DateTime Start { 
            get { return start; }
            set { start = value; }
        }

        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }

        public TimeSpan difference(string start, string end) 
        {
            DateTime time = DateTime.Parse(start);
            DateTime time2 = DateTime.Parse(end);

            TimeSpan diff = time2 - time;

            return diff;
        }

    }
}
