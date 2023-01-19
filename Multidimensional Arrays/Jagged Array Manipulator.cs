int n = int.Parse(Console.ReadLine());

int[][] jagged = new int[n][];

for (int row = 0; row < n; row++)
{
    int[] cols = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    jagged[row] = cols;



}

for (int row = 0; row < n - 1; row++)
{
    if (jagged[row].Length == jagged[row + 1].Length)
    {
        for (int col = 0; col < jagged[row].Length; col++)
        {
            jagged[row][col] *= 2;
            jagged[row + 1][col] *= 2; 
        }
    }
    else
    {
        for (int col = 0; col < jagged[row].Length; col++)
        {
            jagged[row][col] /= 2;
        }
        for (int col = 0; col < jagged[row + 1].Length; col++)
        {
            jagged[row + 1][col] /= 2;
        }
    }
}

string command;
while ((command = Console.ReadLine()) != "End")
{
    string[] cmdArgs = command.Split();

    string cmdType = cmdArgs[0];
    int row = int.Parse(cmdArgs[1]);
    int col = int.Parse(cmdArgs[2]);
    int value = int.Parse(cmdArgs[3]);

    if (cmdType == "Add")
    {
        if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
        {
            jagged[row][col] += value;
        }
    }
    else if (cmdType == "Subtract")
    {
        if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
        {
            jagged[row][col] -= value;
        }
    }
}

for (int row = 0; row < jagged.Length; row++)
{
    for (int col = 0; col < jagged[row].Length; col++)
    {
        Console.Write(jagged[row][col] + " ");
    }
    Console.WriteLine();
}

