using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Opel:Vehicle
    {
        public override string Model { get; set; }
        public override string Manufacturer { get; set; }
        public override int Doors { get; set; }
        public override int Price { get; set; }
        public override int Consumption { get; set ; }       
        public override Fuel Fuel { get; set; }
        public override Types Type { get; set; }
        public string Manufactured { get; set; }

        public Opel(string model, string manufacturer, int doors, int price, int consumption, Types type, Fuel fuel, string manufactured)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Doors = doors;
            this.Price = price;
            this.Consumption = consumption;
            this.Type = type;
            this.Fuel = fuel;
            this.Manufactured = manufactured;
        }

        public override string Description()
        {
            return $"Model:{Model},Fuel:{Fuel} Manufacturer:{Manufacturer}, Doors:{Doors}," +
                $"Manufactured:{Manufactured},Fuel:{Fuel}, Type:{Type} Consumption 100km:{Consumption}, Price:{Price}";
        }
    }
}
