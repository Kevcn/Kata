using Microsoft.AspNetCore.WebUtilities;

namespace LeetCodeIt;

public class JumpGame
{
    public static bool CanJump(int[] nums)
    {
        var dp = new bool[nums.Length];

        dp[0] = true;

        for (int i = 0; i < dp.Length; i++)
        {
            if (dp[i])
            {
                if (i == dp.Length - 1)
                {
                    return true;
                }

                for (int j = 0; j <= nums[i]; j++)
                {
                    if (i + j < dp.Length)
                    {
                        dp[i + j] = true;
                    }
                }
            }
        }

        return false;
    }

    public static void Run()
    {
        var input = new int[] { 2,3,1,1,4 };
        var input2 = new int[] { 3,2,1,0,4 };

        var url = "http://example.com?key=one";
        var queryParams = new Dictionary<string, string>
        {
            { "cko-session-id", "null" },
        };

        if (string.IsNullOrWhiteSpace(url))
        {
            throw new ArgumentNullException(nameof(url));
        }

        var o = QueryHelpers.AddQueryString(url, queryParams);

        var output = CanJump(input);
    }
}