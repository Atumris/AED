using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDLL.H02
{
    class ArrayList <X> where X : IComparable
    {
        private X[] array;
        private int size;

        /// <summary>
        /// Takes all preperations for a functional arraylist
        /// </summary>
        public ArrayList()
        {
            //size of 0, start of the array
            size = 0;
            //New generic array
            array = new X[size];
        }

        /// <summary>
        /// Add item to the internal array
        /// </summary>
        /// <param name="val">The item X[]</param>
        public void Add(X val)
        {
            //Make copy of array
            X[] overloadArray = array;
            //Increment size of array
            size++;
            //Make new array with new size
            array = new X[size];
            //Copy old array to new array
            overloadArray.CopyTo(array, 0);
            //Put value in place
            array[size - 1] = val;
        }

        /// <summary>
        /// Clears internal array
        /// </summary>
        public void Clear()
        {
            //Makes new array with a size of 0
            array = new X[0];
        }

        /// <summary>
        /// Copy one array to another
        /// </summary>
        /// <param name="val">Target array</param>
        /// <returns>Copied array</returns>
        public X[] CopyTo(X[] val)
        {
            //Internal array gets coppied to supplied array
            val = array;
            //Return spupplied array
            return val;
        }

        /// <summary>
        /// Check if array contains given value
        /// </summary>
        /// <param name="val">X val, value to check if array contains</param>
        /// <returns>Boolean true for contains or false when it does not contain</returns>
        public Boolean Contains(X val)
        {
            //Boolean if it contains or not, init on false.
            bool contains = false;
            //While contains is false, look for a value
            while (contains == false)
            {
                //Go through internal array to look for a value
                foreach (X value in array)
                {
                    //Compare value to given parameter
                    if (value.Equals(val))
                    {
                        //If found, set contains to true
                        contains = true;
                    }
                }
                //If not found, return this
                return contains;
            }
            //If found, return this
            return contains;
        }

    }
}
