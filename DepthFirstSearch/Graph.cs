using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace DepthFirstSearch
{
    public class Graph
    {
        // have a stack (FILO) collection of nodes
        
        // while stack is not empty, find linked nodes where visited is false
        // mark the node as visited
        // print the value
            
        // add node to stack
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

        public void AddConnection(int v, int w)
        {		 
            nodes[v].AddLast(w);
        }
        
        public void StartFrom(int number)
        {
            Console.Write($"Following is Depth First " +
                          "Traversal(starting from " +
                          $"vertex {number})\n");
            DFS(number);
        }

        private void DFS(int number)
        {
            bool[] visited = new bool[Vertice_size];
            // Mark all nodes as not visited initially
            for(int i = 0; i < Vertice_size; i++)
                visited[i] = false;

            var stack = new Stack<int>();
            stack.Push(number);

            visited[number] = true;
            
            while (stack.Any())
            {
                var currentNode = stack.Pop();
                
                Console.Write(currentNode + " ");

                LinkedList<int> adjacents_nodes = nodes[currentNode];

                foreach (var node in adjacents_nodes.Where(node => !visited[node]))
                {
                    visited[node] = true;
                    stack.Push(node);
                }
            }
        }
    }
}