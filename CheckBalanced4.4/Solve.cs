using System;
using System.Collections.Generic;

namespace CheckBalanced4._4
{
    public class Solve
    {
        // Traverse through every node via whichever method (pre/in/post order)
        
        // scan the level/depth/height of each side tree
        
        // if its greater than 1 - it is not balanced

        public void Work(Node node)
        {
            if (node is null)
            {
                return;
            }

            var leftTreeDepth = ScanLevels(node.LeftNode);
            var rightTreeDepth = ScanLevels(node.RightNode);
            
            var nodeIsBalanced = Math.Abs(leftTreeDepth - rightTreeDepth) > 1;
            
            Console.WriteLine($"{node.Value} is balanced: {nodeIsBalanced}");
            // Could add something here to say as soon as 1 tree is not balanced, exit

            Work(node.LeftNode);
            Work(node.RightNode);
            
        }

        private int ScanLevels(Node node)
        {
            if (node is null)
            {
                return 0;
            }
            
            var levels = 0;
            
            var currentNodes = new List<Node>();
            currentNodes.Add(node);

            // means there is at least 1 child node found on the next level
            while (currentNodes.Count > 0)
            {
                levels++;

                var parents = currentNodes;
                
                currentNodes = new List<Node>();

                foreach (var parentNode in parents)
                {
                    if (parentNode.LeftNode != null)
                    {
                        currentNodes.Add(parentNode.LeftNode);
                    }

                    if (parentNode.RightNode != null)
                    {
                        currentNodes.Add(parentNode.RightNode);
                    }
                }
            }

            return levels;
        }
        
        public class Node
        {
            public Node(int value)
            {
                Value = value;
                LeftNode = null;
                RightNode = null;
            }
        
            public int Value { get; set; }

            public Node LeftNode { get; set; }

            public Node RightNode { get; set; }
        }
    }
}