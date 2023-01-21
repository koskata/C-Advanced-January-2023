List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

nums = nums.OrderByDescending(x => x).Take(3).ToList();

Console.WriteLine(string.Join(" ", nums));
