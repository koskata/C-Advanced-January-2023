
List<string> peoples = Console.ReadLine().Split().ToList();

Dictionary<string, Predicate<string>> filters = new();

string input;
while ((input = Console.ReadLine()) != "Print")
{

    string[] cmdArgs = input.Split(";");
    string commandType = cmdArgs[0];
    string action = cmdArgs[1];
    string value = cmdArgs[2];

    if (commandType == "Remove filter")
    {
        filters.Remove(action + value);
    }
    else if (commandType == "Add filter")
    {
        filters.Add(action + value, GetPredicate(action, value));
    }
}

foreach (var filter in filters)
{
    peoples.RemoveAll(filter.Value);
}

Console.WriteLine(string.Join(" ", peoples));

static Predicate<string> GetPredicate(string action, string value)
{
    switch (action)
    {
        case "Starts with":
            return s => s.StartsWith(value);
        case "Ends with":
            return s => s.EndsWith(value);
        case "Length":
            return s => s.Length == int.Parse(value);
        case "Contains":
            return s => s.Contains(value);
        default:
            return default;
    }
}

