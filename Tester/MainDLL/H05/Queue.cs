using System;
using MainDLL.H02;

namespace MainDLL.H05
{
    public class Queue<T> where T : IComparable
    {
        private ArrayList<T> queue;

        public Queue()
        {
            queue = new ArrayList<T>();
        }

        public void EnQueue(T item)
        {
            queue.Add(item);
        }
        public void DeQueue()
        {
            queue.RemoveAt(0);
        }
        public T Peek()
        {
                return queue.ToArray()[0];
        }
        public void ClearQueue()
        {
            queue.Clear();
        }

        public int Length()
        {
            return queue.Length;
        }
    }
}
