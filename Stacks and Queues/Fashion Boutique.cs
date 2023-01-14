namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rackSize = int.Parse(Console.ReadLine());

            int racks = 1;

            int sum = rackSize;

            Stack<int> stack = new Stack<int>(clothes);

            while (stack.Any())
            {

                sum -= stack.Peek();
                if (sum < 0)
                {
                    sum = rackSize;
                    racks++;

                    continue;
                }
                stack.Pop();


            }

            Console.WriteLine(racks);
        }
    }
}