using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsBets
{
    public class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Team(string name, string country)
        {
            Name = name;
            this.Country = country;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}",Name,Country);
        }
    }
}
