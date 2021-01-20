using System;

namespace DepthFirstSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();
            
            graph.DFS(1);
        }
    }
}