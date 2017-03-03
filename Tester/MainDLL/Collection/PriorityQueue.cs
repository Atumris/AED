using System;

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
            //Create new object
            object[] newPq = { priority, item };
            //Get lenght of the current Array
            int length = _queue.Lenght();
            //Current index number
            int index = 0;
            //Field to add object to array add specified index
            int addIndex = 0;
            //flag to stop while loop if positoin is found
            bool foundPriority = false;

            if (length > 0)
            {
                while (!foundPriority)
                {
                    foundPriority = true;

                    if (index < length)
                        foreach (var queueItem in _queue.ToArray()[index])
                        {
                            //Get first item in the object
                            if (index % 2 == 0)
                            {
                                addIndex = (int)queueItem;
                            }
                            //If priority is not yet found continue the loop
                            if (addIndex <= priority)
                            {
                                foundPriority = false;
                            }
                            index++;
                        }
                }
            }
            //Insert item into the array
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