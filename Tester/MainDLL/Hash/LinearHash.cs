using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainDLL
{
    // to do
    // List maken met key, value pair
    // add function that skips collisions
    // size of the lineair hash
    // modulo dus geen 10, 20, 30 alleen priem getallen
    // key hashen

    /// <summary>
    /// A Linear Hash Table Implementation.
    /// Author: Carl Laufer
    /// </summary>
    /// <typeparam name="Tkey"></typeparam>
    /// <typeparam name="Tvalue"></typeparam>
    public class LinearHash<Tkey, Tvalue>
    {
        private List<KeyValuePair<Tkey, Tvalue>[]> keyValue;

        private int p;                      // Pointer (index) to the entry to be split
        private int elementsOfArrayUsed;
        private int loadToMaintain;         // The average number of entries in a chain
        private int maxP;                   // Current hash modulo value
        private int capacity;
        private int originalMaxP;

        private List<KeyValuePair<Tkey, Tvalue>> newItems;
        private List<KeyValuePair<Tkey, Tvalue>> delItems;

        /// <summary>
        /// Creates an instance of a Linear HashTable
        /// </summary>
        /// <param name="capacity">The initial capacity this table has</param>
        /// <param name="loadToMaintain">The hash table load this table will maintain</param>
        public void LinearHashTable(int capacity, int loadToMaintain)
        {
            this.loadToMaintain = loadToMaintain;
            this.capacity = capacity;

            // These were made global as creating Lists is costly and simply clearly the list is less costly
            newItems = new List<KeyValuePair<Tkey, Tvalue>>(loadToMaintain);
            delItems = new List<KeyValuePair<Tkey, Tvalue>>(loadToMaintain);

            keyValue = new List<KeyValuePair<Tkey, Tvalue>[]>(capacity);

            p = 0;
            elementsOfArrayUsed = 0;

            for (int i = 0; i < capacity; i++)
            {
                keyValue.Add(new KeyValuePair<Tkey, Tvalue>[0]);
            }

            maxP = capacity; // Not divided by two, so this is effectively premultiplied by 2
            originalMaxP = capacity;
        }

        #region LINEAR HASH FUNCTIONS
        /// <summary>
        /// The first hash function
        /// </summary>
        /// <param name="gK"></param>
        /// <returns></returns>
        private int Hash(int gK)
        {
            return gK & (maxP - 1); // Equivalent to gK % (maxP) if the initial number of weights is a power of 2
        }

        /// <summary>
        /// The second hash function
        /// </summary>
        /// <param name="gK"></param>
        /// <returns></returns>
        private int HashNext(int gK)
        {
            return gK & (2 * maxP - 1);
        }

        /// <summary>
        /// Performs a standard hash operation. In the collision free case this is just returning the value,
        /// or returning the value mod a prime.
        /// </summary>
        /// <param name="key">The key to hash</param>
        /// <returns>The hashed address</returns>
        private static int StandardHash(Tkey key)
        {
            return unchecked(key.GetHashCode());// % 1048583;
        }

        private Tkey lastKey = default(Tkey);
        private int lastAddr = 0;
        /// <summary>
        /// Gets the hash table address for the current weight table address key
        /// </summary>
        /// <param name="weightTableAddress"></param>
        /// <returns></returns>
        private int GetHashAddress(Tkey weightTableAddress)
        {
            // Small optimisation prevents redundant operations
            // e.g. when TryGetValue is called, then Add is called immediately after
            if (weightTableAddress.Equals(lastKey))
            {
                return lastAddr;
            }

            int gK = StandardHash(weightTableAddress);
            int addr = Hash(gK);
            // If addr is less than p it means that p has already been split, so we need to use the next
            // hash function
            if (addr < p)
            {
                addr = HashNext(gK);
            }
            lastAddr = addr;
            lastKey = weightTableAddress;
            return addr;
        }

        /// <summary>
        /// Add one element to the list, and move the value stored in the old hash location
        /// to the newly added element if the hash value of h1 matches it
        /// </summary>
        private void IncreaseBuckets()
        {
            int newLastAddress = keyValue.Count; // Count will give us the address of the new entry we want to add
            KeyValuePair<Tkey, Tvalue>[] keyValueCache = keyValue[p];
            int length = keyValueCache.Length - 1;

            // Clear these Lists rather than creating a new object as it is faster
            newItems.Clear();
            delItems.Clear();



            // Check the chain at address p for keys that will hash to the newLastAddress
            // under the next hash function
            for (int i = length; i >= 0; --i)
            {
                int hash = HashNext(StandardHash(keyValueCache[i].Key));

                if (hash == newLastAddress)
                {
                    newItems.Add(keyValueCache[i]);
                }
                else
                {
                    delItems.Add(keyValueCache[i]);
                }
            }

            // NOTE: Using a List and ToArray() was found to be faster than growing the array manually
            // and removing an item from the array manually. Removing the item manually was a very 
            // costly operation.

            // Add the moved items to the new entry
            keyValue.Add(newItems.ToArray());

            // Replace the old chain with an array that doesn't have the deleted items
            keyValue[p] = delItems.ToArray();

            // Check to see if p is at the end of the current block
            if (++p == maxP)
            {
                maxP *= 2;
                p = 0;
            }
        }

        /// <summary>
        /// Checks if the current load on the hash table is over the limit
        /// </summary>
        /// <returns>True if the load is over the limit</returns>
        private bool LoadOver()
        {
            return (elementsOfArrayUsed > keyValue.Count * loadToMaintain);
        }
        #endregion

        public void Add(KeyValuePair<Tkey, Tvalue> keyValuePair)
        {
            Add(keyValuePair.Key, keyValuePair.Value);
        }

        public void Clear()
        {
            keyValue.Clear();
            p = 0;
            elementsOfArrayUsed = 0;
            maxP = originalMaxP;
        }

        /// <summary>
        /// Adds a value to the dictionary
        /// </summary>
        /// <param name="key">The key</param>
        /// <param name="value">The value</param>
        public void Add(Tkey key, Tvalue value)
        {
            int addr = GetHashAddress(key);
            if (addr != null)
            {
                KeyValuePair<Tkey, Tvalue>[] keyValueCache = keyValue[addr];


                int length = keyValueCache.Length;

                // NOTE: Here manually resizing is faster than using a List and converting to an array

                // Resize the array
                Array.Resize<KeyValuePair<Tkey, Tvalue>>(ref keyValueCache, length + 1);

                // Set the temporary keyValueCache entry to the key/value pair
                keyValueCache[length] = new KeyValuePair<Tkey, Tvalue>(key, value);

                // Replace the old key/value pair with the new one
                keyValue[addr] = keyValueCache;

                elementsOfArrayUsed++;
            }
            while (LoadOver())
            {
                IncreaseBuckets();
            }
        }

        /// <summary>
        /// See if this hash table contains the specified key
        /// </summary>
        /// <param name="key">The key we want to check existance for</param>
        /// <returns>True if the key is found</returns>
        public bool ContainsKey(Tkey key)
        {
            int addr = GetHashAddress(key);

            for (int i = 0; i < keyValue[addr].Length; i++)
            {
                if (keyValue[addr][i].Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Removes an item from the dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(Tkey key)
        {
            throw new NotImplementedException();
            return false;
        }

        /// <summary>
        /// Tries to get the value associated with the key.
        /// </summary>
        /// <param name="key">The key</param>
        /// <param name="value">The value</param>
        /// <returns>True if the key is found, otherwise false.</returns>
        public bool TryGetValue(Tkey key, out Tvalue value)
        {
            int addr = GetHashAddress(key);

            KeyValuePair<Tkey, Tvalue>[] keyValueCache = keyValue[addr];
            int count = keyValueCache.Length - 1;

            // Check the chain for the key
            for (int i = count; i >= 0; --i)
            {
                if (keyValueCache[i].Key.Equals(key))
                {
                    value = keyValueCache[i].Value;
                    return true;
                }
            }

            value = default(Tvalue);
            return false;
        }

        /// <summary>
        /// Indexers for the Dictionary
        /// </summary>
        /// <param name="key">The key</param>
        /// <returns>The value associated with the key</returns>
        public Tvalue this[Tkey key]
        {
            get
            {
                int addr = GetHashAddress(key);
                KeyValuePair<Tkey, Tvalue>[] keyValueCache = keyValue[addr];
                int length = keyValueCache.Length;

                for (int i = length - 1; i >= 0; --i)
                {
                    if (keyValueCache[i].Key.Equals(key))
                    {
                        return keyValueCache[i].Value;
                    }
                }
                throw new KeyNotFoundException("Key was not in dictionary");
            }

            set
            {
                int addr = GetHashAddress(key);

                KeyValuePair<Tkey, Tvalue>[] keyValueCache = keyValue[addr];
                int count = keyValueCache.Length - 1;

                for (int i = count; i >= 0; --i)
                {
                    if (keyValueCache[i].Key.Equals(key))
                    {
                        keyValueCache[i] = new KeyValuePair<Tkey, Tvalue>(key, value);
                        return;
                    }
                }
                throw new KeyNotFoundException("Key was not in dictionary");
            }
        }

        public ICollection<Tkey> Keys
        {
            get
            {
                List<Tkey> keys = new List<Tkey>();
                for (int i = 0; i < keyValue.Count; i++)
                {
                    for (int j = 0; j < keyValue[i].Length; j++)
                    {
                        keys.Add(keyValue[i][j].Key);
                    }
                }
                return keys;
            }
        }

        public ICollection<Tvalue> Values
        {
            get
            {
                List<Tvalue> values = new List<Tvalue>();
                for (int i = 0; i < keyValue.Count; i++)
                {
                    for (int j = 0; j < keyValue[i].Length; j++)
                    {
                        values.Add(keyValue[i][j].Value);
                    }
                }
                return values;
            }
        }


        public int Count
        {
            get
            {
                return elementsOfArrayUsed;
            }
        }

        public float MemoryUsed
        {
            get
            {
                int mem = 0;
                for (int i = 0; i < keyValue.Count; i++)
                {
                    mem += keyValue[i].Length;
                }
                return (mem * 8f) / 1024f;
            }
        }
        public void AddData()
        {
            
        }

    }
}
