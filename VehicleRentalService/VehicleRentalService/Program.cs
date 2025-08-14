namespace VehicleRentalService;
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("Accord", "Honda", 300);
            v.display();
            Vehicle c = new Car("ZRV", "Honda", 699, 5, "Petrol");
            c.display();
        }
    }