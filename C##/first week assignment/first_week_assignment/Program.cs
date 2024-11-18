using System;
using System.Collections.Generic;

namespace CarsStoreApp
{
    public class CarsStore
    {
        public string StoreName { get; set; }
        public string Location { get; set; }
        public string Owner { get; set; }

        public CarsStore(string storeName, string location, string owner)
        {
            StoreName = storeName;
            Location = location;
            Owner = owner;
        }

        public void DisplayStoreInfo()
        {
            Console.WriteLine($"Store Name: {StoreName}");
            Console.WriteLine($"Location: {Location}");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine(new string('-', 30));
        }
    }

    public class Car
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Car(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public virtual void DisplayCarInfo()
        {
            Console.WriteLine($"Car Name: {Name}");
            Console.WriteLine($"Price: {Price:C}");
        }
    }

    public class CarOnSale : Car
    {
        public decimal DiscountPercent { get; set; }
        public decimal FinalPrice => Price - (Price * DiscountPercent / 100);

        public CarOnSale(string name, decimal price, decimal discountPercent)
            : base(name, price)
        {
            DiscountPercent = discountPercent;
        }

        public override void DisplayCarInfo()
        {
            base.DisplayCarInfo();
            Console.WriteLine($"Discount: {DiscountPercent}%");
            Console.WriteLine($"Final Price: {FinalPrice:C}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter store name: ");
            string storeName = Console.ReadLine();

            Console.Write("Enter store location: ");
            string location = Console.ReadLine();

            Console.Write("Enter store owner: ");
            string owner = Console.ReadLine();

            CarsStore store = new CarsStore(storeName, location, owner);

            List<Car> cars = new List<Car>();

            Console.Write("Enter number of cars to add: ");
            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
                Console.WriteLine($"\nCar {i + 1}:");

                Console.Write("Enter car name: ");
                string carName = Console.ReadLine();

                Console.Write("Enter car price: ");
                decimal carPrice = decimal.Parse(Console.ReadLine());

                Console.Write("Is the car on sale? (yes/no): ");
                string isOnSale = Console.ReadLine();

                if (isOnSale.ToLower() == "yes")
                {
                    Console.Write("Enter discount percentage: ");
                    decimal discountPercent = decimal.Parse(Console.ReadLine());

                    cars.Add(new CarOnSale(carName, carPrice, discountPercent));
                }
                else
                {
                    cars.Add(new Car(carName, carPrice));
                }
            }

            Console.WriteLine("\nStore Details:");
            store.DisplayStoreInfo();

            Console.WriteLine("Available Cars:");
            foreach (var car in cars)
            {
                car.DisplayCarInfo();
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}

