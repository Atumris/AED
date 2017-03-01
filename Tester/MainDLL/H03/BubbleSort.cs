using System;

namespace MainDLL.H03
{
    public class BubbleSort<T> where T : IComparable
    {
        private T[] array;

        /// <summary>
        /// Bubble sort initioation
        /// </summary>
        /// <param name="inputarray"></param>
        /// <returns name="inputarray"></returns>
        public T[] PerformBubbleSort(T[] inputarray)
        {
            //int to temporarily store data
            T temp = inputarray[0];

            //loop trough the lenght of the array
            for (int i = 0; i < inputarray.Length; i++)
            {
                //loop trough the array from index one
                for (int j = 0; j < inputarray.Length - 1; j++)
                {
                    //compare inputarray element to the next element in array
                    if (inputarray[j].CompareTo(inputarray[i + 1]) > 0)
                    {
                        //store the data in a temporary array
                        temp = inputarray[i];
                        //change the array data to the data stored in the other array to move on.
                        inputarray[i] = inputarray[j];
                        // change the other array to the temporary data state.
                        inputarray[j] = temp;
                    }
                }
              //return sorted array.
            } return inputarray; 
        }

        /// <summary>
        /// Bubblesort sorts the array with lowest value first
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public T[] Bubble(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                        Swap(ref arr[j], ref arr[j + 1]);
                }
            }
            return arr;
        }

        static void Swap(ref T lhs, ref T rhs)
        {
            var temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
