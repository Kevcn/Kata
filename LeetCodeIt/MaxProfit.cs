namespace LeetCodeIt;

public class MaxProfit2
{
    // Always keep the smallest in a variable and only ever compares forward
    // Keep the max profit in variable
    public static int MaxProfit(int[] prices)
    {
        int min = Int16.MaxValue;
        int maxProfit = 0;
        for(int i = 0; i < prices.Length; i++)
        {
            min = Math.Min(min, prices[i]);
            maxProfit = Math.Max(maxProfit, /* Calculates the profit from current pointer against min value -> */ prices[i]-min);
        }

        return maxProfit;
    }

    public static void Run()
    {
        var t = MaxProfit(new[] {7, 5, 3, 6, 4, 1});
    }
}