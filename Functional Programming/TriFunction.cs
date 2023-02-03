int length = int.Parse(Console.ReadLine());

string[] people = Console.ReadLine().Split();

Func<string, int, bool> isLarger = (name, sum) =>
{
	int charsSum = name.Sum(ch => ch);

	return charsSum >= sum;
};

Func<string[], int, Func<string, int, bool>, string> getFirstName = (names, sum, match) =>
{
	foreach (var name in names)
	{
		if (match(name, sum))
		{
			return name;
		}
	}
	return null;
};

//Action<string[]> print = people =>
//{
//	foreach (var person in people)
//	{
//		int sum = 0;
//		for (int i = 0; i < person.Length; i++)
//		{
//			char ch = person[i];
//			int value = (int)ch;
//			sum += value;
//		}
//		if (sum >= length)
//		{
//			Console.WriteLine(person);
//			break;
//		}
//	}
//};

Console.WriteLine(getFirstName(people, length, isLarger));
