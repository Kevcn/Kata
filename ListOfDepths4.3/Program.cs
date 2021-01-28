using System;
using System.Collections.Generic;

namespace ListOfDepths4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Solve(5);

            var root = tree.GetTree();
            tree.InsertValue(root, 3);
            tree.InsertValue(root, 2);
            tree.InsertValue(root,1);
            tree.InsertValue(root, 4);
            tree.InsertValue(root, 7);
            tree.InsertValue(root, 6);
            tree.InsertValue(root, 8);

            var inti = 0;
            
            // tree.PreOrderTraverse(root, ref inti);

            var lists = new List<List<Node>>();
            
            // This makes perfect sense, basically scaning level by level
            var output = tree.BFS_Approach(root);
            
        }
    }
}