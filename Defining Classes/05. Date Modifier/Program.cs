namespace DateModifier;

public class StartUp
{
    static void Main(string[] args)
    {
        //DateTime time = new DateTime();

        DateModifier date = new DateModifier();

        string start = Console.ReadLine();
        string end = Console.ReadLine();

        TimeSpan diff = date.difference(start, end);

        Console.WriteLine(Math.Abs(diff.Days));
    }
}
