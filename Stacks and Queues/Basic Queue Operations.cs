namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(nums);

            int numsToEnqueue = tokens[0];
            int dequeueElements = tokens[1];
            int secretNum = tokens[2];




            //for (int i = 0; i < numsToPush; i++)
            //{
            //    stack.Push(nums[i]);
            //}

            for (int i = 0; i < dequeueElements; i++)
            {
                queue.Dequeue();
            }

            if (!queue.Any())
            {
                Console.WriteLine(0);
            }

            else if (queue.Contains(secretNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}