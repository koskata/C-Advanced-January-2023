namespace CustomComparator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> ordered = new List<int>();

            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    ordered.Add(numbers[i]);
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    ordered.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", ordered));
        }
    }
}