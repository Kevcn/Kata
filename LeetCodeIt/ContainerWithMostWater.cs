namespace LeetCodeIt;

public class ContainerWithMostWater
{
    // pointer left and right
    // move the lower pointer inwards
    // if equal, compare the next value and take the higher one and move

    public static int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;

        var maxArea = 0;

        while (left < right)
        {
            var currentArea = Math.Min(height[left], height[right]) * (right - left);

            if (currentArea > maxArea)
            {
                maxArea = currentArea;
            }

            if (height[left] == height[right])
            {
                if (height[left + 1] > height[right - 1])
                {
                    left = left + 1;
                }
                else
                {
                    right = right - 1;
                }
            }
            else if (height[left] > height[right])
            {
                right = right - 1;
            }
            else
            {
                left = left + 1;
            }
        }

        return maxArea;
    }


    public static void Run()
    {
        var input = new int[] {1, 8, 6, 2, 5, 4, 8, 3, 7};

        var output = MaxArea(input);
    }
}