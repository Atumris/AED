﻿using System;

namespace MainDLL.Sort
{
    class SmartBubbleSort<T> where T : IComparable
    {
        private T[] array;

        /// <summary>
        /// Bubblesort sorts the array with lowest value first
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public T[] SmartBubble(T[] arr)
        {
            //bool to check if the array is already sorted
            bool isSorted = false;
            //get the length of the array
            int length = arr.Length;

            //loop while the list is not sorted
            while (!isSorted)
            {
                //set the state of the local variable to true to stop the loop in case the array is already sorted.
                isSorted = true;
                //loop to get the first index
                for (int i = 0; i < length; i++)
                {
                    //loop to get second index
                    for (int j = 0; j < length - 1; j++)
                    {
                        //check if the second index is smaller than the first
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                        {
                            //swap the indexes when the second is smaller than the first
                            Swap(ref arr[j], ref arr[j + 1]);
                            //set the boolean to false so the loop continues untill it is sorted.
                            isSorted = false;
                        }
                    }
                }
            }
            //return sorted array
            return arr;
        }
        /// <summary>
        /// method to handle index swapping.
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