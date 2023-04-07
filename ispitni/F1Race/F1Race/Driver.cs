using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
    public class Driver : IComparable<Driver>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool FirstPlace { get; set; }
        public char Place { get; set; }
        public List<Lap> Laps { get; set; } = new List<Lap>();

        public Driver(string name, int age, bool firstPlace)
        {
            Name = name;
            Age = age;
            FirstPlace = firstPlace;
            Place = firstPlace ? 'F' : 'S';
        }

        public override string ToString()
        {
            return $"{Name} ({Age}) - {Place}";
        }

        public int CompareTo(Driver other)
        {
            return this.Place.CompareTo(other.Place);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
