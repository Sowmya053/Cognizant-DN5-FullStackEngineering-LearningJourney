using System;

class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

class Program
{
    static void InOrder(Node root)
    {
        if (root != null)
        {
            InOrder(root.Left);
            Console.Write(root.Data + " ");
            InOrder(root.Right);
        }
    }

    static void Main()
    {
        Node root = new Node(10);
        root.Left = new Node(20);
        root.Right = new Node(30);
        root.Left.Left = new Node(40);
        root.Left.Right = new Node(50);

        Console.WriteLine("Inorder Traversal:");

        InOrder(root);
    }
}