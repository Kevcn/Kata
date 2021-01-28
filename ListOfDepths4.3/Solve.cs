using System;
using System.Collections.Generic;

namespace ListOfDepths4._3
{
    public class Solve
    {
        private Node Tree;

        public Solve(int root)
        {
            Tree = new Node(root);
        }
        
        public void PreOrderApproach(Node node, List<List<Node>> lists, int level)
        {
            if (node == null)
            {
                return;
            }

            var list = new List<Node>();

            if (lists.Count == level)
            {
                list = new List<Node>();

                lists.Add(list);
            } else {
                list = lists[level];
            }
            
            list.Add(node);
            
            PreOrderApproach(node.LeftNode, lists, level + 1);
            PreOrderApproach(node.RightNode, lists, level + 1);
        }

        public List<List<Node>> BFS_Approach(Node node)
        {
            var result = new List<List<Node>>();

            // collects nodes at each level
            var current = new List<Node>();

            if (node != null)
            {
                current.Add(node);
            }

            while (current.Count > 0)
            {
                result.Add(current);  // Add previous level

                var parents = current;
                
                current = new List<Node>();


                foreach (var parent in parents)
                {
                    // Visit the child node
                    if (parent.LeftNode != null)
                    {
                        current.Add(parent.LeftNode);
                    }

                    if (parent.RightNode != null)
                    {
                        current.Add(parent.RightNode);
                    }
                }
                

            }

            return result;
        }
        
        
        public Node GetTree()
        {
            return Tree;
        }
        public Node InsertValue(Node currentNode, int number)
        {
            if (currentNode == null)
            {
                return new Node(number);
            }

            if (currentNode.Value > number)
            {
                currentNode.LeftNode = InsertValue(currentNode.LeftNode, number);
            }
            else
            {
                currentNode.RightNode = InsertValue(currentNode.RightNode, number);
            }

            return currentNode;
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