string[] names = Console.ReadLine().Split();

Action<string[]> print = names =>
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
};

print(names);
