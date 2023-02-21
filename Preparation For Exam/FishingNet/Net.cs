using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private List<Fish> fish;

        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            fish = new List<Fish>();
        }

        public IReadOnlyCollection<Fish> Fish => fish;
        public string Material { get; private set; }
        public int Capacity { get; set; }

        public int Count => fish.Count;

        public string AddFish(Fish fishh) 
        {
            if (string.IsNullOrWhiteSpace(fishh.FishType))
            {
                return "Invalid fish.";
            }
            if (fishh.Length <= 0 || fishh.Weight <= 0)
            {
                return "Invalid fish.";
            }
            if (Count >= Capacity)
            {
                return "Fishing net is full.";
            }

            fish.Add(fishh);
            return $"Successfully added {fishh.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight) 
        {
            Fish targetFish = fish.FirstOrDefault(f => f.Weight == weight);
            if (targetFish != null) 
            {
                fish.Remove(targetFish);
                return true;
            }

            return false;
        }

        public Fish GetFish(string fishType) 
        {
            Fish targetFish = fish.FirstOrDefault(f => f.FishType == fishType);
            if (targetFish != null)
            {
                return targetFish;
            }

            return null;
        }

        public Fish GetBiggestFish() 
        {
            Fish longest = null;

            double maxLength = double.MinValue;

            foreach (Fish fi in fish)
            {
                if (fi.Length > maxLength)
                {
                    maxLength = fi.Length;
                    longest = fi;
                }
            }

            return longest;
        }

        public string Report() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");
            foreach (Fish fi in fish.OrderByDescending(f => f.Length)) 
            {
                sb.AppendLine(fi.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
