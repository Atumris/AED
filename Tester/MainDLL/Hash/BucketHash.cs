using System;
using System.Collections;
using System.Collections.Generic;

namespace MainDLL
{
    public class BucketHash<T>
    {
        private const int SIZE = 101;
        ArrayList[] data;
        public BucketHash()
        {
            data = new ArrayList[SIZE];
            for (int i = 0; i <= SIZE - 1; i++)
                data[i] = new ArrayList(4);
        }
        public int Hash(string s)
        {
            long tot = 0;
            char[] charray;
            charray = s.ToCharArray();
            for (int i = 0; i <= s.Length - 1; i++)
                tot += 37 * tot + (int)charray[i];
            tot = tot % data.GetUpperBound(0);
            if (tot < 0)
                tot += data.GetUpperBound(0);
            return (int)tot;
        }
        public void Insert(string item)
        {
            int hash_value;
            hash_value = Hash(value);
            if (data[hash_value].Contains(item))
                data[hash_value].Add(item);
        }
        public void Remove(string item)
        {
            int hash_value;
            hash_value = Hash(item);
            if (data[hash_value].Contains(item))
                data[hash_value].Remove(item);
        }
    }
}
