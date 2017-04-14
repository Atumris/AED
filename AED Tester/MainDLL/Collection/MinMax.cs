using System;

namespace MainDLL.Collection
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
            //get first value of the array
            T max = values[0];

            //loop trough the array to find highest value where i = index
            for (int i = 1; i < values.Length; i++)
            {
                //Check if values[index] is more then max and overwrite
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }
            //return highest value of the ArrayList
            return max;
        }

        /// <summary>
        /// Finds the lowest value in an array.
        /// </summary>
        /// <param name="values">An array of generic type T</param>
        /// <returns>min</returns>
        public T Min(T[] values)
        {
            //get first value of the array
            T min = values[0];

            //loop trough the array to find lowest value where i = index
            for (int i = 1; i < values.Length; i++)
            {
                //Check if values[index] is less then min and overwrite
                if (values[i].CompareTo(min) < 0)
                {
                    min = values[i];
                }
            }
            //return lowest value of the ArrayList
            return min;
        }
        
        /// <summary>
        /// Finds the lowest and highest values in an array and returns this as an array
        /// where minmax[0] = lowest and minmax[1] = highest
        /// </summary>
        /// <param name="arr">An array of generic T</param>
        /// <returns>minmax an array wich contain lowest and highest values</returns>
        public T[] FindMinMax(T[] arr)
        {
            //runs trough functions Min() and Max()
            T min = Min(arr);
            T max = Max(arr);

            //Make the array and returns it
            T[] minmax = {min, max};

            return minmax;
        }
    }
}
