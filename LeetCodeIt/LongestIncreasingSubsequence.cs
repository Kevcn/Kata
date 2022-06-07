namespace LeetCodeIt;

public class LongestIncreasingSubsequence
{
    // from left to right, base case will be 1
    // find the maximum longest in the numbers that are smaller than the current number

    public static int LengthOfLIS(int[] nums)
    {
        var dp = new Dictionary<int, int>();

        dp[nums[0]] = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            var maxLength = dp
                .Where(x => x.Key < nums[i])
                .OrderByDescending(x => x.Value).FirstOrDefault().Value;

             dp[nums[i]] = maxLength + 1;
        }

        return dp.Max(x => x.Value);
    }

    public static void Run()
    {
        var input1 = new int[] {10,9,2,5,3,7,101,18};

        var output = LengthOfLIS(input1);
    }
}