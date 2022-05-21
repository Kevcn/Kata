using System;

namespace DepthFirstSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph(9);
            
            graph.AddConnection(0, 1); 
            graph.AddConnection(0, 2); 
            graph.AddConnection(1, 5);
            graph.AddConnection(1, 0);
            graph.AddConnection(2, 6); 
            graph.AddConnection(2, 4); 
            graph.AddConnection(2, 0);
            graph.AddConnection(3, 6);
            graph.AddConnection(3, 7);
            graph.AddConnection(4, 2);
            graph.AddConnection(4, 7);
            graph.AddConnection(5, 1);
            graph.AddConnection(6, 2);
            graph.AddConnection(6, 3);
            graph.AddConnection(7, 3);
            graph.AddConnection(7, 4);
            // graph.AddConnection(7, 8);

            graph.StartFrom(4);

            // Use queue for storage.

            // Keep a list of visited nodes

            // Mark the node as visited
            // Enqueue the starting node

            // loop - while queue is not empty

                // dequeue from queue

                // Print

                // get all adjecent nodes that has not yet been visited

                // Add to queue while mark them as visited

        }
    }
}