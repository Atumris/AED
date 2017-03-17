using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainDLL.Collection;


namespace MainDLL.Collection
{
    /// <summary>
    /// Pushes, pops and peeks at items in the element. 
    /// </summary>
    /// <typeparam name="T">Item the put in the ArrayList</typeparam>
    public class Stack<T> where T : IComparable
    {
        private int p_index;
        private ArrayList<T> list = new ArrayList<T>();

        /// <summary>
        /// Returns the number of items in the ArrayList
        /// </summary>
        public int count
        {
            get
            {
                return list.Length();
            }
        }

        /// <summary>
        /// Pushes new items in the ArrayList
        /// </summary>
        /// <param name="item"></param>
        public void push(T item)
        {
            list.Add(item);
            p_index++;
        }

        /// <summary>
        /// Pops the top item in the ArrayList
        /// </summary>
        /// <returns>Last item in the ArrayList</returns>
        public T Pop()
        {
            if (list.Length() > 0)
            {
                T temp = list.ToArray()[list.Length() - 1];
                list.RemoveAt(list.Length() - 1);
                p_index--;
                return temp;
            }
            else { 
                return default(T);
            }
        }

        /// <summary>
        /// Clears the ArrayList
        /// </summary>
        public void clear()
        {
            list.Clear();
        }

        /// <summary>
        /// Get the top item in the ArrayList
        /// </summary>
        /// <returns></returns>
        public object peek()
        {
            return list.ToArray()[list.Length()-1];
        }
    }
}