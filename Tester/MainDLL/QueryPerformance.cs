using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace MainDLL
{
    public class QueryPerformance
    {
        private long start;
        private long stop;
        private long frequency;
        Decimal multiplier = new Decimal(1.0e6); //time in miliseconds

        [DllImport("KERNEL32")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);

        public QueryPerformance()
        {

            //System.Diagnostics.Process.GetCurrentProcess().ProcessorAffinity = (System.IntPtr)2;
            //Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;

            if (QueryPerformanceFrequency(out frequency) == false)
            {
                // Frequency not supported
                throw new Win32Exception();
            }
        }

        public void Start()
        {
            QueryPerformanceCounter(out start);
        }

        public void Stop()
        {
            QueryPerformanceCounter(out stop);
        }

        public double Duration(int iterations)
        {
            return ((((double) (stop - start)*(double) multiplier)/(double) frequency)/iterations);
        }
    }
}