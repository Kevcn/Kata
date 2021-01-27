using System;
using System.Collections.Generic;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given an sorted array of ints, use binary search to find the target
            
            // CurrentPointer = array[count/2] to roof
            
            // Compare the target with currentPointer's value
            
            // If stateemnts -> remove half the array
            int target = 33;
            
            var sortedNumbers = new List<int>{1,2,3,4,5,6,7,8,9,10,11,12,33};
            var collection = new List<int>{1,2,3,4,5,6,9,10,11};

            Console.WriteLine(BinarySearch(target, sortedNumbers));
        }
        
        private static bool BinarySearch(int target, List<int> collection)
        {
            var startIndex = 0;
            var endindex = collection.Count - 1;
            
            if (collection.Count == 0)
            {
                return false;
            }
            
            while (startIndex <= endindex)
            {
                var midIndex = startIndex + (endindex - startIndex) / 2;
            
                var mid = collection[midIndex];

                if (mid == target)
                {
                    return true;
                }

                if (target > mid)
                {
                    startIndex = midIndex + 1;
                }

                if (target < mid)
                {
                    endindex = midIndex - 1;
                }
            }
            
            return false;
        }
    }
}