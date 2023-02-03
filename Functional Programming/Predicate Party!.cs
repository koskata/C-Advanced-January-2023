
List<string> peoples = Console.ReadLine().Split().ToList();


string input;
while ((input = Console.ReadLine()) != "Party!")
{

    string[] cmdArgs = input.Split();
    string commandType = cmdArgs[0];
    string action = cmdArgs[1];
    string value = cmdArgs[2];

    if (commandType == "Remove")
    {
        peoples.RemoveAll(GetPredicate(action, value));
    }
    else
    {
        List<string> peopleToDouble = peoples.FindAll(GetPredicate(action, value));

        foreach (var person in peopleToDouble)
        {
            peoples.Insert(0, person);
        }
    }
}

if (peoples.Count > 0)
{
    Console.WriteLine($"{String.Join(", ", peoples)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

static Predicate<string> GetPredicate(string action, string value)
{
    switch (action)
    {
        case "StartsWith":
            return s => s.StartsWith(value);
        case "EndsWith":
            return s => s.EndsWith(value);
        case "Length":
            return s => s.Length == int.Parse(value);
        default:
            return default;
    }
}