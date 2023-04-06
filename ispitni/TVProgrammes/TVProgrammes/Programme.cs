using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVProgrammes
{
    public class Programme
    {
        public string Name { get; set; }
        public decimal Time { get; set; }

        public Programme(string name, decimal time)
        {
            Name = name;
            Time = time;
        }

        public override string ToString()
        {
            return $"{Name} {Time}mins";
        }
    }
}
