#nullable enable
using System;
using System.Collections.Generic;

namespace MinialTree4._2
{
    public class BinarySearchTree
    {
        // *** Attempt, Don't work ***
        
        
        private Node Tree;
        
        // Take the middle index, rounded up as the root
        // Split the list into 2. 
        // Take the middle index , set it as the node number,
        // Split the list into 2.
        
        public void Create(List<int> numbers)
        {
            // var rootNumber = numbers[numbers.Count / 2];
            // Tree = new Node(rootNumber);
            // var l = numbers.GetRange(0, numbers.Count / 2);
            // var r = numbers.GetRange(numbers.Count / 2 + 1, numbers.Count / 2 - 1);
            //
            // ProcessNode(Tree, l, r);

            Tree = AddNode(numbers, 0, numbers.Count - 1);
        }

        private Node AddNode(List<int> numbers, int start, int end)
        {
            if (end <= start)
            {
                return null;
            }
            
            var mid = (numbers[start] + numbers[end]) / 2;
            var node = new Node(mid);
            
            node.LeftNode = AddNode(numbers, start, mid - 1);
            node.RightNode = AddNode(numbers, mid + 1, end);
            
            return node;
        }

        private void ProcessNode(Node parentNode, List<int> left, List<int> right)
        {
            if (left.Count > 1)
            {
                var leftNumber = left[left.Count / 2];
                var leftNode = new Node(leftNumber);
                parentNode.LeftNode = leftNode;
                
                var l = left.GetRange(0, left.Count / 2);
                var r = left.GetRange(left.Count / 2 + 1, left.Count / 2 - 1);
                
                ProcessNode(leftNode, l, r);
            }

            if (right.Count > 1)
            {
                var rightNumber = right[right.Count / 2];
                var rightNode = new Node(rightNumber);
                parentNode.RightNode = rightNode;

                var l = right.GetRange(0, right.Count / 2);
                var r = right.GetRange(right.Count / 2 + 1, right.Count / 2 - 1);

                ProcessNode(rightNode, l, r);
            }
        }
        
    }

    public class Node
    {
        public Node(int number)
        {
            Number = number;
            LeftNode = null;
            RightNode = null;
        }
        
        public int Number { get; set; }

        public Node? LeftNode { get; set; }

        public Node? RightNode { get; set; }
    }
    
}