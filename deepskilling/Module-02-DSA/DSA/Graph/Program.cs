using System;
using System.Collections.Generic;

class Graph
{
    private Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

    public void AddEdge(int u, int v)
    {
        if (!adjList.ContainsKey(u))
            adjList[u] = new List<int>();

        if (!adjList.ContainsKey(v))
            adjList[v] = new List<int>();

        adjList[u].Add(v);
        adjList[v].Add(u);
    }

    public void Display()
    {
        Console.WriteLine("Graph Adjacency List:");

        foreach (var vertex in adjList)
        {
            Console.Write(vertex.Key + " -> ");

            foreach (var neighbor in vertex.Value)
            {
                Console.Write(neighbor + " ");
            }

            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph();

        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 5);

        graph.Display();
    }
}