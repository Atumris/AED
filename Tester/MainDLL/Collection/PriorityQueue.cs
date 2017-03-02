
using System;

namespace MainDLL.Collection
{
    public class PriorityQueue<T> where T : IComparable
    {
        private readonly ArrayList<object> _queue;

        protected PriorityQueue()
        {
            _queue = new ArrayList<object>();
        }

        public void EnQueue(int priority, T item)
        {
            object[] t = new object[2];
            t[0] = priority;
            t[1] = item;

            _queue.Add(t);
        }

        public void DeQueue()
        {
            _queue.RemoveAt(0);
        }

        //public T Peek()
        //{
        //    //return _queue.ToArray()[0];
        //}
        public void ClearQueue()
        {
            _queue.Clear();
        }

        public int Length()
        {
            return _queue.Length;
        }
    }
}