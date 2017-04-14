/*
=================================================================================	
  
               Vak:	AD


	Gemaakt door: 	Robbie Roeten, Henri Arends, Mirek Nalepa, Patrick Niewold
			        Joey Pieters


	    Docenten:	Jeroen Pijpker, Rob Smit

=================================================================================
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace MainDLL
{
    public class DoublyNode<T>
    {
        public DoublyNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
    }

    public class Deck<T> : IEnumerable<T>  // Doubly linked list
    {
        DoublyNode<T> head; // first element
        DoublyNode<T> tail; // last element
        int count;  // number of items in list

        // Add elements
        public void AddLast(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }

        // Add to top of the que
        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Previous = node;
            }
            count++;
        }
        // Remove first element and sets first element to element next to deleted one
        public T RemoveFirst()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            T output = head.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }
            count--;
            return output;
        }

        // Removes last element and sets tail to element prior to removed one
        public T RemoveLast()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            T output = tail.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
            }
            count--;
            return output;
        }
        // get data of first element
        public T First
        {
            get
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException();
                }
                return head.Data;
            }
        }
        //get data of last element
        public T Last
        {
            get
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException();
                }
                return tail.Data;
            }
        }

        // return number of elements in list
        public int Count 
        { 
            get 
            { 
                return count; 
            } 
        }
        // boolean to check if list is empty, if so returns true
        public bool IsEmpty 
        { 
            get 
            { 
                return count == 0; 
            } 
        }

        // clear the list
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        // check if list contains the data searched for
        public bool Contains(T data)
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}