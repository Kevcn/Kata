// C# program to print BFS traversal 
// from a given source vertex. 
// BFS(int s) traverses vertices 
// reachable from s. 
using System;
using System.Collections.Generic;
using System.Linq;

namespace BreadthFirstSearch
{
    // This class represents a directed 
    // graph using adjacency list 
    // representation 
    public class Graph
    {
        private readonly int Vertice_size; 

        //Adjacency Lists 
        readonly LinkedList<int>[] nodes; 

        public Graph(int V)
        {
            nodes = new LinkedList<int>[V];
            for(int i = 0; i < nodes.Length; i++)
            {
                nodes[i] = new LinkedList<int>();
            }
            Vertice_size = V;
        }
        
        public void StartFrom(int number)
        {
            Console.Write($"Following is Breadth First " +
                          "Traversal(starting from " +
                          $"vertex {number})\n");
            BFS(number);
        }
        
        public void AddConnection(int v, int w)
        {		 
            nodes[v].AddLast(w);
        }

        // Prints BFS traversal from a given source s 
        private void BFS(int s)
        {
            // Mark all the vertices as not
            // visited(By default set as false) 
            bool[] visited = new bool[Vertice_size];
            for(int i = 0; i < Vertice_size; i++)
                visited[i] = false;
	
            // Create a queue for BFS
            Queue<int> queue = new Queue<int>();

            // Mark the current node as 
            // visited and enqueue it 
            visited[s] = true;
            queue.Enqueue(s);

            while(queue.Any())
            {
                // Dequeue a vertex from queue 
                // and print it
                s = queue.Dequeue();
                Console.Write(s + " " );
		
                // Get all adjacent vertices of the 
                // dequeued vertex s. If a adjacent
                // has not been visited, then mark it 
                // visited and enqueue it 
                LinkedList<int> adjacents_nodes = nodes[s];

                foreach (var node in adjacents_nodes.Where(node => !visited[node]))
                {
                    visited[node] = true;
                    queue.Enqueue(node);
                }
            }
        }
    }
}