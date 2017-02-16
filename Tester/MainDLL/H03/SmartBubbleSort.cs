using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDLL.H03
{
    class SmartBubbleSortt<T> where T : IComparable
    {
        private T[] array;

        /// <summary>
        /// Bubble smart with isSorted flag
        /// </summary>
        /// <param name="inputarray"></param>
        /// <returns name ="inputarray"></returns>
        public static T[] PerformBubbleSort(T[] inputarray)
        {
            //define local variables
            int lenght = inputarray.Length;
            T temp = inputarray[0];
            bool isSorted = false;

            //loop while the list is not sorted
            while (!isSorted)
            {
                //set the state of the local variable to true to stop the loop in case the array is already sorted.
                isSorted = true;
                //loop trough the array length
                for (int i = 0; i < inputarray.Length -1; i++)
                {
                    //check if the inputarray is already sorted or not.
                    if (inputarray[i].CompareTo(inputarray[i + 1]) > 0)
                    {
                        //set the temporary data.
                        temp = inputarray[i];
                        //change the data in the inputarray to compare the data.
                        inputarray[i] = inputarray[i + 1];
                        //set the inputarray data to the temp data to compare that.
                        inputarray[i + 1] = temp;
                        //set the isSorted bool to false to keep itterating.
                        isSorted = false;
                    }
                }
            }
            //return inputarray.
            return inputarray;
        }
    }
}
