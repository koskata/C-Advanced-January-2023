using System;

namespace Basketball
{
    public class Player
    {
        public Player(string name, string position, double rating, int games)
        {
            Name = name;
            Position = position;
            Rating = rating;
            Games = games;
        }

        public string Name { get; private set; }
        public string Position { get; private set; }
        public double Rating { get; private set; }
        public int Games { get; private set; }
        public bool Retired { get; set; } = false;


        public override string ToString()
        {
            return $"-Player: {Name}{Environment.NewLine}" +
                $"--Position: {Position}{Environment.NewLine}" +
                $"--Rating: {Rating}{Environment.NewLine}" +
                $"--Games played: {Games}";
        }
    }
}

