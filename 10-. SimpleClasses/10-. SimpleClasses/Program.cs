using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating and using Car Class' Object --------------------------//
            Car myCar   = new Car();
            myCar.Make  = "Ferrari";
            myCar.Model =      "F8";
            myCar.Year  =      2019;
            myCar.Color =     "Red";


            Console.WriteLine("Your car is: {0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            Console.WriteLine("Value: {0:C}", myCar.DetermineMarketValue());


            //Exit ----------------------------------------------------------//
            Console.ReadLine();
        }


    }


    //Class Car -------------------------------------------------------------//
    //Classes are a datatype - "blueprint", objects are instances of this class
    class Car
    {
        //Class Properties --------------------------------------------------//
        public string Make  { get; set; }
        public string Model { get; set; }
        public int    Year  { get; set; }
        public string Color { get; set; }

        //Class Method ------------------------------------------------------//
        public decimal DetermineMarketValue()
        {
            decimal carValue = (Year > 2000) ? 10000000 : 1000000;

            return carValue;
        }
    }
}
