using System;

namespace BinaryTreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var tree = new Traverse(10);

            var root = tree.GetTree();
            tree.InsertValue(root,2);
            tree.InsertValue(root, 5);
            tree.InsertValue(root, 6);
            tree.InsertValue(root, 7);
            tree.InsertValue(root, 22);
            tree.InsertValue(root, 35);

            var inorder = tree.InOrderTraserse(root);

            foreach (var number in inorder)
            {
                Console.Write(number + " ");
            }

            Console.Write("\n");

            var preOrder = tree.PreOrderTraverseIteratively(root);
            
            foreach (var number in preOrder)
            {
                Console.Write(number + " ");
            }
            
            Console.Write("\n");
            tree.PreOrderTraverse(root);
        }
    }
}