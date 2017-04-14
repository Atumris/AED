using System;

namespace MainDLL.Sort
{
    public class BubbleSort<T> where T : IComparable
    {
        /// <summary>
        /// Bubblesort sorts the array with lowest value first
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public T[] Bubble(T[] arr)
        {
            try
            {
                //variable to store the lenght of the array.
                int length = arr.Length;

                //Loop untill there is no more data to loop trough.
                for (int i = 0; i < length; i++)
                {
                    //Loop to get the second index. 
                    for (int j = 0; j < length - 1; j++)
                    {
                        //Check which number is higher and replace in case the next number is lower than the first.
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            //catch and throw the exeption
            catch (Exception e)
            {
                throw e;
            }

            //return the sorted array.
            return arr;
        }
        
        /// <summary>
        /// Method to swap the indexes in the array.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        static void Swap(ref T lhs, ref T rhs)
        {
            var temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
