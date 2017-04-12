using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDLL.Search
{
    public class Node<T> where T : IComparable<T>
    {
        public T Data;
        public Node<T> Left;
        public Node<T> Right;

        /// <summary>
        /// Display Node Data
        /// </summary>
        public void DisplayNode()
        {
            Console.Write(Data + "\r\n");
        }
    }
}
