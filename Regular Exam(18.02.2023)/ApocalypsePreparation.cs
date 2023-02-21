using System.Text;

namespace ApocalypsePreparation
{
    public class ApocalypsePreparation
    {
        static void Main(string[] args)
        {
            //20 30 20 15 60
            //40 15 20

            Dictionary<string, int> resources = new Dictionary<string, int>()
            {
                { "Patch", 30},
                { "Bandage", 40},
                { "MedKit", 100},
            };

            Dictionary<string, int> counts = new Dictionary<string, int>()
            {
                { "Patch", 0},
                { "Bandage", 0},
                { "MedKit", 0},
            };

            int[] input1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> textiles = new Queue<int>(input1);
            Stack<int> medicaments = new Stack<int>(input2);



            int leftover = 0;
            while (textiles.Any() && medicaments.Any())
            {
                int currTextile = textiles.Dequeue();
                int currMedicament = medicaments.Pop();

                if (leftover > 0)
                {
                    currMedicament += leftover;
                    leftover = 0;
                }


                bool isFound = false;
                bool isLeft = false;
                foreach (var item in resources)
                {
                    if (currTextile + currMedicament > 100)
                    {
                        counts["MedKit"]++;
                        leftover = (currTextile + currMedicament) - 100;
                        
                        isLeft = true;
                        break;
                    }

                    if (currTextile + currMedicament == item.Value)
                    {
                        counts[item.Key]++;
                        isFound = true;
                        break;
                    }

                }

                if (!isFound && !isLeft)
                {
                    currMedicament += 10;
                    medicaments.Push(currMedicament);
                }
            }

            if (leftover > 0)
            {
                int currMed = medicaments.Pop();
                currMed += leftover;
                medicaments.Push(currMed);
            }

            StringBuilder sb = new StringBuilder();

            if (!textiles.Any() && !medicaments.Any())
            {
                sb.AppendLine("Textiles and medicaments are both empty.");
            }
            else if (!textiles.Any())
            {
                sb.AppendLine("Textiles are empty.");

            }
            else if (!medicaments.Any())
            {
                sb.AppendLine("Medicaments are empty.");
            }


            foreach (var item in counts.OrderByDescending(c => c.Value).ThenBy(c => c.Key))
            {
                if (item.Value > 0)
                {
                    sb.AppendLine($"{item.Key} - {item.Value}");

                }
            }

            if (medicaments.Any())
            {
                sb.AppendLine($"Medicaments left: {string.Join(", ", medicaments)}");
            }
            if (textiles.Any())
            {
                sb.AppendLine($"Textiles left: {string.Join(", ", textiles)}");
            }

            sb.ToString().TrimEnd();
            Console.WriteLine(sb);
        }
    }
}