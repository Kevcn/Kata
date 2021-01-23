using System;
using System.Collections.Generic;
using System.Linq;

namespace RouteBetweenNodes4
{
    class Program
    {
        // Implemented a BFS
        private static readonly List<node> Tree = new List<node>();
        
        static void Main(string[] args)
        {
            Insert('S', new List<node>{ new node{ character = 'E' }, new node{ character = 'D'}});
            Insert('D', new List<node>{ new node{ character = 'S' }, new node{ character = 'G'}});
            Insert('E', new List<node>{ new node{ character = 'C' }, new node{ character = 'S'}});
            Insert('G', new List<node>{ new node{ character = 'C' }, new node{ character = 'D'}});
            Insert('C', new List<node>{ new node{ character = 'E' }, new node{ character = 'G'}});
            
            var result = Find('S', 'E');
            Console.WriteLine(result);
        }


        public static void Insert(char c, List<node> links)
        {
            Tree.Add(new node
            {
                character = c, 
                linkedNodes = links
            });
        }
        
        
        static bool Find(char start, char end)
        {
            // find if any node has character 'start'
            var startingNode = Tree.Find(n => n.character == start);
            if (startingNode == null)
                return false;

            startingNode.visited = true;
            
            // set this node to visited
            
            var queue = new Queue<node>();
            
            queue.Enqueue(startingNode);
            
            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();
                if (currentNode.character == end)
                    return true;

                currentNode.visited = true;
                
                foreach (var node in currentNode.linkedNodes.Where(x => x.visited == false))
                {
                    queue.Enqueue(node);
                }
            }

            return false;
        }
    }

    class node
    {
        public node()
        {
            linkedNodes = new List<node>();
        }
        
        public char character { get; set; }
        public bool visited { get; set; }
        public List<node> linkedNodes { get; set; }
    }
}