using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Audi:Vehicle
    {
        public override string Model { get; set; }
        public override string Manufacturer { get; set; }
        public override int Doors { get; set; }
        public override int Price { get; set; }
        public override int Consumption { get; set; }      
        public override Fuel Fuel { get; set ; }
        public override Types Type { get; set; }
        public string Color { get; set; }

        public Audi(string model, string manufacturer, int doors, int price, int consumption, Types type, Fuel fuel, string color)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Doors = doors;
            this.Price = price;
            this.Consumption = consumption;
            this.Type = type;
            this.Fuel = fuel;
            this.Color = color;
        }

        public override string Description()
        {
            return $"Model:{Model}, Manufacturer:{Manufacturer}, Doors:{Doors}," +
                $"Color:{Color},Fuel:{Fuel}, Type:{Type}, Consumption 100km:{Consumption}, Price:{Price}";
        }
    }
}
