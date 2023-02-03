int n = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine().Split();

Predicate<string> isValid = name =>
{
	if (name.Length <= n)
	{
		return true;
	}
	return false;
};

foreach (var name in names)
{
	if (isValid(name))
	{
		Console.WriteLine($"{name}");
	}
}
