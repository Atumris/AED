using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDLL.Lists
{
    public class Node<T> where T : IComparable
    {
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
        public T Data { get; set; }
    }
}
