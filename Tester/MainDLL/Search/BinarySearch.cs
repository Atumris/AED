using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDLL.Search
{
    class BinarySearch<T> where T : IComparable
    {
        public bool BinSearch(int item, int[] collection)
        {
            int len = collection.Length;
            int[] p1 = collection.Take(len / 2).ToArray();
            int[] p2 = collection.Skip(len / 2).ToArray();
            bool found = false;
            while (!found)
            {
                if (p1.Length != 1)
                {
                    int p1val = Int32.Parse(p1.GetValue(p1.Length - 1).ToString());
                    int p2val = Int32.Parse(p2.GetValue(0).ToString());
                    if (p1val > item)
                    {
                        p1 = p1.Take(p1.Length / 2).ToArray();
                        p2 = p1.Skip(len / 2).ToArray();
                    }
                    else if (p2val < item)
                    {
                        p1 = p2.Take(p2.Length / 2).ToArray();
                        p2 = p2.Skip(len / 2).ToArray();
                    }
                    else if (p2val == item || p1val == item)
                    {
                        return true;
                    }
                }
                else
                {
                    return found;
                }
            }
            return found;
        }
    }
}
