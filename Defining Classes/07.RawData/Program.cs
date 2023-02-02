namespace _07.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> modelWithSpecs = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = cmdArgs[0];
                int speed = int.Parse(cmdArgs[1]);
                int power = int.Parse(cmdArgs[2]);
                int weight = int.Parse(cmdArgs[3]);
                string type = cmdArgs[4];
                double tire1Pressure = double.Parse(cmdArgs[5]);
                int tire1Age = int.Parse(cmdArgs[6]);
                double tire2Pressure = double.Parse(cmdArgs[7]);
                int tire2Age = int.Parse(cmdArgs[8]);
                double tire3Pressure = double.Parse(cmdArgs[9]);
                int tire3Age = int.Parse(cmdArgs[10]);
                double tire4Pressure = double.Parse(cmdArgs[11]);
                int tire4Age = int.Parse(cmdArgs[12]);

                Car car = new Car(model, speed, power, weight, type, tire1Pressure, tire1Age, tire2Pressure, tire2Age,
                    tire3Pressure, tire3Age, tire4Pressure, tire4Age);

                modelWithSpecs.Add(car);
            }

            string command = Console.ReadLine();

            string[] ordered;
            if (command == "fragile")
            {
                ordered = modelWithSpecs.Where(m => m.Cargo.Type == "fragile" && m.Tires.Any(t => t.Pressure < 1))
                    .Select(m => m.Model)
                    .ToArray();
            }
            else
            {
                ordered = modelWithSpecs.Where(m => m.Cargo.Type == "flammable" && m.Engine.Power > 250)
                    .Select(m => m.Model)
                    .ToArray();
            }

            Console.WriteLine(String.Join(Environment.NewLine, ordered));
        }
    }
}