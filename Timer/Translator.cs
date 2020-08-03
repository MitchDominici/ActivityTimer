using System;
using System.Diagnostics;
using System.Threading;

namespace Timer
{
    public static class KeepTime
    {
        public static Stopwatch StartTimer()
        {
            Stopwatch timeSpent = new Stopwatch();
            timeSpent.Start();

            return timeSpent;

        }

        public static TimeSpan StopTimer(Stopwatch start) 
        {
            start.Stop();
            TimeSpan ts = start.Elapsed;

            return ts;
        }

        public static void ResetTimer() 
        {
        }
        public static void Bathroom()
        {
        }
    }
}