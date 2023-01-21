HashSet<string> set = new HashSet<string>();

string input;
while ((input = Console.ReadLine()) != "END")
{
    string[] cmdArgs = input.Split(", ");
    string direction = cmdArgs[0];

    string number = cmdArgs[1];
    if (direction == "IN")
    {

        set.Add(number);
    }
    else if (direction == "OUT")
    {
        set.Remove(number);
    }
}

if (set.Count <= 0)
{
    Console.WriteLine("Parking Lot is Empty");
}
else
{
    foreach (var item in set)
    {
        Console.WriteLine(item);
    }
}
