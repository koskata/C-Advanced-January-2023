using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
            Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        //public override string ToString() 
        //{
        //    string result = $"Name: {Name}{Environment.NewLine}";
        //    result += $"Pokemon Name: {Pokemon.Name}{Environment.NewLine}";
        //    result += $"Pokemon Element: {Pokemon.Element}{Environment.NewLine}";
        //    result += $"Pokemon Health: {Pokemon.Health}";

        //    return result;
        //}
    }
}
