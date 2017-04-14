/*
=================================================================================	
  
               Vak:	AD


	Gemaakt door: 	Robbie Roeten, Henri Arends, Mirek Nalepa, Patrick Niewold
			        Joey Pieters


	    Docenten:	Jeroen Pijpker, Rob Smit

=================================================================================
 */
using System;

namespace MainDLL.Hash
{
    public class LinearHash<T> where T : IComparable
    {
        public class Hashentry
        {
            int key;
            T data;
            public Hashentry(int key, T data) 
            {
                this.key = key;
                this.data = data;
            }
            public int Getkey()
            {
                return key;
            }
            public T Getdata()
            {
                return data;
            }
        }

        private const int MaxSize = 10; //our table size
        Hashentry[] table;
        public LinearHash()
        {
            table = new Hashentry[MaxSize];
            for (int i = 0; i < MaxSize; i++)
            {
                table[i] = null;
            }
        }
        public T Retrieve(int key)
        {
            int hash = key % MaxSize;
            while (table[hash] != null && table[hash].Getkey() != key)
            {
                hash = (hash + 1) % MaxSize;
            }
            if (table[hash] == null)
            {
                return default(T);
            }
            return table[hash].Getdata();
        }
        public void Insert(int key, T data)
        {
            if (!CheckOpenSpace())//if no open spaces available
            {
                return;
            }
            int hash = (key % MaxSize);
            while (table[hash] != null && table[hash].Getkey() != key)
            {
                hash = (hash + 1) % MaxSize;
            }
            table[hash] = new Hashentry(key, data);
        }
        private bool CheckOpenSpace()//checks for open spaces in the table for insertion
        {
            bool isOpen = false;

                for (int i = 0; i < MaxSize; i++)
                {
                    if (table[i] == null)
                    {
                        isOpen = true;
                    }
                }
            
            return isOpen;
        }
        public bool Remove(int key)
        {
            int hash = key % MaxSize;
            while (table[hash] != null && table[hash].Getkey() != key)
            {
                hash = (hash + 1) % MaxSize;
            }
            if (table[hash] == null)
            {
                return false;
            }
            table[hash] = null;
            return true;
        }
        public void Print()
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == null && i <= MaxSize)//if we have null entries
                {
                }
                else
                {
                    var hashentry = table[i];
                    if (hashentry != null) Console.WriteLine("{0}", hashentry.Getdata());
                }
            }
        }
    }
}
