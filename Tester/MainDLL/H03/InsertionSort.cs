using System;

namespace MainDLL.H03
{
    class InsertionSort<T> where T : IComparable
    {
        /// <summary>
        /// Method that performs an Insertion Sort on the input array X
        /// </summary>
        /// <param name="inputarray"></param>
        /// <returns></returns>
        public static T[] PerformInsertionSort(T[] inputarray)
        {
            // start looping the array from first item
            for (var i = 0; i < inputarray.Length - 1; i++)
            {
                // index set to second item
                var index = i + 1;
                // loop while there are still items in array
                // Dit klopt niet helemaal miscchien een for each of een flag
                while (index > 0)
                {
                    // a temporary array is generated
                    var temp = inputarray[index - 1];

                    inputarray[index - 1] = inputarray[index];
                    inputarray[index] = temp;
                    // index is lowered by 1
                    index--;
                }
            }
            // return the sorted array
            return inputarray;
        }
    }

}
