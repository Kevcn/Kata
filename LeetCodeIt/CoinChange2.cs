namespace LeetCodeIt;

public class CoinChange2
{
    public static int Change(int amount, int[] coins)
    {
        // base case
        var dp = new int[amount + 1];
        dp[0] = 1;

        for (int i = 0; i < coins.Length; i++)
        {
            for (int j = 1; j < dp.Length; j++)
            {
                if (j >= coins[i])
                {
                    dp[j] = dp[j] + dp[j - coins[i]];
                }
            }
        }

        return dp[amount];
    }

    public static void Run()
    {
        var input = new int[] { 1, 2, 5 };

        var output = Change(5, input);
    }

}