namespace LeetCodeIt;

public class MaxProductSubarray
{
    // Keep track of both min and max for each node to handle negative values

    public static int MaxProduct(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        var globalMax = nums[0];

        var currentMin = nums[0];
        var currentMax = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            var prevMax = currentMax;

            currentMax = Math.Max(nums[i], Math.Max(currentMin * nums[i], currentMax * nums[i]));
            currentMin = Math.Min(nums[i], Math.Min(currentMin * nums[i], prevMax * nums[i]));

            if (currentMax > globalMax)
            {
                globalMax = currentMax;
            }

            // Handle 0 edge case
            if (nums[i] == 0)
            {
                currentMax = 1;
                currentMin = 1;
            }
        }

        return globalMax;
    }

    public static void Run()
    {
        var input = new[] { -4, -3, -2 };

        var result = MaxProduct(input);
    }
}