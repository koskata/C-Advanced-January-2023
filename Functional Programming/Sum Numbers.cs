int[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(Filter)
                .ToArray();

Console.WriteLine(numbers.Length);
Console.WriteLine(Sum(numbers));

int Filter(string x)
{
    return int.Parse(x);
}

int Sum(int[] nums)
{
    return nums.Sum();
}
