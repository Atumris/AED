using System;

namespace MainDLL.Sort
{
    public class InsertionSort<T> where T : IComparable
    {
        /// <summary>
        /// Method that performs an Insertion Sort on the input array X
        /// </summary>
        /// <param name="inputarray"></param>
        /// <returns></returns>
        public T[] InsertSort(T[] inputarray)
        {
            int upper = inputarray.Length - 1;
            for (int outer = 1; outer <= upper; outer++)
            {
                var temp = inputarray[outer];
                var inner = outer;
                while (inner > 0 && inputarray[inner - 1].CompareTo(temp) > 0)
                {
                    inputarray[inner] = inputarray[inner - 1];
                    inner -= 1;
                }
                inputarray[inner] = temp;
            }
            return inputarray;
        }
    }
}
