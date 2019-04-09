using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Salon
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public List<Vehicle> Cars { get; set; } = new List<Vehicle>();

        public Salon(string address, string name, List<Vehicle> cars)
        {
            this.Address = address;
            this.Name = name;
            this.Cars = cars;
        }

        public  void PriceFromTo(int price1, int price2)
        {
            Console.WriteLine($"Cars available from {price1}$ to {price2}$");
            var cars = Cars.Where(x => x.Price >= price1 && x.Price <= price2);
            if (cars.LongCount() > 0)
            {
            foreach (var car in cars)
                {                  
                    Console.WriteLine(car.Description());                   
                }
            }else Console.WriteLine("We dont have car for that price!");
           
            

            
        }

        


        
    }
}
