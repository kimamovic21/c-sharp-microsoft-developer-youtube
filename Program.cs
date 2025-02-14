using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car();
            //myCar.Make = "Chevrolet";
            //myCar.Model = "Camaro";
            //myCar.Year = 2018;
            //myCar.Color = "Red";
            //Console.WriteLine(myCar);

            //Car myOtherCar;
            //myOtherCar = myCar;

            //Console.WriteLine(
            //    "{0} {1} {2} {3}",
            //    myOtherCar.Make,
            //    myOtherCar.Model,
            //    myOtherCar.Year,
            //    myOtherCar.Color
            //);

            //myOtherCar.Make = "Chevy";
            //myOtherCar.Model = "Corvette";
            //myOtherCar.Year = 2019;
            //myOtherCar.Color = "Blue";

            //myOtherCar = null;

            //Console.WriteLine(
            //   "{0} {1} {2} {3}",
            //   myOtherCar.Make,
            //   myOtherCar.Model,
            //   myOtherCar.Year,
            //   myOtherCar.Color
            //);

            Car myThirdCar = new Car("Ford", "Escape", 2005, "white");
            Console.Write(myThirdCar);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //public Car()
        //{
        //    Make = "Nissan";
        //    Model = "Altima";
        //    Year = 2018;
        //    Color = "Black";
        //}

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public override string ToString()
        {
            return $"{Year} {Make} {Model} {Color}";
        }
    }
}