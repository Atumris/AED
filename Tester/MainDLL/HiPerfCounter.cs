using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

namespace MainDLL
{
    public class HiPerfCounter
    {
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(
            out long lpPerformanceCount);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(
            out long lpFrequency);

        private long _startTime, _stopTime;
        private readonly long _freq;

        public HiPerfCounter()
        {
            _startTime = 0;
            _stopTime = 0;

            if (QueryPerformanceFrequency(out _freq) == false)
            {
                // high-performance counter not supported
                throw new Win32Exception();
            }
        }

        // Start the timer
        public void Start()
        {
            // lets do the waiting threads there work
            Thread.Sleep(0);

            //Garbage collect for before the timer starts
            GC.Collect();
            GC.WaitForPendingFinalizers();          

            //Start Timer
            QueryPerformanceCounter(out _startTime);
        }

        // Stop the timer
        public void Stop()
        {
            QueryPerformanceCounter(out _stopTime);
        }

        // Returns the duration of the timer (in seconds)
        public double Duration => (double)(_stopTime - _startTime) / (double)_freq;
    }
}
