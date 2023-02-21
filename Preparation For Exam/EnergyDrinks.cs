namespace _01.EnergyDrinks
{
    public class EnergyDrinks
    {
        static void Main(string[] args)
        {
            Stack<int> miligrams = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Queue<int> drinks = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            int sum = 0;

            while (miligrams.Any() && drinks.Any())
            {
                int currMilligram = miligrams.Pop();
                int currDrink = drinks.Dequeue();





                if (sum + (currDrink * currMilligram) <= 300)
                {
                    sum += currDrink * currMilligram;
                }
                else
                {
                    sum -= 30;
                    drinks.Enqueue(currDrink);
                }

                if (sum < 0)
                {
                    sum = 0;
                }
            }

            if (drinks.Any())
            {
                Console.WriteLine($"Drinks left: {String.Join(", ", drinks)}");
            }
            else
            {
                Console.WriteLine($"At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {sum} mg caffeine.");

        }
    }
}