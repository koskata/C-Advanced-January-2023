
int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = sizes[0];
int cols = sizes[1];

char[,] matrix = new char[rows, cols];

string input = Console.ReadLine();


int currPosition = 0;
for (int row = 0; row < rows; row++)
{
	if (row % 2 == 0)
	{
        for (int col = 0; col < cols; col++)
        {
            if (currPosition == input.Length)
            {
                currPosition = 0;
            }

            matrix[row, col] = input[currPosition];
            currPosition++;
        }
    }
    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            if (currPosition == input.Length)
            {
                currPosition = 0;
            }

            matrix[row, col] = input[currPosition];
            currPosition++;
        }
    }
	
}



for (int row = 0; row < rows; row++)
{
	for (int col = 0; col < cols; col++)
	{
        Console.Write(matrix[row, col]);
    }
	Console.WriteLine();
}


