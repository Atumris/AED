
using System;
using System.Collections;

namespace MainDLL.Collection
{
    public class PriorityQueue<T> where T : IComparable
    {
        private readonly ArrayList<Array> _queue;

        public PriorityQueue()
        {
            _queue = new ArrayList<Array>();
        }

        public void EnQueue(int priority, T item)
        {
            object[] newPq = { priority, item };

            int length = _queue.Lenght();
            int index = 0;
            int addIndex = 0;

            bool foundPriority = false;

            if (length > 0)
            {
                while (!foundPriority)
                {
                    foundPriority = true;

                    if (index < length)
                        foreach (var queueItem in _queue.ToArray()[index])
                        {
                            if (index % 2 == 0)
                            {
                                addIndex = (int)queueItem;
                            }
                            if (addIndex == priority)
                            {
                                foundPriority = false;
                            }
                            index++;
                        }
                }

                Console.WriteLine("found");
            }
            //veranderen naar insert
            _queue.Insert(newPq, index);
        }

        public void DeQueue()
        {
            _queue.RemoveAt(0);
        }

        public T Peek()
        {
            int index = 0;
            if (_queue.Lenght() > 0)
            {
                foreach (var queueItem in _queue.ToArray()[0])
                {
                    if (index == 1)
                    {
                        return (T) queueItem;
                    }
                    index++;
                }
            }
            return default(T);
        }

        public void ClearQueue()
        {
            _queue.Clear();
        }
    }
}