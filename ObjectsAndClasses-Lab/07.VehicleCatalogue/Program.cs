using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            while (true)
            {

                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] tokens = command.Split('/');
                switch (tokens[0])
                {
                    case "Car":
                        Car car = new Car { Brand = tokens[1], Model = tokens[2], HorsePower = int.Parse(tokens[3]) };
                        catalogue.Cars.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck { Brand = tokens[1], Model = tokens[2], Weight = int.Parse(tokens[3]) };
                        catalogue.Truck.Add(truck);
                        break;
                    default:
                        break;
                }
            }
            if (catalogue.Cars.Count > 0)
            {
                List<Car> orderedCars = catalogue.Cars.OrderBy(c => c.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

            }
            if (catalogue.Truck.Count > 0)
            {
                List<Truck> orderedTrucks = catalogue.Truck.OrderBy(c => c.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Truck = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Truck { get; set; }
    }
}
