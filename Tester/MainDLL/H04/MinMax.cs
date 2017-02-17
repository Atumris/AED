using System;
using MainDLL.H02;

namespace MainDLL.H04
{
    public class MinMax<T> where T : IComparable
    {



        /// <summary>
        /// Finds the highest value in an array
        /// </summary>
        /// <param name="values">An array of generic T</param>
        /// <returns>max</returns>
        public T Max(T[] values)
        {
            T max = values[0]; //veranderen zonder getter
            for (int i = 1; i < values.Length; i++)
                if (values[i].CompareTo(max) > 0) max = values[i];
            return max;
        }

        /// <summary>
        /// Finds the lowest value in an array.
        /// </summary>
        /// <param name="values">An array of generic type T</param>
        /// <returns>min</returns>
        public T Min(T[] values)
        {
            T min = values[0];
            for (int i = 1; i < values.Length; i++)
                if (values[i].CompareTo(min) < 0) min = values[i];
            return min;
        }
        
        /// <summary>
        /// Finds the lowest and highest values in an array and returns this as an array
        /// where minmax[0] = lowest and minmax[1] = highest
        /// </summary>
        /// <param name="arr">An array of generic T</param>
        /// <returns>minmax an array wich contain lowest and highest values</returns>
        private T[] FindMinMax(T[] arr)
        {
            T min = Min(arr);
            T max = Max(arr);

            T[] minmax = {min, max};

            return minmax;
        }
    }
}
