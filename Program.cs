using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Chevrolet";
            myCar.Model = "Camaro";
            myCar.Year = 2018;
            myCar.Color = "Red";

            Console.WriteLine(
                "{0} {1} {2} {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color
            );

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value);
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            Console.ReadLine();
        }

        //private static decimal DetermineMarketValue(Car car)
        //{
        //    decimal carValue = 14000.0M;
        //    return carValue;
        //}
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 2000)
                carValue = 14000;
            else
                carValue = 5000;
            return carValue;
        }
    }
}