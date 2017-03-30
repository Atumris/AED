using System.Collections;
using System.Collections.Generic;

namespace MainDLL
{
    // generic iterator implementation
    public class Stack<T> : IEnumerable<T>
    {
        private T[] values = new T[100];
        private int top = 0;

        // Push function, takes value as a parameter
        public void Push(T t)
        { 
            values[top++] = t; 
        }
        // Pop function
        public T Pop()
        { 
            return values[--top]; 
        }

        // These make Stack<T> implement IEnumerable<T> allowing
        // a stack to be used in a foreach statement.
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = top - 1; i >= 0; i-- )
            {
                // use yield to indicate that the method is an iterator,
                // using yield to define an iterator removes the need for an explicit extra class that holds the state for an enumeration
                yield return values[i];
            }
        }
        // GetEnumerator function
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Iterate from top to bottom.
        public IEnumerable<T> TopToBottom
        {
            get
            {
                // Since we implement IEnumerable<T>
                // and the default iteration is top to bottom,
                // just return the object.
                return this;
            }
        }

        // Iterate from bottom to top.
        public IEnumerable<T> BottomToTop
        {
            get
            {
                for (int i = 0; i < top; i++)
                {
                    // use yield to indicate that the method is an iterator,
                    // using yield to define an iterator removes the need for an explicit extra class that holds the state for an enumeration
                    yield return values[i];
                }
            }
        }

        // A parameterized iterator that return n items from the top
        public IEnumerable<T> TopN(int n)
        {
            // in this example we return less than N if necessary 
            int j = n >= top ? 0 : top - n;

            for (int i = top; --i >= j; )
            {
                // use yield to indicate that the method is an iterator,
                // using yield to define an iterator removes the need for an explicit extra class that holds the state for an enumeration
                yield return values[i];
            }
        }
    }
}
