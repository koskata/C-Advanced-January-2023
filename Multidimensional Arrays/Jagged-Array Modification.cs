int rows = int.Parse(Console.ReadLine());

int[][] jagged = new int[rows][];

for (int row = 0; row < rows; row++)
{
    string[] nums = Console.ReadLine().Split();
    jagged[row] = new int[nums.Length];
    for (int col = 0; col < jagged[row].Length; col++)
    {
        jagged[row][col] = int.Parse(nums[col]);
    }
}

string input;
while ((input = Console.ReadLine()) != "END")
{
    string[] cmdArgs = input.Split();

    string command = cmdArgs[0];
    int row = int.Parse(cmdArgs[1]);
    int col = int.Parse(cmdArgs[2]);
    int value = int.Parse(cmdArgs[3]);


    if (row < 0 || col < 0 || row >= jagged.Length || col >= jagged[row].Length)
    {
        Console.WriteLine("Invalid coordinates");

    }
    else if (command == "Add")
    {
        jagged[row][col] += value;
    }
    else if (command == "Subtract")
    {
        jagged[row][col] -= value;
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
