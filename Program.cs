using System;
using System.IO; 
using System.Net;
using System.Collections;

namespace WorkingWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car { Make = "Toyota", Model = "Camry", VIN = "A1", StickerPrice = 25000, Year = 1982 },  
                new Car { Make = "Nissan", Model = "Altima", VIN = "B2", StickerPrice = 22000, Year = 1993 }, 
                new Car { Make = "BMW", Model = "750li", VIN = "C3", StickerPrice = 70000, Year = 1987 },
                new Car { Make = "BMW", Model = "55i", VIN = "D4", StickerPrice = 55000, Year = 2004 },  
                new Car { Make = "Toyota", Model = "4Runner", VIN = "E5", StickerPrice = 35000, Year = 1984 },
                new Car { Make = "Ford", Model = "Escape", VIN = "F6", StickerPrice = 30000, Year = 2000 },
            };

            //var bmws = from car in myCars
            //           where car.Make == "BMW"
            //           && car.Year == 2004
            //           select car;

            //foreach (var car in bmws)
            //{
            //    Console.WriteLine("{0} {1}", car.Model, car.VIN);
            //}


            //var bmws2 = myCars.Where(p => p.Make == "BMW" && p.Year == 2004);

            //foreach (var car in bmws2)
            //{
            //    Console.WriteLine("{0} {1}", car.Model, car.VIN);
            //}


            //var orderedCars = from car in myCars
            //                  orderby car.Year descending
            //                  select car;

            //foreach (var car in orderedCars)
            //{
            //    Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            //}


            //var orderedCars = myCars.OrderByDescending(p => p.Year);

            //foreach (var car in orderedCars)
            //{
            //    Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            //}


            //var firstBMW = myCars
            //    .OrderByDescending(p => p.Year)
            //    .First(p => p.Make == "BMW");
            //Console.WriteLine(firstBMW.VIN);


            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2000));


            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));


            //Console.WriteLine(myCars.Exists(p => p.Model == "750li"));


            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));


            //Console.WriteLine(myCars.GetType());


            //var orderedCars = myCars.OrderByDescending(p => p.Year);
            //Console.WriteLine(orderedCars.GetType());


            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2004);
            //Console.WriteLine(bmws.GetType());


            //var newCars = from car in myCars
            //              where car.Make == "BMW"
            //              && car.Year == 2004
            //              select new { car.Make, car.Model };
            //Console.WriteLine(newCars.GetType());

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}