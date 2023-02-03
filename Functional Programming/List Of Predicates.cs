int endOfRange = int.Parse(Console.ReadLine());

List<Predicate<int>> predicates = new List<Predicate<int>>();

int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] numbers = Enumerable.Range(1, endOfRange).ToArray();

foreach (var divider in dividers)
{
    predicates.Add(n => n % divider == 0);
}

foreach (var number in numbers)
{
    bool isEnd = false;
    foreach (var match in predicates)
    {
        if (!match(number))
        {
            isEnd = true;
        }
    }
    if (!isEnd)
    {
        Console.Write(number + " ");
    }
}
