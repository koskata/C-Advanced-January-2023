namespace DefiningClasses;

public class StartUp 
{
    static void Main(string[] args)
    {
        //Family family = new();

        int count = int.Parse(Console.ReadLine());

        List<Person> list = new List<Person>();

        for (int i = 0; i < count; i++)
        {
            string[] personProperties = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            
            Person person = new(personProperties[0], int.Parse(personProperties[1]));

            if (int.Parse(personProperties[1]) > 30)
            {
                list.Add(person);
            }
            

            //family.AddMember(person);
        }

        var ordered = list.OrderBy(x => x.Name);

        foreach (var person in ordered)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }

        //Person oldest = family.GetOldestMember();

        //Console.WriteLine($"{oldest.Name} {oldest.Age}");
    }
}
