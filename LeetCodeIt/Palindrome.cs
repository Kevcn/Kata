namespace LeetCodeIt;

public class Palindrome
{
    // 2 pointers one from left and the other from right
    private static bool IsPalindrome(int x)
    {
        var s = Convert.ToString(x);

        var l = 0;
        var r = s.Length - 1;

        while (l < r)
        {
            if (s[l] != s[r])
            {
                return false;
            }

            l++;
            r--;
        }

        return true;
    }

    public static void Run()
    {
        var result = IsPalindrome(0);
    }
}