using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    public class Automobile
    {
        public Manufacturer manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Consumption { get; set; }
        public decimal Price { get; set; }

        public Automobile(Manufacturer manufacturer, string model, decimal consumption, decimal price)
        {
            this.manufacturer = manufacturer;
            Model = model;
            Consumption = consumption;
            Price = price;
        }

        public override string ToString()
        {
            return $"{manufacturer.Name} {Model} {Math.Round(Consumption, 1)} {Price}";
        }
    }
}
