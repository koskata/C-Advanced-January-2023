int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = sizes[0];
int cols = sizes[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = nums[col];
    }
}

int maxSum = 0;
int maxRow = 0;
int maxCol = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int sum = 0;
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (row >= matrix.GetLength(0) - 1 || col >= matrix.GetLength(1) - 1)
        {
            break;
        }
        sum = 0;
        sum += matrix[row, col];
        sum += matrix[row + 1, col];
        sum += matrix[row, col + 1];
        sum += matrix[row + 1, col + 1];

        if (sum > maxSum)
        {
            maxSum = sum;
            maxRow = row;
            maxCol = col;
        }
    }
}

Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");


Console.WriteLine(maxSum);
