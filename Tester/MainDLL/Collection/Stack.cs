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
            p_index -= 1;
        }
        public int count
        {
            get
            {
                return list.Length();
            }
        }

        public void push(T item)
        {
            list.Add(item);
            p_index++;
        }

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

        public void clear()
        {
            list.Clear();
            p_index = -1;
        }
        public object peek()
        {
            return list.ToArray()[list.Length() - 1];
        }
    }
}