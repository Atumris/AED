using System;
using MainDLL.Lists;

namespace MainDLL.Collection
{
    public class CircularLinkedList<T> where T : IComparable
    {
        private readonly Node<T> _head;
        private int _size;

        /// <summary>
        /// Constructor for LinkedList, creates an empty node to start the List
        /// </summary>
        public CircularLinkedList()
        {
            _head = new Node<T>();
        }

        /// <summary>
        /// Returns the size of the Linkedlist
        /// </summary>
        /// <returns>A int with the size of the List</returns>
        public int Count()
        {
            return _size;
        }

        /// <summary>
        /// Add function, creates an new node and links it to the previous
        /// </summary>
        /// <param name="data">Data that needs to be added</param>
        public void Add(T data)
        {
            //if the LinkedList is empty add data to the first node
            if (_head.Data == null)
            {
                //add data to the first node
                _head.Data = data;
                //increase size for the count method
                _size++;
            }
            else
            {
                //create the new node
                var newNode = new Node<T> { Data = data };
                // add new variable for the while loop
                Node<T> current = _head;
                Node<T> previous = null;
                // as long as there is an next node this loop will continue and adds it to the last node
                while (current.Next != null)
                {
                    current = current.Next;
                    previous = current;
                }
                newNode.Previous = current;
                newNode.Next = _head;
                current.Next = newNode;
                //increase the size for the count method
                _size++;
            }
        }

        /// <summary>
        /// remove the data of the given node and stitch the list back together
        /// </summary>
        /// <param name="data">Which node that has to be deleted</param>
        /// 
        /// Hier zit een fout in.. wat nou als er maar 1 node is???
        public void Remove(T data)
        {
            //Field to remember previous node
            Node<T> previous = null;
            // add new variable for the while loop
            var current = _head;

            //if the data equals the node data the loop while stop
            while (!current.Data.Equals(data))
            {
                //saves previous node
                previous = current;
                //get the next node
                current = current.Next;
            }
            //Saves previous node to current node
            if (previous != null)
            {
                previous.Next = current.Next;
                current.Next.Previous = previous;
            }
            if (current.Next == _head)
            {
                current.Previous.Next = _head;
            }

        }

        /// <summary>
        /// Saves all nodes in a array
        /// </summary>
        /// <returns></returns>
        public T[] GetNodesData()
        {
            var current = _head;
            var tempArray = new ArrayList<T>();
            while (current.Next != null)
            {
                tempArray.Add(current.Data);
                current = current.Next;
            }
            return tempArray.ToArray();
        }

        /// <summary>
        /// Clears the list, everything is set to null
        /// </summary>
        public void Clear()
        {
            _head.Data = default(T);
            _head.Next = null;
            _size = 0;
        }
    }


}
