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
    public class Queue<T> where T : IComparable
    {
        //field for the ArrayList used by the queue
        private readonly ArrayList<T> _queue;

        /// <summary>
        /// Constructur for queue, makes an new arraylist with T
        /// </summary>
        public Queue()
        {
            _queue = new ArrayList<T>();
        }

        /// <summary>
        /// puts item to the back off the queue
        /// </summary>
        /// <param name="item">Item that is added to the queue</param>
        public void EnQueue(T item)
        { 
            _queue.Add(item);
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
        /// <returns>first item in the ArrayList</returns>
        public T Peek()
        {
            return _queue.ToArray()[0];
        }

        /// <summary>
        /// Clears the queue
        /// </summary>
        public void ClearQueue()
        {
            _queue.Clear();
        }


        public int Length()
        {
            return _queue.Length();
        }
    }
}
