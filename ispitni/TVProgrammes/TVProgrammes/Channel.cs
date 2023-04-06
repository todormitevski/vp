using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVProgrammes
{
    public class Channel
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public List<Programme> programmes { get; set; } = new List<Programme>();

        public Channel(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Number}. {Name}";
        }
    }
}
