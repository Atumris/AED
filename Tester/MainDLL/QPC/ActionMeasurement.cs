using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MainDLL.QPC
{
    /// <summary>
    /// A class to measure the time that is passing during the execution of a method/action
    /// </summary>
    public class ActionMeasurement
    {
        double result;
        bool done;

        /// <summary>
        /// Initializes a new instance of the ActionMeasurement class
        /// </summary>
        public ActionMeasurement()
        {
            done = false;
            result = -1;
        }

        /// <summary>
        /// Measures the time to execute in milliseconds
        /// </summary>
        /// <param name="act">The action to measure</param>
        /// <returns>Return the time in milliseconds</returns>
        public double MeasureMilliseconds(Action act)
        {
            return MeasureNanoseconds(act) / 1000 / 1000;
        }

        /// <summary>
        /// Measures the time to execute in nanoseconds
        /// </summary>
        /// <param name="act">The action to measure</param>
        /// <returns>Return the time in nanoseconds</returns>
        public double MeasureNanoseconds(Action act)
        {
            Thread thr = new Thread(() => MeasureAction(act));
            thr.SetApartmentState(ApartmentState.STA);
            thr.Priority = ThreadPriority.Highest;
            thr.Start();
            while (!done)
            {
                Thread.Sleep(1);
            }
            return result;
        }

        /// <summary>
        /// The private method that is executed by a STA thread
        /// </summary>
        /// <param name="act">The method</param>
        private void MeasureAction(Action act)
        {
            QPC t = new QPC();
            
            lock (act)
            {
                t.Start();
                act.Invoke();
                t.Stop();
            }
            result = t.Duration(1);
            done = true;
        }
    }
}
