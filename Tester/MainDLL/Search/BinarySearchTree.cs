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
    public void FindNode(T data)
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
                if (Int32.Parse(data.ToString()) == Int32.Parse(current.Data.ToString()))
                {
                    Console.Write(current.Data);
                    break;
                }
                else
                {
                    if (Int32.Parse(data.ToString()) < Int32.Parse(current.Data.ToString()))
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            Console.Write("Not found");
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            Console.Write("Not found");
                            break;
                        }
                    }
                }
            }
        }
    }


    public void InOrder(Node<T> theRoot)
    {
        if (theRoot != null)
        {
            InOrder(theRoot.Left);
            theRoot.DisplayNode();
            InOrder(theRoot.Right);
        }
    }


}