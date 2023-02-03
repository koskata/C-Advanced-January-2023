HashSet<int> set = Console.ReadLine().Split().Select(x => int.Parse(x)).ToHashSet();

Func<HashSet<int>, int> minNum = set =>
{
    int min = int.MaxValue;
    foreach (var num in set)
    {
        if (num < min)
        {
            min = num;
        }
    }

    return min;
};

Console.WriteLine(minNum(set));
