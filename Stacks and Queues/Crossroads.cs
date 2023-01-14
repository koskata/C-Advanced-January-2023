using System;

namespace _10._Crossroads
{
    internal class Crossroads
    {
        static void Main(string[] args)
        {
            int secondsForGreenLight = int.Parse(Console.ReadLine());
            int durationOfFreeWindow = int.Parse(Console.ReadLine());


            Queue<string> cars = new Queue<string>();

            int carsPassed = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input != "green")
                {
                    cars.Enqueue(input);
                    continue;
                }

                int currSeconds = secondsForGreenLight;

                while (currSeconds > 0 && cars.Any())
                {
                    string currCar = cars.Dequeue();

                    if (currSeconds - currCar.Length >= 0)
                    {
                        currSeconds -= currCar.Length;
                        carsPassed++;
                        continue;
                    }

                    if (currSeconds + durationOfFreeWindow - currCar.Length >= 0)
                    {
                        //for (int i = 0; i < currCar.Length; i++)
                        //{
                        //    if (currSeconds != 0)
                        //    {
                        //        currSeconds--;
                        //        continue;
                        //    }

                        //    durationOfFreeWindow--;
                        //}
                        carsPassed++;
                        continue;

                    }

                    int hittedCar = currSeconds + durationOfFreeWindow;

                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{currCar} was hit at {currCar[hittedCar]}.");

                    return;
                }
            }


                Console.WriteLine("Everything is safe.");
                Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
        }
    }
}