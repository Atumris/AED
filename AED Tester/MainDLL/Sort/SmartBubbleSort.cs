﻿/*
=================================================================================	
  
               Vak:	AD


	Gemaakt door: 	Robbie Roeten, Henri Arends, Mirek Nalepa, Patrick Niewold
			        Joey Pieters


	    Docenten:	Jeroen Pijpker, Rob Smit

=================================================================================
 */
using System;

namespace MainDLL.Sort
{
    public class SmartBubbleSort<T> where T : IComparable
    {
        /// <summary>
        /// Bubblesort sorts the array with lowest value first
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public T[] SmartBubble(T[] arr)
        {
            try
            {
                //bool to check if the array is already sorted
                bool isSorted = false;
                //get the length of the array
                int length = arr.Length;

                //loop while the list is not sorted
                while (!isSorted)
                {
                    //loop to get the first index
                    for (int i = 0; i < length; i++)
                    {
                        //set the state of the local variable to true to stop the loop in case the array is already sorted.
                        isSorted = false;
                        //loop to get second index
                        for (int j = 0; j < length - 1; j++)
                        {
                            //swap the indexes when the second is smaller than the first3
                            if (arr[j].CompareTo(arr[j + 1]) > 0)
                                Swap(ref arr[j], ref arr[j + 1]);
                            //set the boolean to false so the loop continues untill it is sorted.
                            isSorted = true;
                        }   
                    }
                }
            }
            // catch and throw the exeption
            catch (Exception e)
            {
                throw e;
            }
            //return sorted array
            return arr;
        }

        /// <summary>
        /// Method to swap the indexes in the array.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        static void Swap(ref T lhs, ref T rhs)
        {
            var temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}