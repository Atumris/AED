using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDLL.Search
{
    public class BinarySearch
    {
        /// <summary>
        /// Search for the value in an array
        /// </summary>
        /// <param name="item">int to find</param>
        /// <param name="collection">Array of int</param>
        /// <returns>Bool true or false</returns>
        public bool BinSearch(int item, int[] collection)
        {
            int len = collection.Length;
            //Take first half of collection
            int[] p1 = collection.Take(len / 2).ToArray();
            //Take second half of collection
            int[] p2 = collection.Skip(len / 2).ToArray();
            int[] col1 = null;
            int[] col2 = null;
            bool found = false;
            //While not found, continue searching
            while (!found)
            {
                //Check if the lenght of the array is bigger then 1
                if (p1.Length <= 1 || p2.Length <= 1)
                {
                    //Check if the only item in array is the item to find
                    if (Int32.Parse(p1.GetValue(0).ToString()) == item || Int32.Parse(p2.GetValue(0).ToString()) == item)
                    {
                        return true;
                    }
                    return found;
                }
                //Get value of first part of array to test
                int p1val = Int32.Parse(p1.GetValue(p1.Length - 1).ToString());
                //Get value of second part of array to test
                    int p2val = Int32.Parse(p2.GetValue(0).ToString());
                //If first part is bigger the item, get both halfs from first half
                    if (p1val > item)
                    {
                        col1 = p1.Take(p1.Length / 2).ToArray();
                        col2 = p1.Skip(p1.Length / 2).ToArray();
                        p1 = col1;
                        p2 = col2;
                    }
                    //If it is smaller then the 2nd half of the array, take items from that
                    else if (p2val < item)
                    {
                        col1 = p2.Take(p2.Length / 2).ToArray();
                        col2 = p2.Skip(p2.Length / 2).ToArray();
                        p1 = col1;
                        p2 = col2;
                    }
                    //Check if item is equal to the value
                    else if (p2val == item || p1val == item)
                    {
                        return true;
                    }
                
             
            }
            return found;
        }
    }
}
