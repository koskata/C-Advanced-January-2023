namespace ClimbThePeaks
{
    public class ClimbThePeaks
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> difficulty = new Dictionary<string, int>()
            {
                { "Vihren", 80},
                { "Kutelo", 90},
                { "Banski Suhodol", 100},
                { "Polezhan", 60},
                { "Kamenitza", 70},
            };

            Queue<string> peaks = new Queue<string>(new List<string>() { "Vihren", "Kutelo", "Banski Suhodol", "Polezhan", "Kamenitza" });

            List<string> conquered = new List<string>();

            Stack<int> food = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> stamina = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));


            while (food.Any() && stamina.Any() && peaks.Any())
            {
                int currFood = food.Peek();
                int currStamina = stamina.Peek();

                string currPeak = peaks.Peek();
                int diff = difficulty[currPeak];

                if (currFood + currStamina >= diff)
                {
                    food.Pop();
                    stamina.Dequeue();
                    peaks.Dequeue();
                    conquered.Add(currPeak);
                }

                else
                {
                    food.Pop();
                    stamina.Dequeue();
                }
            }

            if (!peaks.Any())
            {
                Console.WriteLine($"Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
            }
            else
            {
                Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
            }

            if (conquered.Any())
            {
                Console.WriteLine("Conquered peaks:");
                foreach (var peak in conquered)
                {
                    Console.WriteLine(peak);
                }
            }
        }
    }
}