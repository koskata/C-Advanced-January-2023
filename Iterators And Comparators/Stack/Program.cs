namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);


                if (cmdArgs[0] == "Push")
                {
                    int[] cmdArgs2 = cmdArgs.Skip(1).Select(int.Parse).ToArray();
                    foreach (var item in cmdArgs2)
                    {
                        stack.Push(item);
                    }
                }
                else
                {
                    if (stack.Count <= 0)
                    {
                        Console.WriteLine("No elements");
                    }
                    else
                    {
                        stack.Pop();
                    }


                }

                
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}