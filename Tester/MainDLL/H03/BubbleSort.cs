using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDLL.H03
{
    class BubbleSortt<T> where T : IComparable
    {
        private T[] array;

        /// <summary>
        /// Bubble sort initioation
        /// </summary>
        /// <param name="inputarray"></param>
        /// <returns name="inputarray"></returns>
        public static T[] PerformBubbleSort(T[] inputarray)
        {
            //int containing the lenght of inputarray
            int lenght = inputarray.Length;
            //int to temporarily store data
            T temp = inputarray[0];

            //loop trough the lenght of the array
            for (int i = 0; i < lenght; i++)
            {
                //loop trough the array from index one
                for (int j = i+1; j < lenght; j++)
                {
                    //compare inputarray element to the next element in array
                    if (inputarray[i].CompareTo(inputarray[i + 1]) > 0)
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
    }
}
