namespace LeetCodeIt;

public class HouseRobber2
{
    // decalre base cases

    // fill in DPs

    // check if we are at the final index

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

        var first = Helper(nums[..^1]);
        var second = Helper(nums[1..]);

        var max = Math.Max(first, second);

        return max;
    }

    private static int Helper(int[] nums)
    {
        var dp = new int[nums.Length];

        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < dp.Length; i++)
        {
            dp[i] = Math.Max(nums[i] + dp[i - 2], dp[i - 1]);
        }

        return dp[nums.Length - 1];
    }

    public static void Run()
    {
        var result = Rob(new int[] {2});
    }
}