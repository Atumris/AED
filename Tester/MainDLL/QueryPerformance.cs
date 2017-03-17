using System.ComponentModel;
using System.Runtime.InteropServices;

namespace MainDLL
{
    public class QueryPerformance
    {
        private long _start;
        private long _stop;
        private readonly long _frequency;
        readonly decimal _multiplier = new decimal(1.0e9);

        [DllImport("KERNEL32")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);

        public QueryPerformance()
        {

            //System.Diagnostics.Process.GetCurrentProcess().ProcessorAffinity = (System.IntPtr)2;
            //Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;

            if (QueryPerformanceFrequency(out _frequency) == false)
            {
                // Frequency not supported
                throw new Win32Exception();
            }
        }

        public void Start()
        {
            QueryPerformanceCounter(out _start);
        }

        public void Stop()
        {
            QueryPerformanceCounter(out _stop);
        }

        public double Duration(int iterations)
        {
            return (_stop - _start)*(double) _multiplier/_frequency/iterations;
        }
    }
}