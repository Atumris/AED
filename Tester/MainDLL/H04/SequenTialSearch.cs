using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainDLL.H02;

namespace MainDLL.H04
{
    class SequenTialSearch <T> where T : IComparable
    {
        ArrayList<T> asdf = new ArrayList<T>();
        static bool SeqSearch(T[] arr, int sValue)
        {
            for (int index = 0; index < arr.Length - 1; index++)
                if (T[index] == sValue)
                    return true;
            return false;
        }
    }
}
