using System;

namespace Store
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}");
        }
    }

    public class EProduct : Product
    {
        public string Brand { get; set; }
        public int Warranty { get; set; }

        public EProduct(string name, double price, string brand, int warranty)
            : base(name, price)
        {
            Brand = brand;
            Warranty = warranty;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Brand: {Brand}, Warranty: {Warranty} years");
        }
    }

    public class Smartphone : EProduct
    {
        public string OperatingSystem { get; set; }

        public Smartphone(string name, double price, string brand, int warranty, string operatingSystem)
            : base(name, price, brand, warranty)
        {
            OperatingSystem = operatingSystem;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Operating System: {OperatingSystem}");
        }
    }
}