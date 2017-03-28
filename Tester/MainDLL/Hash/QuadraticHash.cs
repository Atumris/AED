using System;
using System.Collections.Generic;

namespace MainDLL
{
    public class QuadraticHash<Tkey, Tvalue>
    {   
        class hashentry
        {
            public Tkey key;
            public Tvalue value;
            public IEqualityComparer<Tkey> iec;
            public hashentry(Tkey key, Tvalue value)
            {
                this.key = key;
                this.value = value;
            }
            public Tkey getkey()
            {
                return key;
            }
            public Tvalue getdata()
            {
                return value;
            }
        }
        const int maxSize = 10; //our table size
        hashentry[] table;
        IEqualityComparer<Tkey> iec;
        public void hashTable()
        {
            table = new hashentry[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                table[i] = null;
            }
        }
        public string retrieve(Tkey key)
        {
            int hash = iec.GetHashCode();
            while (table[hash] != null && !key.Equals(key))
            {
                hash = (hash + 1) % maxSize;
            }
            if (table[hash] == null)
            {
                return "nothing found!";
            }
            else
            {
                return table[hash].value.ToString();
            }
        }
        public void insert(Tkey key, Tvalue data)
        {
            if (!checkOpenSpace())//if no open spaces available
            {
                Console.WriteLine("table is at full capacity!");
                return;
            }
            int hash = iec.GetHashCode();
            while (table[hash] != null && !key.Equals(key))
            {
                hash = (hash + 1) % maxSize;
            }
            table[hash] = new hashentry(key, data);
        }
        private bool checkOpenSpace()//checks for open spaces in the table for insertion
        {
            bool isOpen = false;
            for (int i = 0; i < maxSize; i++)
            {
                if (table[i] == null)
                {
                    isOpen = true;
                }
            }
            return isOpen;
        }
        // remove function
        public bool remove(Tkey key)
        {
            int hash = iec.GetHashCode();
            while (table[hash] != null && !key.Equals(key))
            {
                hash = (hash + 1) % maxSize;
            }
            if (table[hash] == null)
            {
                return false;
            }
            else
            {
                table[hash] = null;
                return true;
            }
        }

        public void quadraticHashInsert(Tkey key, Tvalue data)
        {
            //quadratic probing method
            if (!checkOpenSpace())//if no open spaces available
            {
                Console.WriteLine("table is at full capacity!");
                return;
            }

            int j = 0;
            int hash = iec.GetHashCode();
            while (table[hash] != null && !key.Equals(key))
            {
                j++;
                hash = (hash + j * j) % maxSize;
            }
            if (table[hash] == null)
            {
                table[hash] = new hashentry(key, data);
                return;
            }
        }
    }
}