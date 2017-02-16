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

        public static T[] PerformBubbleSort(T[] inputarray)
        {
            int lenght = inputarray.Length;
            T temp = inputarray[0];

            for (int i = 0; i < lenght; i++)
            {
                for (int j = i+1; j < lenght; j++)
                {
                    if (inputarray[i].CompareTo(inputarray[i + 1]) > 0)
                    {
                        temp = inputarray[i];
                        inputarray[i] = inputarray[j];
                        inputarray[j] = temp;
                    }
                }
            } return inputarray; 
        }
    }
}
