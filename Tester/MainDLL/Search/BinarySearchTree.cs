using System;
using System.Collections.Generic;
using MainDLL;
using MainDLL.Lists;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;
}

public class BinarySearchTree<T>
{
    public Node root;

    public BinarySearchTree()
    {
        root = null;
    }

    public void add(int data)
    {
        Node newNode = new Node();
        newNode.Data = data;
        if (root == null)
        {
            root = newNode;
        }
        else
        {
            Node current = root;
            Node parent;
            while (true)
            {
                parent = current;
                if (data < current.Data)
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
    
}