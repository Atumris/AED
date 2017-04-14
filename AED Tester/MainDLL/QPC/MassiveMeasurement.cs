/*
=================================================================================	
  
               Vak:	AD


	Gemaakt door: 	Robbie Roeten, Henri Arends, Mirek Nalepa, Patrick Niewold
			        Joey Pieters


	    Docenten:	Jeroen Pijpker, Rob Smit

=================================================================================
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace MainDLL.QPC
{
    /// <summary>
    /// A class to measure the average time of a method with a given number of iterations
    /// </summary>
    public class MassiveMeasurement
    {
        /// <summary>
        /// Measures the average milliseconds
        /// </summary>
        /// <param name="act"></param>
        /// <param name="iterations"></param>
        /// <returns></returns>
        public double MeasureAverageMilliseconds(Action act, int iterations)
        {
            List<double> results = new List<double>();
            for (int i = 0; i < iterations; i++)
            {
                ActionMeasurement am = new ActionMeasurement();
                results.Add(am.MeasureMilliseconds(act));
            }
            return results.Average();
        }
    }
}
