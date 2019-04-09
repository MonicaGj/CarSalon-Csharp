using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Bmw : Vehicle
    {
        public override string Model { get; set ; }
        public override string Manufacturer { get; set; }
        public override int Doors { get; set ; }
        public override int Price { get; set; }
        public override int Consumption { get ; set; }
        public override Types Type { get; set; }
        public override Fuel Fuel { get ; set ; }
        public bool Roof { get; set; }

        public Bmw(string model, string manufacturer, int doors, int price, int consumption, Types type, Fuel fuel, bool roof)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Doors = doors;
            this.Price = price;
            this.Consumption = consumption;
            this.Type = type;
            this.Fuel = fuel;
            this.Roof = roof;
        }

        public override string Description()
        {
            return $"Model:{Model}, Manufacturer:{Manufacturer},Fuel:{Fuel}, Type:{Type}," +
                $" Doors:{Doors},Roof:{Roof}, Consumption 100km:{Consumption}, Price:{Price}";
        }


    }
}
