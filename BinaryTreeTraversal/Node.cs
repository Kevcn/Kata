namespace BinaryTreeTraversal
{
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