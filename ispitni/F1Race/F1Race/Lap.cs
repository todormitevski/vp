using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
    public class Lap
    {
        public int Minute { get; set; } = 0;
        public int Second { get; set; } = 0;

        public Lap(int minute, int second)
        {
            Minute = minute;
            Second = second;
        }

        public override string ToString()
        {
            return $"{Minute}:{Second}";
        }
    }
}
