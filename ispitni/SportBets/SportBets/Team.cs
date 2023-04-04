using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportBets
{
    public class Team
    {
        public String Name { get; set; }
        public String Country { get; set; }

        public Team(String Name, string Country)
        {
            this.Name = Name;
            this.Country = Country;
        }

        public override string ToString()
        {
            return $"{Name} ({Country})";
        }
    }
}
