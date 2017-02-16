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

        public static T[] PerformBubbleSort(T[] inputarray)
        {
            int lenght = inputarray.Length;
            T temp = inputarray[0];
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < inputarray.Length -1; i++)
                {
                    if (inputarray[i].CompareTo(inputarray[i + 1]) > 0)
                    {
                        temp = inputarray[i];
                        inputarray[i] = inputarray[i + 1];
                        inputarray[i + 1] = temp;
                        isSorted = false;
                    }
                }
            }
            return inputarray;
        }
    }
}
