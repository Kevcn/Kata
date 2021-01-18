using System;

namespace TriesTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            tree.insert("test");
            Console.WriteLine(tree.search("test"));
            Console.WriteLine(tree.search("tes"));
            Console.WriteLine(tree.startsWith("te"));
            Console.WriteLine(tree.startsWith("ts"));
        }
    }
}