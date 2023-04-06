using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Automobile> automobiles { get; set; }

        public Manufacturer(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return $"{Name} ({Code})";
        }
    }
}
