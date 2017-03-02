using System;

namespace MainDLL.Collection
{
    public class Queue<T> where T : IComparable
    {
        private readonly ArrayList<T> _queue;

        public Queue()
        {
            _queue = new ArrayList<T>();
        }

        public void EnQueue(T item)
        { 
            _queue.Add(item);
        }

        public void DeQueue()
        {
            _queue.RemoveAt(0);
        }

        public T Peek()
        {
            return _queue.ToArray()[0];
        }
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
