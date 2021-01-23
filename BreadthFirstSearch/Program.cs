using System;

namespace BreadthFirstSearch
{
    class Program
    {
        // Put all neighbors into the queue, mark them as visited
        // Get the next value in queue (dequeue item), add this value  into the output list
        // put all neighbors into the queue except the visited nodes, mark them as visited
        
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
            graph.AddConnection(7, 8);

            graph.StartFrom(2);
        }
    }
}