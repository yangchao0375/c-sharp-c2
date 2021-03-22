using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_c2
{
    class Program
    {

        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DateTime datetime = new DateTime();
            datetime = DateTime.Now.AddSeconds(5);
            clock.SetAlarmTime(datetime);
            clock.Start();
        }
    }
}
