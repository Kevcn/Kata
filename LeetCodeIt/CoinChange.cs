namespace LeetCodeIt;

public class CoinChange2
{
    public static int CoinChange(int[] coins, int amount)
    {
        int[] dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);

        // base case
        dp[0] = 0;

        for (var i = 1; i <= dp.Length - 1; i++)
        {
            // find dp[i]
            for (var j = 0; j < coins.Length; j++)
            {
                // skip coins that are bigger than the current target amount
                if (i - coins[j] >= 0)
                {
                    // lets say current coin(j) is 4
                    // i (target is 7)
                    // we are saying we can reach i with current coin (1 + ) and dp[3] (dp[i - j])

                    // The Min finds the minimum amount of coins required for it

                    dp[i] = Math.Min(dp[i], 1 + dp[i - coins[j]]);
                }
            }
        }

        return dp[amount] == amount + 1 ? -1 : dp[amount];

        // *** Number of combinations to reach an amount using coins
        // https://www.youtube.com/watch?v=jaNZ83Q3QGc&t=520s&ab_channel=StephenO%27Neill
        // int[] combinations = new int[amount + 1];
        // combinations[0] = 1;
        //
        // for (int i = 0; i < coins.Length; i++)
        // {
        //     for(int currentAmount = 1; currentAmount < combinations.Length; currentAmount++)
        //     {
        //         if(currentAmount - coins[i] >= 0)
        //         {
        //             combinations[currentAmount] += combinations[currentAmount - coins[i]];
        //         }
        //     }
        // }
        //
        // return combinations[amount];
    }

    public static void Run()
    {
        var input = new int[] { 1, 2, 5 };
        var input2 = new int[] { 1, 3, 4, 5 };
        var input3 = new int[] {186, 419, 83, 408};

        var output = CoinChange(input3, 6249);
    }
}