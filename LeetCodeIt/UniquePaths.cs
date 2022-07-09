namespace LeetCodeIt;

public class UniquePaths5
{
    public static int UniquePaths(int m, int n)
    {
        if (m == 1)
        {
            return 1;
        }

        var height = m;

        var dp = new int[n + 1];

        // base case
        Array.Fill(dp, 1);

        for (int i = 2; i <= height; i++)
        {
            for (int j = 2; j < dp.Length; j++)
            {
                dp[j] = dp[j] + dp[j - 1];
            }
        }

        return dp[n];
    }

    public static void Run()
    {
        var output = UniquePaths(3, 7);
        var output2 = UniquePaths(3, 2);
    }
}