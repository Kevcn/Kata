using System;

namespace UniversalValueTree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var node = new Node(0)
            {
                LeftNode = new Node(1),
                RightNode = new Node(0)
                {
                    LeftNode = new Node(1)
                    {
                        LeftNode = new Node(1),
                        RightNode = new Node(1)
                    },
                    RightNode = new Node(0)
                }
            };
            
            
            var solver = new Solve();
            var numberOfUnivalTrees = solver.Find(node);
            
            Console.WriteLine(numberOfUnivalTrees);
        }
    }
}