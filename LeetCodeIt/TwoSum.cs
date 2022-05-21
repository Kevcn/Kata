namespace LeetCodeIt;

public class TwoSum
{
    // Test the knowledge on HashMap
    public int[] TwoSum1(int[] nums, int target)
    {
        var hashMap = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (hashMap.ContainsKey(diff))
            {
                return new[] { i, hashMap[diff] };
            }

            hashMap.TryAdd(nums[i], i);
        }

        return nums;
    }
}