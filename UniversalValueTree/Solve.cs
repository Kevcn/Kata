using System;
using System.Collections.Generic;

namespace UniversalValueTree
{
    public class Solve
    {
        // TODO: Needs to check the sub-trees
        
        // Traverse through all nodes
        // If right node == left node -> Add 1 to the output

        private int numberOfUnivalTrees = 0;

        public int Find(Node node)
        {
            Traverse(node);
            return numberOfUnivalTrees;
        }
        
        public void Traverse(Node node)
        {
            if (node is null)
            {
                return;
            }

            if (node.LeftNode is null && node.RightNode is null)
            {
                numberOfUnivalTrees++;
            }

            if (node.LeftNode != null && node.RightNode != null &&
                node.LeftNode.Value == node.RightNode.Value)
            {
                numberOfUnivalTrees++;
            }

            Traverse(node.LeftNode);
            Traverse(node.RightNode);
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