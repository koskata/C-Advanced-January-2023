int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = nums[col];
    }
}

int primarySum = 0;
int secondarySum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    primarySum += matrix[i, i];
    secondarySum += matrix[i, size - i - 1];
}

Console.WriteLine(Math.Abs(primarySum - secondarySum));
