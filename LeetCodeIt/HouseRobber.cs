namespace LeetCodeIt;

public class HouseRobber
{
    // start from 2
    // compare previous node (num - 1), with [current + (current - 2)]

    public static int Rob(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        if (nums.Length == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }

        int[] dp = new int[nums.Length];

        // Base case - first house
        dp[0] = nums[0];

        // Base case - the higher of the first 2 houses, we need this base case because we'll have to look back 2 indexes
        dp[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < dp.Length; i++)
        {
            var max = Math.Max(nums[i] + dp[i - 2], dp[i - 1]);
            dp[i] = max;
        }

        return dp[nums.Length - 1];
    }

    public static void Run()
    {
        var result = Rob(new int[] {1, 2, 3, 1});
    }
}