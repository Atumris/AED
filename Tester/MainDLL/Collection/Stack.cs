using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainDLL.Collection;

namespace MainDLL.Collection
{
    public class Stack<T> where T : IComparable
    {
        private int p_index;
        private ArrayList<T> list;
        public void CStack()
        {
            list = new ArrayList<T>();
            p_index = -1;
        }
        public int count
        {
            get
            {
                return list.Length;
            }
        }
        public void push(T item)
        {
            list.Add(item);
            p_index++;
        }
        public object pop()
        {
            object obj = list[p_index];
            list.RemoveAt(p_index);
            p_index--;
            return obj;
        }
        public void clear()
        {
            list.Clear();
            p_index = -1;
        }
        public object peek()
        {
            return list[p_index];
        }
    }
}
