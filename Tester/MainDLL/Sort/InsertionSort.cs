using System;

namespace MainDLL.Sort
{
    public class InsertionSort<T> where T : IComparable
    {
        /// <summary>
        /// Method that performs an Insertion Sort on the inputarray
        /// </summary>
        /// <param name="inputarray"></param>
        /// <returns></returns>
        public T[] InsertSort(T[] inputarray)
        {
            // initialize upper int, array lenth-1
            int upper = inputarray.Length - 1;
            //loop from 1st element
            for (int outer = 1; outer <= upper; outer++)
            {
                // first element stored in temp
                var temp = inputarray[outer];
                var inner = outer;
                // loop through array while compared items match do:
                while (inner > 0 && inputarray[inner - 1].CompareTo(temp) > 0)
                {
                    inputarray[inner] = inputarray[inner - 1];
                    inner -= 1;
                }
                inputarray[inner] = temp;
            }
            // return sorted array
            return inputarray;
        }
    }
}
