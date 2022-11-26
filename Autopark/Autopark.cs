using System;
namespace Applicaion
{
    public class Car
    {
        protected string brand;
        protected int power;
        protected int year;
        public Car(string brand, int power, int year)
        {
            this.brand = brand;
            this.power = power;
            this.year = year;
        }
        public override string ToString()
        {
            return $"Object:\nbrand: {brand}\npower: {power}\nyear: {year}";
        }
    }

    public class PassengerCar : Car
    {
        protected int passengers;
        protected Dictionary<string, int> details = new Dictionary<string, int>();
        public PassengerCar(string brand, int power, int year, int passengers, Dictionary<string, int> details) : base(brand, power, year)
        {
            this.passengers = passengers;
            this.details = details;
        }
        public void AddDetail(string name, int year)
        {
            details.Add(name, year);
        }
        public int DataOfDetail(string name)
        {
            return details[name];
        }
        public void PrintDetails()
        {
            foreach (var name in details)
            {
                Console.WriteLine($"name: {name.Key}  year: {name.Value}");
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            return base.ToString()+$"\npassengers: {passengers}";
        }
    }
    public class Truck : Car
    {
        protected int max_weight;
        protected string name_of_driver;
        protected Dictionary<string, int> cargo = new Dictionary<string, int>();
        public Truck(string brand, int power, int year, int max_weight,string name_of_driver, Dictionary<string, int> cargo) : base(brand, power, year)
        {
            this.max_weight = max_weight;
            this.name_of_driver = name_of_driver;
            this.cargo = cargo;
        }
        public void NewDriver(string name)
        {
            this.name_of_driver = name;
        }
        public void AddCargo(string name, int weight)
        {
            cargo.Add(name, weight);
        }
        public void DelCargo(string name)
        {
            if (cargo.ContainsKey(name))
                cargo.Remove(name);
        }
        public void PrintCargo()
        {
            foreach (var name in cargo)
            {
                Console.WriteLine($"name: {name.Key}  weight: {name.Value}");
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            return base.ToString() + $"\nmax weight: {max_weight} \nname of driver: {name_of_driver}";
        }
    }
    public class Autopark
    {
        protected string name;
        List<Car> autopark = new List<Car>();
        public Autopark(string name, List<Car> autopark)
        {
            this.name = name;
            this.autopark = autopark;
        }
        public override string ToString()
        {
            string res= "Information about cars in the fleet:\n";
            foreach (var auto in autopark)
            {
                res+=auto.ToString()+"\n\n";
            }
            return res;
        }
    }
    public class ProgrammAutopark
    {
        static void Main(string[] args)
        {
            PassengerCar car1 = new PassengerCar("Toyota", 600, 2018, 5, new Dictionary<string, int> { ["a"] = 2018 , ["b"] = 2020});
            car1.AddDetail("d", 2022);
            Truck car2 = new Truck("Volvo", 1000, 2010, 12000, "Кисляков Антон", new Dictionary<string, int> { ["a"] = 2000, ["b"] = 4000, ["c"] = 700 });
            car1.PrintDetails();
            car2.DelCargo("b");
            car2.PrintCargo();
            Console.WriteLine(car1);
            Console.WriteLine(car2);
            car2.NewDriver("Булгаков Тимофей");
            Console.WriteLine(car2);
            Autopark first = new Autopark("First", new List<Car>() {car1, car2});
            Console.WriteLine(first);
        }
    }
}
