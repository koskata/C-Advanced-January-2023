Func<int[], List<int>> adding = range =>
{
    List<int> list = new List<int>();
    for (int i = range[0]; i <= range[1]; i++)
    {
        list.Add(i);
    }

    return list;
};


int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

List<int> numbers = new List<int>(adding(range));

string command = Console.ReadLine();

Predicate<int> match;

if (command == "even")
{
    match = n => n % 2 == 0;
}
else
{
    match = n => n % 2 != 0;
}

foreach (var num in numbers)
{
    if (match(num))
    {
        Console.Write(num + " ");
    }
}
