namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>(songs);

            while (queue.Any())
            {
                string[] cmdArgs = Console.ReadLine().Split();

                string command = cmdArgs[0];
                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Add")
                {

                    string song = string.Join(" ", cmdArgs.Skip(1));

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                        continue;
                    }


                    queue.Enqueue(song);
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}