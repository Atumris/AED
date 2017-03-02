﻿using System;
using System.Linq;

namespace MainDLL
{
    public class ArrayList <T>
    {
        private T[] array;
        private int size;

        public int Length { get; internal set; }

        /// <summary>
        /// Takes all preperations for a functional arraylist
        /// </summary>
        public ArrayList()
        {
            //size of 0, start of the array
            size = 0;
            //New generic array
            array = new T[size];
        }

        /// <summary>
        /// Add item to the internal array
        /// </summary>
        /// <param name="val">The item T[]</param>
        public void Add(T val)
        {
            //Make copy of array
            T[] overloadArray = array;
            //Increment size of array
            size++;
            //Make new array with new size
            array = new T[size];
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
            array = new T[0];
        }

        /// <summary>
        /// Copy one array to another
        /// </summary>
        /// <param name="val">Target array</param>
        /// <returns>Copied array</returns>
        public T[] CopyTo(T[] val)
        {
            /*Aanpassing nodig
             */
            //Internal array gets coppied to supplied array
            val = array;
            //Return spupplied array
            return val;
        }

        /// <summary>
        /// Check if array contains given value
        /// </summary>
        /// <param name="val">T val, value to check if array contains</param>
        /// <returns>Boolean true for contains or false when it does not contain</returns>
        /*
         * Opsplitsen wanneer array groot is.
         */
        public Boolean Contains(T val)
        {
            //Boolean if it contains or not, init on false.
            bool contains = false;
            //While contains is false, look for a value
                //Go through internal array to look for a value
                foreach (T value in array)
                {
                    //Compare value to given parameter
                    if (value.Equals(val))
                    {
                        //If found, set contains to true
                        contains = true;
                    }
                }
                //Return if the contains
                return contains;
        }

        /// <summary>
        /// Checks if given array is equal to internal array
        /// </summary>
        /// <param name="val">Array to check if equal</param>
        /// <returns>Bool if equal = true</returns>
        public bool Equals(T[] val)
        {
            //Set the value of the boolean
            bool equals = val.Equals(array);
            //Returns the boolean
            return equals;
        }

        /// <summary>
        /// Returns lenght of the ArrayList
        /// </summary>
        /// <returns>int lenght</returns>
        public int Lenght()
        {
            return size;
        }


        /// <summary>
        /// Returns the internal array
        /// </summary>
        /// <returns>Array</returns>
        public T[] ToArray()
        {
            return array;
        }

        /// <summary>
        /// Adds multiple values from input array to internal array
        /// </summary>
        /// <param name="value">Array with values to add</param>
        public void Add(T[] value)
        {
            foreach (var var in value)
            {
                //Make copy of array
                T[] overloadArray = array;
                //Increment size of array
                size++;
                //Make new array with new size
                array = new T[size];
                //Copy old array to new array
                overloadArray.CopyTo(array, 0);
                //Put value in place
                array[size - 1] = var;
            }
        }

        /// <summary>
        /// RemoveAt is a function to remove entry at given index number.
        /// </summary>
        /// <param name="i">index number</param>
        public void RemoveAt(int i)
        {
            //Check if index is out of range
            if (i < 0 || i > array.Length - 1)
            {
                //Throw exception if index is out of range
                throw new IndexOutOfRangeException("index");
            }
            //Remove item at correct point
            array = array.Skip(i + 1).ToArray();
        }
        /// <summary>
        /// Insert item at given index
        /// </summary>
        /// <param name="newItem">The item to add</param>
        /// <param name="index">The index where the item should go</param>
        public void Insert(T newItem, int index)
        {
            //Check if there are items in the array, if not, just add the item
            if (Length == 0)
            {
                Add(newItem);
            }
            else
            {
                //Convert value to right index value
                index = index - 1;
                //Take items from array to seperate array till desired index
                T[] arr1 = array.Take(index).ToArray();
                //Take items from array to seperate array from desired index
                T[] arr2 = array.Skip(index + 1).Take(Length - index).ToArray();
                //Clear array
                Clear();
                //Add first part to the array
                foreach (var item in arr1)
                {
                    Add(item);
                }
                //Add the new item to the array
                Add(newItem);
                //Add last part to the array
                if (arr2.Length != 0)
                {
                    foreach (var item in arr2)
                    {
                        Add(item);
                    }
                }
            }
        }
    }
}
