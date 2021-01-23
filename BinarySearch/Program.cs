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
            
            var sortedNumbers = new List<int>
            {
                1,2,3,4,5,6,7,8,9,10,11,12
            };
            
            var stop = false;

            while (!stop)
            {
                if (sortedNumbers.Count < 2)
                {
                    stop = true;
                }
                
                var currentPointer = sortedNumbers[sortedNumbers.Count / 2];

                if (currentPointer == target)
                {
                    Console.WriteLine($"Found target {target}");
                    return;
                }
                
                if (currentPointer > target)
                {
                    sortedNumbers.RemoveRange(sortedNumbers.Count / 2, sortedNumbers.Count / 2);
                }
                else
                {
                    sortedNumbers.RemoveRange(0, sortedNumbers.Count / 2);
                }
            }
            
            Console.WriteLine("Target not found");
        }
    }
}