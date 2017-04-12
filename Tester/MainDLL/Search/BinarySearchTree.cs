using System;
using MainDLL.Search;


public class BinarySearchTree<T> where T : IComparable<T>
{
    public Node<T> root;

    public BinarySearchTree()
    {
        root = null;
    }

    /// <summary>
    /// Add data to the binary search tree
    /// </summary>
    /// <param name="data">Data to add</param>
    public void Add(T data)
    {
        Node<T> newNode = new Node<T>();
        newNode.Data = data;
        if (root == null)
        {
            root = newNode;
        }
        else
        {
            Node<T> current = root;
            Node<T> parent;
            while (true)
            {
                parent = current;
                if (Int32.Parse(data.ToString()) < Int32.Parse(current.Data.ToString()))
                {
                    current = current.Left;
                    if (current == null)
                    {
                        parent.Left = newNode;
                        break;
                    }
                } 
                else
                {
                    current = current.Right;
                    if (current == null)
                    {
                        parent.Right = newNode;
                        break;
                    }
                }
            }
        }

    }

    /// <summary>
    /// Find a node
    /// </summary>
    /// <param name="data">Data for searching</param>
    public Node<T> FindNode(T data)
    {
       Node<T> newNode = new Node<T>();
       Node<T> current = null;
       newNode.Data = data;
       if (root == null)
       {
           root = newNode;
       }
       else
       {
           current = root;
           while (true)
           {
               if (Int32.Parse(data.ToString()) == Int32.Parse(current.Data.ToString()))
               {
                   return current;
                   break;
               }
               else
               {
                   if (Int32.Parse(data.ToString()) < Int32.Parse(current.Data.ToString()))
                   {
                       current = current.Left;
                       if (current == null)
                       {
                           return current;
                           break;
                       }
                   }
                   else
                   {
                       current = current.Right;
                       if (current == null)
                       {
                           return current;
                           break;
                       }
                   }
               }
           }
       }
       return current;
    }

    /// <summary>
    /// Find lowest value in the binary search tree
    /// </summary>
    /// <returns>Lowest value</returns>
    public Node<T> FindMin()
    {
        Node<T> current = root;
        while (current.Left != null)
        {
            current = current.Left;
        }
        return current;
    }

    /// <summary>
    /// Find lowest value in the binary search tree
    /// </summary>
    /// <returns>Lowest value</returns>
    public Node<T> FindMax()
    {
        Node<T> current = root;
        while (current.Right != null)
        {
            current = current.Right;
        }
        return current;
    }


}