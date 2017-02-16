using System;
using System.Collections.Generic;

namespace MainDLL.H04
{
    class MinMax<T> where T : IComparable
    {

        /// <summary>
        /// Finds the lowest value in an array.
        /// </summary>
        /// <param name="arr">Int array for the function</param>
        /// <returns>min</returns>
        private T FindMin(T[] arr)
        {
            var min = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] < min)
                    min = arr[i];
            return min;
        }

        /// <summary>
        /// Finds the highest value in an array
        /// </summary>
        /// <param name="arr">Int array for the function</param>
        /// <returns>max</returns>
        private int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
        
        /// <summary>
        /// Finds the lowest and highest values in an array and returns this as an array
        /// where minmax[0] = lowest and minmax[1] = highest
        /// </summary>
        /// <param name="arr">Int array for the function</param>
        /// <returns>minmax an array wich contain lowest and highest values</returns>
        private int[] FindMinMax(int[] arr)
        {
            int min = FindMin(arr);
            int max = FindMax(arr);

            int[] minmax = {min, max};

            return minmax;
        }
    }
}
