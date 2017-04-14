using System;

namespace MainDLL.Search
{
    public class SequenTialSearch <T> where T : IComparable
    {
        /// <summary>
        /// Searches for the value in the given array.
        /// </summary>
        /// <param name="arr">An array of generic T</param>
        /// <param name="sValue">Item to search for</param>
        /// <returns></returns>
        public bool SeqSearch(T[] arr, T sValue)
        {
            try { 
            // Sla de lengte van de array op in een variabele voor efficientie
            int arrLength = arr.Length - 1;
                // Loop door de array
                for (int index = 0; index < arrLength; index++) { 
                    // Als de waarde gevonden is return true
                    if (arr[index].CompareTo(sValue) == 1) { 
                        return true;
                    }
                }
                // Is de waarde niet gevonden? Return false
                return false;
            }
            catch (Exception e)
            {
                // Throw exception 
                throw e;
            }
        }
    }
}
