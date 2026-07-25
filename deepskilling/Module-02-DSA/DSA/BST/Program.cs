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

class BST
{
    public Node Insert(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = Insert(root.Left, data);
        else if (data > root.Data)
            root.Right = Insert(root.Right, data);

        return root;
    }

    public void InOrder(Node root)
    {
        if (root != null)
        {
            InOrder(root.Left);
            Console.Write(root.Data + " ");
            InOrder(root.Right);
        }
    }

    public bool Search(Node root, int key)
    {
        if (root == null)
            return false;

        if (root.Data == key)
            return true;

        if (key < root.Data)
            return Search(root.Left, key);

        return Search(root.Right, key);
    }
}

class Program
{
    static void Main()
    {
        BST tree = new BST();
        Node root = null;

        root = tree.Insert(root, 50);
        root = tree.Insert(root, 30);
        root = tree.Insert(root, 70);
        root = tree.Insert(root, 20);
        root = tree.Insert(root, 40);
        root = tree.Insert(root, 60);
        root = tree.Insert(root, 80);

        Console.WriteLine("Inorder Traversal:");
        tree.InOrder(root);

        Console.WriteLine();

        int key = 40;

        if (tree.Search(root, key))
            Console.WriteLine(key + " found in BST.");
        else
            Console.WriteLine(key + " not found in BST.");
    }
}