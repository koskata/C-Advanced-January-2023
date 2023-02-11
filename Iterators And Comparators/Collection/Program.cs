namespace Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<string> items = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();


            ListyIterator<string> listy = new(items);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (command == "PrintAll")
                {
                    foreach (var item in listy)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                else if (command == "Print")
                {
                    try
                    {
                        listy.Print();
                    }
                    catch (InvalidOperationException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
            }
        }
    }
}