﻿namespace ComputerArchitecture
{
    public class CPU
    {
        private string brand;
        private int cores;
        private double frequency;

        public CPU(string brand, int cores, double frequency)
        {
            Brand = brand;
            Cores = cores;
            Frequency = frequency;
        }

        public string Brand { get; set; }
        public int Cores { get; set; }
        public double Frequency { get; set; }

        public override string ToString()
        {
            return $"{Brand} CPU:{Environment.NewLine}" +
                $"Cores: {Cores}{Environment.NewLine}" +
                $"Frequency: {Frequency:f1} GHz";
        }
    }
}

