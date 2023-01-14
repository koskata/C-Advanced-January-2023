namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(nums);

            int numsToPush = tokens[0];
            int popElements = tokens[1];
            int secretNum = tokens[2];




            //for (int i = 0; i < numsToPush; i++)
            //{
            //    stack.Push(nums[i]);
            //}

            for (int i = 0; i < popElements; i++)
            {
                stack.Pop();
            }

            if (!stack.Any())
            {
                Console.WriteLine(0);
            }

            else if (stack.Contains(secretNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}