using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        private List<Animal> animals;

        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            animals = new List<Animal>();
        }

        public IReadOnlyCollection<Animal> Animals => animals;
        public string Name { get; set; }
        public int Capacity { get; set; }

        public string AddAnimal(Animal animal) 
        {
            if (animal.Species == null || animal.Species == "")
            {
                return "Invalid animal species.";
            }
            if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            if (Animals.Count >= Capacity)
            {
                return "The zoo is full.";
            }

            animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public List<Animal> GetAnimalsByDiet(string diet) 
        {
            List<Animal> list = new List<Animal>();
            foreach (Animal animal in animals)
            {
                if (animal.Diet == diet)
                {
                    list.Add(animal);
                }
            }

            return list;
        }

        public Animal GetAnimalByWeight(double weight) 
        {
            Animal animal = animals.FirstOrDefault(a => a.Weight == weight);

            return animal;
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength) 
        {
            int count = 0;
            foreach (Animal animal in animals)
            {
                if (animal.Length >= minimumLength && animal.Length <= maximumLength)
                {
                    count++;
                }
            }

            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }

        public int RemoveAnimals(string species) => animals.RemoveAll(a => a.Species == species);

    }
}

