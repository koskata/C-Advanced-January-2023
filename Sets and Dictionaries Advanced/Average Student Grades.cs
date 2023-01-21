int n = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> namesWithGrades =
    new Dictionary<string, List<decimal>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();

    string name = input[0];
    decimal grade = decimal.Parse(input[1]);

    if (!namesWithGrades.ContainsKey(name))
    {
        namesWithGrades.Add(name, new List<decimal>());
    }

    namesWithGrades[name].Add(grade);
}

foreach (var name in namesWithGrades)
{
    Console.Write($"{name.Key} -> ");
    foreach (var grade in name.Value)
    {
        Console.Write($"{grade:f2} ");

    }
    Console.WriteLine($"(avg: {name.Value.Average():f2})");
}
