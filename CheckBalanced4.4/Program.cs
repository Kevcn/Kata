using System;

namespace CheckBalanced4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new Solve.Node(5)
            {
                LeftNode = new Solve.Node(3)
                {
                    LeftNode = new Solve.Node(2)
                    {
                        LeftNode = new Solve.Node(1)
                        {
                            LeftNode = new Solve.Node(-2)
                            {
                                RightNode = new Solve.Node(0)
                            }
                        }
                    },
                    RightNode = new Solve.Node(4)
                },
                RightNode = new Solve.Node(7)
                {
                    LeftNode = new Solve.Node(6),
                    RightNode = new Solve.Node(8)
                }
            };
            
            var solve = new Solve();

            solve.Work(node);
        }
    }
}