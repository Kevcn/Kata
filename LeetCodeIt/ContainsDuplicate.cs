namespace LeetCodeIt;

public class ContainsDuplicate1
{
    // Tests the understanding of sets - collections that can not have duplicates
    public static bool ContainsDuplicate(int[] nums)
    {
        if (nums.Length == 1)
        {
            return false;
        }

        var hashSet = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!hashSet.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }

    public static void Run()
    {
        var input = new int[] {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
        var result = ContainsDuplicate(input);
    }

}