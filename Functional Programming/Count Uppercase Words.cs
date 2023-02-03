Predicate<string> filterByCase = f => f[0] == char.ToUpper(f[0]);

string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(x => filterByCase(x)).ToArray();

foreach (var word in input)
{
    Console.WriteLine(word);
}
