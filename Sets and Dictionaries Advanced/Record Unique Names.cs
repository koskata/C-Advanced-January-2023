int n = int.Parse(Console.ReadLine());

HashSet<string> set = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string names = Console.ReadLine();
    set.Add(names);
}

foreach (var item in set)
{
    Console.WriteLine($"{item}");
}
