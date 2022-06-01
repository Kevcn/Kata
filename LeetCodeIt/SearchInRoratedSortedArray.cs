namespace LeetCodeIt;

public class SearchInRoratedSortedArray
{
    // Three stage process - another twist on binary search - realise we have to have sorted array to work with
    // 1. Find the index of the minimum element in the list, and now we know both sides of that element is sorted
    // 2. Determine which side the target is in.
    // 3. Perform regular binary search on the side that contains the target

    public static int Search(int[] nums, int target)
    {
        if (!nums.Contains(target))
        {
            return -1;
        }

        if (nums.Length == 1 && nums[0] == target)
        {
            return 0;
        }

        var left = 0;
        var right = nums.Length - 1;

        var start = 0;

        while (left < right)
        {
            var middleIndex = left + (right - left) / 2;

            if (middleIndex > 0 && nums[middleIndex] < nums[middleIndex - 1])
            {
                start = middleIndex;
                break;
            }

            if (nums[middleIndex] >= nums[left] && nums[middleIndex] > nums[right])
            {
                left = middleIndex + 1;
            }
            else
            {
                right = middleIndex - 1;
            }

            start = left;
        }


        if (target >= nums[start] && target <= nums[nums.Length - 1])
        {
            left = start;
            right = nums.Length - 1;
        }
        else
        {
            left = 0;
            right = start - 1;
        }


        while (left < right)
        {
            var middleIndex = left + (right - left) / 2;

            if (target == nums[middleIndex])
            {
                return middleIndex;
            }

            if (target < nums[middleIndex])
            {
                right = middleIndex - 1;
            }
            else
            {
                left = middleIndex + 1;
            }
        }

        return left;
    }

    public static void Run()
    {
        var input = new[] { 4,5,6,7,0,1,2 };
        var input2 = new[] { 4,5,6,7,8,1,2,3 };
        var input3 = new[] { 1, 3 };

        var result = Search(input3, 3);
    }
}