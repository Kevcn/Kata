namespace LeetCodeIt;

public class LongestCommonSubsequence2
{
    // 2D grid bottom up solution
    // understand how to traverse the grid is the key
    public static int LongestCommonSubsequence(string text1, string text2)
    {
        var grid2D = new int[text1.Length + 1, text2.Length + 1];

        for (int i = text1.Length - 1; i >= 0; i--)
        {
            for (int j = text2.Length - 1; j >= 0; j--)
            {
                if (text1[i] == text2[j])
                {
                    grid2D[i, j] = 1 + grid2D[i + 1, j + 1];
                }
                else
                {
                    grid2D[i, j] = Math.Max(grid2D[i, j + 1], grid2D[i + 1, j]);
                }
            }
        }

        return grid2D[0, 0];
    }


    public static void Run()
    {
        var output = LongestCommonSubsequence("abcde", "acey");
    }
}