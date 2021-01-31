using System;

namespace ValidateBST
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new Node(5)
            {
                LeftNode = new Node(3)
                {
                    LeftNode = new Node(2)
                    {
                        LeftNode = new Node(1)  // <- change this greater than 5 to break this binary tree
                        {
                            LeftNode = new Node(-2)
                        }
                    },
                    RightNode = new Node(4)
                },
                RightNode = new Node(7)
                {
                    LeftNode = new Node(6),
                    RightNode = new Node(8)
                }
            };
            
            
            var solver = new Solve();
            
            var validate = solver.Traserve(node);
            
            Console.WriteLine(validate);
        }
    }
}