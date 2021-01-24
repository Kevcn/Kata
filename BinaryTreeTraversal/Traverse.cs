using System;
using System.Collections.Generic;

namespace BinaryTreeTraversal
{
    public class Traverse
    {
        private Node Tree;

        public Traverse(int rootValue)
        {
            Tree = new Node(rootValue);
        }

        public List<int> InOrderTraserse(Node node)
        {
            List<int> output = new List<int>();
            
            if (node is null)
            {
                return output;
            }

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
                output.Add(currentNode.Value);
                currentNode = currentNode.RightNode;
            }
            
            return output;
        }

        public void PreOrderTraverse(Node node)
        {
            if (node is null)
            {
                return;
            }
            
            Console.Write(node.Value + " ");

            PreOrderTraverse(node.LeftNode);
            PreOrderTraverse(node.RightNode);
        }

        public List<int> PreOrderTraverseIteratively(Node node)
        {
            List<int> output = new List<int>();
            
            if (node is null)
            {
                return output;
            }

            Stack<Node> stack = new Stack<Node>();
            stack.Push(node);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                
                output.Add(currentNode.Value);

                if (currentNode.RightNode != null)
                {
                    stack.Push(currentNode.RightNode);
                }
                
                if (currentNode.LeftNode != null)
                {
                    stack.Push(currentNode.LeftNode);
                }
            }

            return output;
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
            
            //  *** Another approach ***
            // var currentNode = Tree;
            // while (true)
            // {
            //     if (currentNode.Value < number)
            //     {
            //         if (currentNode.LeftNode != null)
            //         {
            //             currentNode = currentNode.LeftNode;
            //         }
            //         else
            //         {
            //             currentNode.LeftNode = new Node(number);
            //             break;
            //         }
            //     }
            //     else
            //     {
            //         if (currentNode.RightNode != null)
            //         {
            //             currentNode = currentNode.RightNode;
            //         }
            //         else
            //         {
            //             currentNode.RightNode = new Node(number);
            //             break;
            //         }
            //     }
            // }
        }
        
    }
}