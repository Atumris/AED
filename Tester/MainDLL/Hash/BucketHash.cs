using System;
using System.Collections.Generic;

namespace MainDLL
{
    // Represents an element which contains a value
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

    // hashtable class
    public class HashTable<T, U>
    {
        int length;
        Node<T, U>[] buckets;
        IEqualityComparer<T> iec;
        // hashtable method, takes int lenght
        public HashTable(int length)
        {
            this.length = length;
            buckets = new Node<T, U>[length];
        }

        // method to display output in console
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

        // insert key value pair into bucketlist
        public void Insert(T key, U value)
        {
            int bucket = GetHashCode(key);
            buckets[bucket] = new Node<T, U>(key, value, buckets[bucket]);
        }

        // remove item from list, takes key as parameter
        public bool Remove(T key)
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
                    current.key = default(T);
                    current.value = default(U);
                    // search next item
                    current = current.next;
                    return true;
                }
            }
            throw new Exception(key + "Not found");
        }
        // search method, search for specific key in list
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
