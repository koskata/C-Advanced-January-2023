int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int divider = int.Parse(Console.ReadLine());

Func<int[], int, List<int>> isDivide = (numbers, divider) =>
{
    List<int> list = new List<int>();
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % divider != 0)
        {
            list.Add(numbers[i]);
        }
    }
    return list;
};

List<int> list = new List<int>(isDivide(numbers, divider));

list.Reverse();

Console.WriteLine(String.Join(" ", list));
