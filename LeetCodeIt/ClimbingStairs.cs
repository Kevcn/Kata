namespace LeetCodeIt;

public class ClimbingStairs
{
    // Bottom up approach
    // Figure out from the target and backwards
    // Fibonacci sequence
    public static int ClimbStairs(int n)
    {
        var currentStep = 1;
        var PreviousStep = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            var temp = currentStep;

            currentStep = currentStep + PreviousStep;
            PreviousStep = temp;
        }

        return currentStep;
    }

    public static void Run()
    {
        var output = ClimbStairs(7);
    }
}