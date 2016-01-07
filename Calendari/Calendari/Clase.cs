using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendari
{
    public class Clase
    {
        public string Name;
        public string Professor;
        public int Repeat;
        public Date Date;
        public Time Start;
        public Time Finish;
    }

    public class Time
    {
        public int Hour;
        public int Minute;
    }

    public class Date
    {
        public int Day;
        public int Month;
        public int Year;
    }

}
