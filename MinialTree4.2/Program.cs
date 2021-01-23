namespace MinialTree4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> sortedNumbers = new List<int>
            // {
            //     1,2,3,4,5,6,7,8,9,10
            // };
            //
            // var binarySearchTree = new BinarySearchTree();
            //
            // binarySearchTree.Create(sortedNumbers);
            //
            
            // *** Just memories this! ***

            var example = new BinaryTree();
            
            var sortedArray = new int[]{1,2,3,4,5,6,7,8,9,10};
            var tree = example.sortedArrayToBST(sortedArray, 0, sortedArray.Length - 1);
        }
    }
}