using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Clock
    {
        // fields
        private DateTime now;

        // methods
        public void PrintCurrentTime()
        {
            now = DateTime.Now;
            Console.WriteLine(now.TimeOfDay);
        }

        public void PrintCurrentDate()
        {
            now = DateTime.Now;
            Console.WriteLine(now.Date);
        }
    }
}
