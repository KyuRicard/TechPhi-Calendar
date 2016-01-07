namespace Calendari
{
    public class Clase
    {
        public string Name;
        public string Professor;
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

    public class Toolz
    {
        public static int GetTimeFragment(Time time)
        {
            int hora = time.Hour;
            int min = time.Minute;

            switch(hora)
            {
                case 8:
                    return 0;
                case 9:
                    if (min > 30)
                        return 1;
                    else
                        return 0;
                case 10:
                    return 1;
                case 11:
                    return 2;
                case 12:
                    if (min > 30)
                        return 3;
                    else
                        return 2;
                case 13:
                    return 3;
                case 14:
                    return 4;
                case 15:
                    if (min > 30)
                        return 5;
                    else
                        return 4;
                case 16:
                    return 5;
                case 17:
                    return 6;
                case 18:
                    if (min > 30)
                        return 7;
                    else
                        return 6;
                case 19:
                case 20:
                case 21:
                    return 7;
                default:
                    return -1;
            }
        }

        public static Time GetHour(int turn, TimeSet ts)
        {
            switch(turn)
            {
                case 0:
                    if (ts == TimeSet.START)
                        return new Time { Hour = 8, Minute = 0 };
                    else
                        return new Time { Hour = 9, Minute = 30 };
                case 1:
                    if (ts == TimeSet.START)
                        return new Time { Hour = 9, Minute = 30 };
                    else
                        return new Time { Hour = 11, Minute = 0 };
                case 2:
                    if (ts == TimeSet.START)
                        return new Time { Hour = 11, Minute = 0 };
                    else
                        return new Time { Hour = 12, Minute = 30 };
                case 3:
                    if (ts == TimeSet.START)
                        return new Time { Hour = 12, Minute = 30 };
                    else
                        return new Time { Hour = 14, Minute = 0 };
                case 4:
                    if (ts == TimeSet.START)
                        return new Time { Hour = 14, Minute = 0 };
                    else
                        return new Time { Hour = 15, Minute = 30 };
                case 5:
                    if (ts == TimeSet.START)
                        return new Time { Hour = 15, Minute = 30 };
                    else
                        return new Time { Hour = 17, Minute = 0 };
                case 6:
                    if (ts == TimeSet.START)
                        return new Time { Hour = 17, Minute = 0 };
                    else
                        return new Time { Hour = 18, Minute = 30 };
                case 7:
                    if (ts == TimeSet.START)
                        return new Time { Hour = 18, Minute = 30 };
                    else
                        return new Time { Hour = 21, Minute = 30 };
                default:
                    return null;
            }
        }
    }

    public enum TimeSet
    {
        START, FINISH
    }
}
