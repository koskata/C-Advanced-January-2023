using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Renovators
{
    public class Catalog
    {
        private string name;
        private int neededRenovators;
        private string project;
        private List<Renovator> renovators;
        

        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            renovators = new List<Renovator>();
        }

        public string Name { get; private set; }
        public int NeededRenovators { get; private set; }

        public string Project { get; private set; }

        public IReadOnlyCollection<Renovator> Renovators => renovators;

        public int Count { get { return Renovators.Count; } }

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }
            if (Count == NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }

            renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {

            foreach (var renovator in renovators)
            {
                if (renovator.Name == name)
                {
                    renovators.Remove(renovator);
                    return true;
                }
            }

            return false;
        }

        public Renovator HireRenovator(string name)
        {
            var targetRenovator = this.Renovators.FirstOrDefault(x => x.Name == name);
            if (targetRenovator == null)
            {
                return null;
            }
            this.Renovators.FirstOrDefault(x => x.Name == name).Hired = true;
            return targetRenovator;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> list = new List<Renovator>();
            foreach (Renovator renovator in renovators)
            {
                if (renovator.Days >= days)
                {
                    list.Add(renovator);
                }
            }

            return list;
        }

        public int RemoveRenovatorBySpecialty(string type)
            => renovators.RemoveAll(x => x.Type == type);

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {this.Project}:");
            foreach (var item in this.Renovators.Where(x => x.Hired == false).Where(x => x.Paid == false))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
