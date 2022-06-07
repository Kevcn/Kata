namespace LeetCodeIt;

public class TwoSumII
{
    // pointers on left and right, add and compare with target
    // move left pointer if sum < target
    // move right pointer if sum > target

    public static int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        var output = new int[2];

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];

            if (sum == target)
            {
                output[0] = left + 1;
                output[1] = right + 1;
                break;
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
        var input = new [] {2, 7, 11, 15};

        var output = TwoSum(input, 9);
    }


}