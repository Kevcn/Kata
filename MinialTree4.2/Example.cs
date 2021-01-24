using System;

namespace MinialTree4._2
{
    public class BinaryTree 
    {
        private Node root;

        /* A function that constructs Balanced Binary Search Tree from a sorted array */
        public Node sortedArrayToBST(int[] arr, int start, int end)
        {
            // var startnumber = arr[start];
            // var endnumber = arr[end];
            
            /* Check Boundaries */
            if (start > end) 
            {
                return null; 
            }

            /* Get the middle element and make it root */
            int mid = (start + end) / 2; 
            Node node = new Node(arr[mid]);

            var currentInserting = arr[mid];
            
            /* Recursively construct the left subtree and make it 
        left child of root */
            node.LeftNode = sortedArrayToBST(arr, start, mid - 1); 

            /* Recursively construct the right subtree and make it 
        right child of root */
            node.RightNode = sortedArrayToBST(arr, mid + 1, end); 

            return node; 
        } 

        /* A utility function to print preorder traversal of BST */
        public virtual void preOrder(Node node) 
        { 
            if (node == null) 
            { 
                return; 
            } 
            Console.Write(node.Number + " "); 
            preOrder(node.LeftNode); 
            preOrder(node.RightNode); 
        }
    }
}