namespace LeetCodeIt ;

public class MinimumInRotatedSortedArray
{
    // A twist on Binary tree search, the trick is to realise we are trying to find
    // the only one that is out of order, so compare the current element to the one on the left to identify the target

    public static int FindMin(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            // Twist - check for if current element is unsorted,
            if (mid > 0 && nums[mid] < nums[mid - 1])
            {
                return nums[mid];
            }

            // the numbers on the left is sorted, and the numbers on the right is not sorted ***
            // Means that the minimum is on the right!
            if (nums[left] <= nums[mid] && nums[mid] > nums[right])
            {
                // To the right side
                left = mid + 1;
            }
            else
            {
                // Go to the left side
                right = mid - 1;
            }
        }

        return nums[left];
    }

    public static void Run()
    {
        var input = new[] { 4,5,6,7,0,1,2 };
        var input2 = new[] { 11,13,15,17 };
        var input3 = new[] { 2, 1 };

        var result = FindMin(input3);
    }
}