namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> modelWithSpecs = new(); 

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                
                string model = cmdArgs[0];
                double fuelAmount = double.Parse(cmdArgs[1]);
                double fuelConsumptionPerKilometer = double.Parse(cmdArgs[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer, 0);

                modelWithSpecs.Add(model, car);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();

                string model = cmdArgs[1];
                double amountOfKm = double.Parse(cmdArgs[2]);


                Car car = modelWithSpecs[model];
                car.Drive(amountOfKm);
            }

            foreach (var car in modelWithSpecs)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.TravelledDistance}");
            }
        }
    }
}