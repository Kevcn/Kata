namespace LeetCodeIt;

public class WordBreak2
{
    public static bool WordBreak(string s, IList<string> wordDict)
    {
        var dp = new bool[s.Length + 100];

        // base case
        dp[s.Length - 1] = true;

        for (int i = s.Length - 1; i >= 0; i--)
        {

            for (int j = 0; j < wordDict.Count; j++)
            {

                var test = s.Substring(0, s.Length - i);

                if (s.Substring(0, i).Contains(wordDict[j]))
                {
                    dp[i] = dp[i + wordDict[j].Length];
                }

                if (dp[i])
                {
                    break;
                }

            }

            return dp[0];
        }

        return false;
    }

    public static void Run()
    {
        var word = "leetcode";
        var wordDict = new List<string> { "leet","code" };

        var result = WordBreak(word, wordDict);
    }
}