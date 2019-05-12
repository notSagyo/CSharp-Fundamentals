using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            //New Instance of Car Class -------------------------------------//
            Car myCar = new Car()
            {
                Make  = "Ferrari",
                Model =      "F8",
                Year  =      2019,
                Color =      "Red"
            };

            //Another Instance which points to same memory adress
            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color);

            myOtherCar.Year = 2020;

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            //Remove memory reference
            myOtherCar = null;


            //Create Car instance using constructor -------------------------//
            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");
            Console.WriteLine("{0} {1} {2} {3}",
                myThirdCar.Make,
                myThirdCar.Model,
                myThirdCar.Year,
                myThirdCar.Color);


            //Using Static Method -------------------------------------------//
            Car.MyMethod();


            //Exit ----------------------------------------------------------//
            Console.ReadLine();
        }
    }

    public class Car
    {
        public string Make  { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //Get Object into a  valid  state, so it's 
        //immediately usable when instantiating it
        public Car()
        {
        }

        //Constructor that takes 5 parameters and
        //then copy them to the  class parameters
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        //Static Method can be called without 
        //creating an  instance  of the class
        public static void MyMethod()
        {
            Console.WriteLine("Called Static Method");
        }
    }
}
