/*
=================================================================================	
  
               Vak:	AD


	Gemaakt door: 	Robbie Roeten, Henri Arends, Mirek Nalepa, Patrick Niewold
			        Joey Pieters


	    Docenten:	Jeroen Pijpker, Rob Smit

=================================================================================
 */
using System;
using MainDLL.Search;

/// <summary>
/// Binary search tree:
/// Adding, deleting, ordering and searching
/// </summary>
/// <typeparam name="T">Type to store in the binary search tree</typeparam>
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
    public Node<T> Find(T key)
    {
        Node<T> current = root;
        while (!current.Data.Equals(key))
        {
            if (key.CompareTo(current.Data) < 0)
                current = current.Left;
            else
                current = current.Right;
            if (current == null)
                return null;
        }
        return current;
    }

    /// <summary>
    /// Find lowest value in the binary search tree
    /// </summary>
    /// <returns>Lowest value</returns>
    public Node<T> FindLowestNode()
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
    public Node<T> FindHighestNode()
    {
        Node<T> current = root;
        while (current.Right != null)
        {
            current = current.Right;
        }
        return current;
    }
    
    /// <summary>
    /// List all the nodes in order
    /// </summary>
    /// <param name="root">The root in the binary search tree</param>
    public void InOrder(Node<T> root)
    {
        if (!(root == null))
        {
            InOrder(root.Left);
            root.DisplayNode();
            InOrder(root.Right);
        }
    }

    /// <summary>
    /// List all the nodes in preorder
    /// </summary>
    /// <param name="root">The root in the binary search tree</param>
    public void PreOrder(Node<T> root)
    {
        if (root != null)
        {
            root.DisplayNode();
            PreOrder(root.Left);
            PreOrder(root.Right);
        }
    }

    /// <summary>
    /// List all the nodes in postorder
    /// </summary>
    /// <param name="root">The root in the binary search tree</param>
    public void PostOrder(Node<T> root)
    {
        if (root != null)
        {
            PostOrder(root.Left);
            PostOrder(root.Right);
            root.DisplayNode();
        }
    }
    
    /// <summary>
    /// Delete a node
    /// </summary>
    /// <param name="key">Delete the node</param>
    /// <returns></returns>
    public bool Delete(T key)
    {
        Node<T> current = root;
        Node<T> parent = root;
        bool isLeftChild = true;
        while (!current.Data.Equals(key))
        {
            parent = current;
            if (Int32.Parse(key.ToString()) < Int32.Parse(current.Data.ToString()))
            {
                isLeftChild = true;
                current = current.Right;
            }
            else
            {
                isLeftChild = false;
                current = current.Right;
            }
            if (current == null)
            {
                return false;
            }
        }
        if ((current.Left == null) && (current.Right == null))
            if (current == root)
            {
                root = null;
            }
            else if (isLeftChild)
            {
                parent.Left = null;
            }
            else
            {
                parent.Right = null;
            }
        else if (current.Right == null)
        {
            if (current == root)
            {
                root = current.Left;
            }
            else if (isLeftChild)
            {
                parent.Left = current.Left;
            }
            else
            {
                parent.Right = current.Right;
            }
        }
        else if (current.Left == null)
        {
            if (current == root)
            {
                root = current.Right;
            }
            else if (isLeftChild)
            {
                parent.Left = parent.Right;
            }
            else
            {
                parent.Right = current.Right;
            }
        }
        else
        {
            Node<T> successor = GetSuccessor(current);
            if (current == root)
            {
                root = successor;
            }
            else if (isLeftChild)
            {
                parent.Left = successor;
            }
            else
            {
                parent.Right = successor;
                successor.Left = current.Left;
            }
        }
        return true;
    }

    /// <summary>
    /// Get successor childs
    /// </summary>
    /// <param name="delNode">Node to delete</param>
    /// <returns></returns>
    public Node<T> GetSuccessor(Node<T> delNode)
    {
        Node<T> successorParent = delNode;
        Node<T> successor = delNode;
        Node<T> current = delNode.Right;
        while (!(current == null))
        {
            successorParent = current;
            successor = current;
            current = current.Left;
        }
        if (!(successor == delNode.Right))
        {
            successorParent.Left = successor.Right;
            successor.Right = delNode.Right;
        }
        return successor;
    }
}