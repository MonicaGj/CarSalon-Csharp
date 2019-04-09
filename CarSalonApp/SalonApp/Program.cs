using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace SalonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> bmwCars = new List<Vehicle>
            {
                new Bmw("BMW 320 E46","BMW", 5, 10000, 7, Types.Car, Fuel.Diesel, true),
                new Bmw("BMW F50", "BMW", 4, 38000, 12, Types.Car, Fuel.Gasoline, false),
                new Bmw("BMW F80 M3","BMW", 4, 50000, 14, Types.Car, Fuel.Gasoline, false),

            };
            Salon SalonBMW = new Salon("bul. Aleksandar Makedonski br.2", "BMW Salon", bmwCars);

            List<Vehicle> opelCars = new List<Vehicle>
            {
                new Opel("Opel Astra J", "Opel", 5, 18000, 5, Types.Car, Fuel.Diesel, "Germany"),
                new Opel("Opel Insignia","Opel", 4, 25000, 8, Types.Car, Fuel.Diesel, "Germany"),
                new Opel("Opel Vivaro","Opel", 3, 20000, 9, Types.Truck, Fuel.Gasoline, "Germany" )
            };
            Salon SalonOpel = new Salon("bul. VMRO br.40", "Opel Salon", opelCars);

            List<Vehicle> audiCars = new List<Vehicle>
            {
                new Audi("Audi Q8", "Audi", 5, 45000, 11, Types.Car, Fuel.Diesel, "Green"),
                new Audi("Audi A7", "Audi", 4, 68000, 9, Types.Car, Fuel.Diesel, "Black"),
                new Audi("Audi RS6", "Audi", 2, 80000, 15, Types.Car, Fuel.Diesel, "White")
            };
            Salon SalonAudi = new Salon("bul. Jane Sandanski br.12", "Audi Salon",audiCars );



            Console.WriteLine("Choose 1.Audi; 2.BMW; 3.Opel Salons");
            string ChosenSalon = Console.ReadLine();
            if(ChosenSalon == "1")
            {
                Console.WriteLine("Price from:");
                int ChosenPrice1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Price to:");
                int ChosenPrice2 = int.Parse(Console.ReadLine());
                SalonAudi.PriceFromTo(ChosenPrice1,ChosenPrice2);
            }
            else if (ChosenSalon == "2")
            {
                Console.WriteLine("Price from:");
                int ChosenPrice1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Price to:");
                int ChosenPrice2 = int.Parse(Console.ReadLine());
                SalonBMW.PriceFromTo(ChosenPrice1, ChosenPrice2);
            }
            else if (ChosenSalon == "3")
            {
                Console.WriteLine("Price from:");
                int ChosenPrice1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Price to:");
                int ChosenPrice2 = int.Parse(Console.ReadLine());
                SalonOpel.PriceFromTo(ChosenPrice1, ChosenPrice2);
            }



        }
    }
}
