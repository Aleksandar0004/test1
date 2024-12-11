namespace vehicle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(100, "Toyota");
            Bike bike = new Bike(10, "Mountain Bike");
            Vehicle vehicle = new Vehicle(55);
            Console.WriteLine(car.Brand);
            Console.WriteLine(car.KmVChas);
            Console.WriteLine(bike.Type);
            Console.WriteLine(bike.KmVChas);
            Console.WriteLine(vehicle.KmVChas);

         }
        public class Vehicle
        {
            public double KmVChas { get; set; }

            public Vehicle(double kmVchas)
            {
                this.KmVChas = kmVchas;
            }

        }
        public class Car : Vehicle
        {
            public string Brand { get; set; }

            public Car(double kilometra, string brand) : base(kilometra)
            {
                this.Brand = brand;
            }
        }
        public class Bike : Vehicle
        {
            public string Type { get; set; }

            public Bike(double kilometra, string type) : base(kilometra)
            {
                this.Type = type;
            }
        }
        }
}
