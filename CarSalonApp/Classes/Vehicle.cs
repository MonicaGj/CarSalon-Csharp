using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
     public abstract class Vehicle
    {
        public abstract string Model { get; set; }
        public abstract string Manufacturer { get; set; }
        public abstract int Doors { get; set; }
        public abstract int Price { get; set; }
        public abstract int Consumption { get; set; }
        public abstract Fuel Fuel { get; set; }
        public abstract Types Type { get; set; }
        

        public abstract string Description();

    }
}
