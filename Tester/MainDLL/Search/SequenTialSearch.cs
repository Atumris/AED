using System;

namespace MainDLL.Search
{
    class SequenTialSearch <T> where T : IComparable
    {
        static bool SeqSearch(T[] arr, T sValue)
        {
            for (int index = 0; index < arr.Length - 1; index++)
                if (arr[index].CompareTo(sValue) == 1)
                    return true;
            return false;
        }
    }
}
