using System;
using System.Collections.Generic;

namespace MainDLL
{
    class Node<T, U>
    {
        public T key;
        public U value;
        public Node<T, U> next;
        public Node(T key, U value, Node<T, U> next)
        {
            this.key = key;
            this.value = value;
            this.next = next;
        }
    }

    public class HashTable<T, U>
    {
        int length;
        Node<T, U>[] buckets;
        IEqualityComparer<T> iec;
        public HashTable(int length)
        {
            this.length = length;
            buckets = new Node<T, U>[length];
        }

        public void Display()
        {
            for (int bucket = 0; bucket < buckets.Length; bucket++)
            {
                Node<T, U> current = buckets[bucket];
                Console.Write(bucket + ":");
                while (current != null)
                {
                    Console.Write("[" + current.key + "," + current.value + "]");
                    current = current.next;
                }
                Console.WriteLine();
            }
        }

        // function used to get the hashcode for a key
        // returns hashCode
        private int GetHashCode(T key)
        {
            int hashCode = iec.GetHashCode(key);
            return hashCode;
        }

        public void Insert(T key, U value)
        {
            int bucket = GetHashCode(key);
            buckets[bucket] = new Node<T, U>(key, value, buckets[bucket]);
        }
        public void Remove(T key)
        {
            // catch null argument exeption
            if (key == null){
				throw new ArgumentNullException ("key");
            }

            Node<T, U> current = buckets[GetHashCode(key)];
            while (current != null)
            {
                if (current.key.Equals(key)){
                    // remove current entry
                    current.value = default(U);
                    // search next item
                    current = current.next;
                }
            }
            throw new Exception(key + "Not found");
        }
        public U Search(T key)
        {
            Node<T, U> current = buckets[GetHashCode(key)];
            while (current != null)
            {
                if (current.key.Equals(key)){
                    return current.value;
                }
                current = current.next;
            }
            throw new Exception(key + "Not found");
        }
    }
}
