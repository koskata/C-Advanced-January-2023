int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> world =
    new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < n; i++)
{
    string[] cmdArgs = Console.ReadLine().Split();

    string continent = cmdArgs[0];
    string country = cmdArgs[1];
    string city = cmdArgs[2];

    if (!world.ContainsKey(continent))
    {
        world.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!world[continent].ContainsKey(country))
    {
        world[continent].Add(country, new List<string>());
    }

    world[continent][country].Add(city);
}

foreach (var continent in world)
{
    Console.WriteLine($"{continent.Key}: ");
    foreach (var countryWithCity in continent.Value)
    {
        Console.WriteLine($"  {countryWithCity.Key} -> {string.Join(", ", countryWithCity.Value)}");
    }
}