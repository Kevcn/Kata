namespace LeetCodeIt;

public class MaxSubarray
{
    // Again, the trick here is to keep track of the max, and compare it with the current max - replace accordingly
    // Kadane's Algorithm

    public static int MaxSubArray(int[] nums)
    {
        // a max variable to be returned
        // a current max variable

        // current max = current max + current pointer
        // if current pointer > current max
        // current max = current pointer
        // if current max > max
        // max = current max

        if (nums.Length == 1)
        {
            return nums[0];
        }

        var max = nums[0];
        var current = max;

        for (int i = 1; i < nums.Length; i++)
        {
            current = current + nums[i];

            if (current < nums[i])
            {
                current = nums[i];
            }

            if (current > max)
            {
                max = current;
            }
        }

        return max;
    }

    public static void Run()
    {
        var input = new[] { -2, -1 };

        var result = MaxSubArray(input);

    }
}