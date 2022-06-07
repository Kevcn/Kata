using System.Linq;

namespace LeetCodeIt;

public class ThreeSum2
{
    // sort the list first so we can perform 2 sum II
    // include 2 sum
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        // [ -4, -1, -1, 0, 1, 2 ]

        var output = new List<IList<int>>();

        var sortedNums = nums.ToList();
        sortedNums.Sort();

        for (int i = 0; i < sortedNums.Count - 2; i++)
        {
            var target = 0;
            if (i > 0 && sortedNums[i] == sortedNums[i - 1])
            {
                continue;
            }

            var currentNumber = sortedNums[i];

            target = target - currentNumber;

            var results = TwoSum(sortedNums.GetRange(i + 1, sortedNums.Count - (i + 1)).ToArray(), target);

            if (results.Count == 0)
            {
                continue;
            }

            foreach (var result in results)
            {
                output.Add(new List<int> {currentNumber, result[0], result[1]});
            }
        }

        return output;
    }

    private static List<List<int>> TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        var output = new List<List<int>>();

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];

            if (sum == target)
            {
                if (output.All(x => x.First() != numbers[left]))
                {
                    output.Add(new List<int> {numbers[left], numbers[right]});
                }

                left = left + 1;
                right = right - 1;
            }

            if (sum < target)
            {
                left = left + 1;
            }

            if (sum > target)
            {
                right = right - 1;
            }
        }

        return output;
    }

    public static void Run()
    {
        var input = new [] {-1,0,1,2,-1,-4};
        var input2 = new [] { -2,0,0,2,2 };

        var output = ThreeSum(input);
    }
}