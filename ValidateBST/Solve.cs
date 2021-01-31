using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidateBST
{
    public class Solve
    {
        // In-order trversal
        // add number into a list, get the last index of the list, if it is smaller, return false


        public bool Traserve(Node node)
        {
            if (node is null)
            {
                return false;
            }

            int lastNumber = -999;
            
            Stack<Node> stack = new Stack<Node>();
            
            var currentNode = node;

            while (currentNode != null || stack.Count != 0)
            {
                // Traverse to left most node
                while (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.LeftNode;
                }

                currentNode = stack.Pop();
                
                if (lastNumber == -999)
                {
                    lastNumber = currentNode.Value;
                }
                else if (lastNumber > currentNode.Value)
                {
                    return false;
                }
                else
                {
                    lastNumber = currentNode.Value;
                }

                currentNode = currentNode.RightNode;
            }

            return true;
        }
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