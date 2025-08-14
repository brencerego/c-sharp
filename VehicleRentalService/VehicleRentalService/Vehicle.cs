using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalService
{
    internal class Vehicle
    {
        protected string model;
        protected string brand;
        protected double rent;

        public Vehicle(string model, string brand, double rent)
        {
            this.model = model;
            this.brand = brand;
            this.rent = rent;
        }

        public virtual void display()
        {
            Console.WriteLine($"The Model is {model}");
            Console.WriteLine($"The Brand is {brand}");
            Console.WriteLine($"The Rent rate is {rent}");
        }

    }
    class Car : Vehicle
    {
        int seat;
        string fuel;

        public Car(String model, String brand, double rent, int seat, string fuel) : base(model, brand, rent)
        {
            this.seat = seat;
            this.fuel = fuel;
        }

        public override void display()
        {
            Console.WriteLine($"The Model is {model}");
            Console.WriteLine($"The Brand is {brand}");
            Console.WriteLine($"The Rent rate is {rent}");
            Console.WriteLine($"The Number of seats is {seat}");
            Console.WriteLine($"The Fuel type is {fuel}");
        }


    }
}