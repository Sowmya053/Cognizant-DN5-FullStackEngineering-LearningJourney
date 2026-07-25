# Graph

## Aim

To create a graph using an adjacency list and display its vertices and edges.

## Theory

A Graph is a collection of vertices connected by edges.

### Types of Graph

- Undirected Graph
- Directed Graph
- Weighted Graph
- Unweighted Graph

### Representation

- Adjacency Matrix
- Adjacency List

This example uses an adjacency list.

## Time Complexity

| Operation | Complexity |
|----------|------------|
| Add Edge | O(1) |
| Display | O(V + E) |

where:
- V = Number of Vertices
- E = Number of Edges

## Sample Output

Graph Adjacency List:
1 -> 2 3
2 -> 1 4
3 -> 1 5
4 -> 2
5 -> 3