using System;
using System.Collections.Generic;
using System.Text;

namespace CoopSimulator
{
    public class Threads
    {
        public Threads()
        {
            Util.ColdStart();
            Helper.ThreadHelper.ExecuteThread(Date);

        }

        public void Date()
        {
            while (true)
            {
                Program.Date.Date = Program.Date.Date.AddDays(1);
            }
        }
    }
}
