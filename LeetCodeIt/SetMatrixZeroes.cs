namespace LeetCodeIt;

public class SetMatrixZeroes
{
    // have 2 arrays for keeping track of horizontal and vertical rows that needs to be replaced by 0
    // Loop through each element, if its 0 -> update the arrays
    // Replace matrix according to the arrays

    public static void SetZeroes(int[][] matrix)
    {
        var row = matrix[0].Length;
        var column = matrix.Length;

        var vertical = new int[column];
        var horizontal = new int[row];

        horizontal.AsSpan().Fill(1);
        vertical.AsSpan().Fill(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                var row1 = matrix[j];

                if (matrix[j][i] == 0)
                {
                    horizontal[i] = 0;
                    vertical[j] = 0;
                }
            }
        }

        // go through the maxtrix column by column
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (horizontal[i] == 0 || vertical[j] == 0)
                {
                    matrix[j][i] = 0;
                }
            }
        }
    }

    public static void Run()
    {
        var input = new int[3][];

        input[0] = new [] {1, 0, 1};
        input[1] = new [] {1, 1, 1};
        input[2] = new [] {1, 0, 1};

        var input2 = new int[3][];

        input2[0] = new [] {0, 1, 2, 0};
        input2[1] = new [] {3, 4, 5, 2};
        input2[2] = new [] {1, 3, 1, 5};

        SetZeroes(input2);
    }
}