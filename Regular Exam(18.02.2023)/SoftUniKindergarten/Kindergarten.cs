using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        //private List<Child> registry;
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }

        public int ChildrenCount => Registry.Count;

        public bool AddChild(Child child) 
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }

            return false;
        }

        public bool RemoveChild(string childFullName) 
        {
            foreach (Child child in Registry)
            {
                string fullName = child.FirstName + " " + child.LastName;
                if (fullName == childFullName)
                {
                    Registry.Remove(child);
                    return true;
                }
            }

            return false;
        }

        public Child GetChild(string childFullName) 
        {
            foreach (Child child in Registry)
            {
                string fullName = child.FirstName + " " + child.LastName;
                if (fullName == childFullName) 
                {
                    return child;
                }
            }

            return null;
        }

        public string RegistryReport() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {this.Name}:");
            foreach (Child child in Registry.OrderByDescending(r => r.Age).ThenBy(r => r.LastName).ThenBy(r => r.FirstName))
            {
                sb.AppendLine(child.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
