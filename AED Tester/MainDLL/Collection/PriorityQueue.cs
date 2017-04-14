/*
=================================================================================	
  
               Vak:	AD


	Gemaakt door: 	Robbie Roeten, Henri Arends, Mirek Nalepa, Patrick Niewold
			        Joey Pieters


	    Docenten:	Jeroen Pijpker, Rob Smit

=================================================================================
 */
using System;

namespace MainDLL.Collection
{
    public class PriorityQueue<T> where T : IComparable
    {
        //field for the ArrayList used by the queue
        private readonly ArrayList<PqItem> _queue;

        /// <summary>
        /// Constructor for queue, makes an new arraylist with PqItem
        /// </summary>
        public PriorityQueue()
        {
            _queue = new ArrayList<PqItem>();
        }

        /// <summary>
        /// Create a struct to propererly add an item with priority to the ArrayList
        /// </summary>
        public struct PqItem
        {
            public int Priority;
            public T Item;

            /// <summary>
            /// Constructor PqItem stores the priorty and item in the struct
            /// </summary>
            /// <param name="priority">Priority of queue item</param>
            /// <param name="item">queue item</param>
            public PqItem(int priority, T item)
            {
                Priority = priority;
                Item = item;
            }
        }

        /// <summary>
        /// Adds an item to the queue based on priority where 0 is the highest priority
        /// </summary>
        /// <param name="priority">Priority given to the item</param>
        /// <param name="item">Item that is added to the que</param>
        public void EnQueue(int priority, T item)
        {
            //Check if priority is out of range
            if (priority < 0)
            {
                //Throw exception if priority is out of range
                throw new IndexOutOfRangeException("priority must be 0 or higher");
            }
            //Create new Priorty Queue item
            var newPq = new PqItem(priority, item);

            //Get array and store it into field
            var pqArray = _queue.ToArray();

            //Get length of the current Array
            var length = _queue.Length() - 1;

            //if queue array is empty add the item
            if (length < 0)
            {
                _queue.Add(newPq);
            }
            else
            {
                //Get the lowest priority of the items in the queue
                var lowestPriority = pqArray[length].Priority;

                //if lower or equal to the lowest add to back of the queue
                if (newPq.Priority > lowestPriority || newPq.Priority.Equals(lowestPriority))
                {
                    _queue.Add(newPq);
                }
                else
                {
                    //Create an index field for insert method
                    var index = 0;

                    //Determine the index for the insert method
                    for (var i = 0; i < length; i++)
                    {
                        //if priority is higher then item in queue increment index
                        if (newPq.Priority >= pqArray[i].Priority)
                        {
                            index++;
                        }
                    }

                    //Insert item into the array at given index value
                    _queue.Insert(newPq, index);
                }
            }
        }

        /// <summary>
        /// Removes item from the front of the queue
        /// </summary>
        public void DeQueue()
        {
            _queue.RemoveAt(0);
        }

        /// <summary>
        /// Returns first item of the queue
        /// </summary>
        /// <returns>First item</returns>
        public T Peek()
        {
            return _queue.ToArray()[0].Item;
        }

        /// <summary>
        /// Clears the queue
        /// </summary>
        public void ClearQueue()
        {
            _queue.Clear();
        }

        /// <summary>
        /// Get the queue back as a array
        /// </summary>
        /// <returns>PqItem array</returns>
        public PqItem[] ToArray()
        {
            return _queue.ToArray();
        }

        /// <summary>
        /// Returns the length of the Queue Array
        /// </summary>
        /// <returns>Length of the array as an int</returns>
        public int Length()
        {
            return _queue.Length();
        }
    }
}