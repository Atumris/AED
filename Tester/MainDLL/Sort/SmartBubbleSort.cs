using System;

namespace MainDLL.Sort
{
    class SmartBubbleSort<T> where T : IComparable
    {
        /// <summary>
        /// Bubblesort sorts the array with lowest value first
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public T[] SmartBubble(T[] arr)
        {
            try
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
                            //swap the indexes when the second is smaller than the first3

                            var temp = arr[j];
                            arr[j] = arr[j + i];
                            arr[j + i] = temp;
                            //set the boolean to false so the loop continues untill it is sorted.
                            isSorted = false;
                        }
                    }
                }
            }
            // catch and throw the exeption
            catch (Exception e)
            {
                throw e;
            }
            //return sorted array
            return arr;
        }
    }
}