namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cdmArgs = command.Split();

                string name = cdmArgs[0];
                int age = int.Parse(cdmArgs[1]);
                string town = cdmArgs[0];

                Person person = new()
                {
                    Name = name,
                    Age = age,
                    Town = town
                };

                people.Add(person);
            }

            int n = int.Parse(Console.ReadLine()) - 1;

            Person personToCompare = people[n];

            int equal = 0;
            int diff = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equal++;
                }
                else
                {
                    diff++;
                }
            }

            if (equal == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {diff} {people.Count}");
            }
        }
    }
}