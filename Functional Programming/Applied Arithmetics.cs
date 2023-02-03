List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input;
Func<List<int>, string, List<int>> func = (numbers, input) =>
{
    if (input == "add")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] += 1;
        }
        return numbers;
    }
    else if (input == "multiply")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] *= 2;
        }
        return numbers;
    }
    else if (input == "subtract")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i] -= 1;
        }
        return numbers;
    }
    return null;
};


while ((input = Console.ReadLine()) != "end")
{
    if (input == "print")
    {
        Console.WriteLine(String.Join(" ", numbers));
    }
    else
    {
        func(numbers, input);
    }
}
