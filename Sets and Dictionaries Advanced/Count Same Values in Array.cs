double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

Dictionary<double, int> occurances = new Dictionary<double, int>();

for (int i = 0; i < nums.Length; i++)
{
    if (!occurances.ContainsKey(nums[i]))
    {
        occurances.Add(nums[i], 0);
    }

    occurances[nums[i]]++;
}

foreach (var num in occurances)
{
    Console.WriteLine($"{num.Key} - {num.Value} times");
}
