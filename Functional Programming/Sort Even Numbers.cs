int[] nums = Console.ReadLine()
                .Split(", ")
                .Select(x => int.Parse(x))
                .Where(IsEven)
                .OrderBy(x => x)
                .ToArray();

Console.WriteLine(string.Join(", ", nums));

bool IsEven(int x)
{
    if (x % 2 == 0)
    {
        return true;
    }
    return false;
}
