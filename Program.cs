using System.Globalization;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("samsung","Hyundai","Kiwi",2000);
            Motorcycle motocycle = new Motorcycle("kiwi", "Lexus", "Kiwi", 2005);
            Truck truck = new Truck("bak", "Porshe", "Kiwi", 2000);
            Garage garage = new Garage();
            garage.AddNew(car);
            garage.AddNew(motocycle);
            garage.AddNew(truck);
            garage.ShowVehicles();
            car.Start();
            motocycle.Start();
            truck.Start();

        }
        
    }

    abstract class Vehicle
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        abstract public void Start();

        public Vehicle(string company, string model, int year)
        {
            Company = company;
            Model = model;
            Year = year;
        }
    }

    class Car : Vehicle
    {
        public string Condic { get; set; }
        public override void Start()
        {
            Console.WriteLine("Masin ise dusdu"); ;
        }

        public Car(string condic, string company, string model, int year) :base(company,model,year)
        {
            Condic = condic;
        }
    }

    class Motorcycle : Vehicle
    {
        public string Stoyka { get; set; }
        public override void Start()
        {
            Console.WriteLine("Moto xoddandi"); ;
        }
        public Motorcycle(string stoyka, string company, string model, int year) : base(company, model, year)
        {
            Stoyka = stoyka; ;
        }
    }

    class Truck:Vehicle
    {
        public string BigWindow { get; set; }
        public override void Start()
        {
            Console.WriteLine("Kamaz daslari dasidi "); ;
        }
        public Truck(string bigwindow, string company, string model, int year) : base(company, model, year)
        {
            BigWindow=bigwindow; ;
        }

    }
    class Garage
    {
        private Vehicle[] Vehicles = new Vehicle[0];

        public void ShowVehicles ()
        {
            foreach (var item in Vehicles)
            {
                Console.WriteLine($"{item.Company},{item.Year},{item.Model}");
            }
        }
        public void AddNew(Vehicle vehicle)
        {
            Array.Resize(ref Vehicles, Vehicles.Length + 1);
            Vehicles[Vehicles.Length - 1] = vehicle;
        }
    }


}