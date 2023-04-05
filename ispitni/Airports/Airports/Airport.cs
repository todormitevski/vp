using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    public class Airport
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Destination> Destinations { get; set; } = new List<Destination>();

        public Airport(string code, string name, string city)
        {
            Code = code;
            Name = name;
            City = city;
        }

        public override string ToString()
        {
            return $"{Code} - {Name} - {City}";
        }
    }
}
