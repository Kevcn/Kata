namespace LeetCodeIt;

public class CombinationSumIV
{
    // Loop through combinations from 1
    // for each coin if smaller than current node, node += node - coin
    public static int CombinationSum4(int[] nums, int target)
    {
        int[] combinations = new int[target + 1];
        combinations[0] = 1;

        for (int i = 0; i < combinations.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                // Only look at the numbers that is smaller or equals to current node
                if (i >= nums[j])
                {
                    combinations[i] += combinations[i - nums[j]];
                }
            }
        }

        return combinations[target];
    }

    public static void Run()
    {
        var input = new int[] { 1, 2, 5 };
        var input2 = new int[] { 1, 2, 3 };
        var input3 = new int[] {186, 419, 83, 408};

        var output = CombinationSum4(input2, 3);
    }
}