using System;
using System.IO; 
using System.Net;
using System.Collections;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Nissan";
            car2.Model = "Altima";
            car2.VIN = "B2";

            Book book1 = new Book();
            book1.Title = "Microsoft .NET XML Web Services";
            book1.Author = "Bob Tabor";
            book1.ISBN = "0-000-00000-0";

            // ArrayLists are dynamically sized
            // cool features sorting, remove items
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);
            myArrayList.Remove(book1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }

            // List<T> are type safe
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(book1); // This would generate a compile error

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }

            // Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);


            string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Objetct initializer
            // No need for a constructor
            Car car3 = new Car() { Make = "BMW", Model = "750li", VIN="C3"};
            Car car4 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };

            // Collection initializer
            List<Car> myList2 = new List<Car>()
            {
                new Car { Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "E5" },
                new Car { Make = "Chevrolet", Model = "Impala", VIN = "F6" }
            };

            foreach (Car car in myList2)
            {
                Console.WriteLine(car.Model);
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}