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
        
        private readonly List<node> graph;

        public Graph()
        {
            graph = new List<node>();
            Init();
        }
        public void DFS(int number)
        {
            var startingNode = graph.Find(x => x.Number == number);
            if (startingNode is null)
                return;

            var stack = new Stack<node>();
            stack.Push(startingNode);

            while (stack.Any())
            {
                var currentNode = stack.Pop();
                
                currentNode.Visited = true;
                Console.Write(currentNode.Number + " ");

                foreach (var node in currentNode.LinkedNodes.Where(x => x.Visited == false))
                {
                    stack.Push(node);
                }
            }
        }

        private void Init()
        {
            var node1 = new node{
                Number = 1,
                LinkedNodes = new List<node>
                {
                    new node{Number = 2},
                    new node{Number = 3}
                }
            };
            
            var node2 = new node{
                Number = 2,
                LinkedNodes = new List<node>
                {
                    new node{Number = 1},
                    new node{Number = 4},
                    new node{Number = 5}
                }
            };
            
            var node3 = new node{
                Number = 3,
                LinkedNodes = new List<node>
                {
                    new node{Number = 1},
                    new node{Number = 5}
                }
            };
            
            var node4 = new node{
                Number = 4,
                LinkedNodes = new List<node>
                {
                    new node{Number = 2},
                    new node{Number = 5},
                    new node{Number = 6}
                }
            };
            
            var node5 = new node{
                Number = 5,
                LinkedNodes = new List<node>
                {
                    new node{Number = 2},
                    new node{Number = 4},
                    new node{Number = 6}
                }
            };
            
            var node6 = new node{
                Number = 6,
                LinkedNodes = new List<node>
                {
                    new node{Number = 4},
                    new node{Number = 5}
                }
            };
            
            graph.Add(node1);
            graph.Add(node2);
            graph.Add(node3);
            graph.Add(node4);
            graph.Add(node5);
            graph.Add(node6);
        }
    }


    public class node
    {
        public node()
        {
            LinkedNodes = new List<node>();
        }
        
        public int Number { get; set; }

        public bool Visited { get; set; }

        public List<node> LinkedNodes { get; set; }
    }
}