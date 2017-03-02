using System;

namespace MainDLL.Search
{
    class SequenTialSearch <T> where T : IComparable
    {
        static bool SeqSearch(T[] arr, T sValue)
        {
            int arrLength = arr.Length - 1;
            for (int index = 0; index < arrLength; index++)
                if (arr[index].CompareTo(sValue) == 1) { 
                    return true;
                }
            return false;
        }
    }
}
