using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        private string model;
        private int capacity;
        private List<CPU> multiprocessor;

        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public int Count
        {
            get
            {
                return Multiprocessor.Count;
            }

        }

        public string Model { get; set; }
        public int Capacity { get; set; }

        public List<CPU> Multiprocessor { get; set; }


        public void Add(CPU cpu)
        {
            if (Multiprocessor.Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            } 
        }

        public bool Remove(string brand)
        {
            CPU cpuToRemove = Multiprocessor.FirstOrDefault(x => x.Brand == brand);
            if (cpuToRemove != null)
            {
                return Multiprocessor.Remove(cpuToRemove);
            }

            return false;
        }

        public CPU MostPowerful()
        {
            if (Multiprocessor.Count == 0)
            {
                return null;
            }

            CPU mostPowerful = Multiprocessor[0];

            foreach (var item in Multiprocessor)
            {
                if (item.Frequency > mostPowerful.Frequency)
                {
                    mostPowerful = item;
                }
            }

            return mostPowerful;
        }

        public CPU GetCPU(string brand) 
        {
            return Multiprocessor.FirstOrDefault(x => x.Brand == brand);
        }

        public string Report() 
        {
            StringBuilder sb = new();

            sb.AppendLine($"CPUs in the Computer {Model}:");
            foreach (var pc in Multiprocessor)
            {
                sb.AppendLine(pc.ToString());
            }

            return sb.ToString().Trim();
        }

    }
}

