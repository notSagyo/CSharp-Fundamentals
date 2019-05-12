using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Program
    {
        public static List<Car> myCars = new List<Car>() {
            new Car{ VIN="A1", Make="BMW",    Model="550i",    StickerPrice=55000, Year=2009},
            new Car{ VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
            new Car{ VIN="C3", Make="BMW",    Model="745li",   StickerPrice=75000, Year=2008},
            new Car{ VIN="D4", Make="Ford",   Model="Escape",  StickerPrice=25000, Year=2008},
            new Car{ VIN="E5", Make="BMW",    Model="55i",     StickerPrice=57000, Year=2010}
        };

        static void Main(string[] args)
        {

            //LINQ Query
            var bmws = from car in myCars
                       where car.Make.ToLower() == "bmw"
                       && car.Year == 2010
                       select car;
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            var newCars = from car in myCars
                          where car.Make == "BMW"
                          && car.Year == 2010
                          select new { car.Make, car.Model };

            //LINQ Method
            //var bmws = myCars.Where(car => car.Make == "BMW" && car.Year == 2010);
            //var orderedCars = myCars.OrderByDescending(car => car.Year);
            //var firstBMW = myCars.
            //    OrderByDescending(car => car.Year).
            //    First(car => car.Make.ToLower() == "bmw");

            //Outputs & other -----------------------------------------------//
            //foreach (var car in firstItem) 
            //{
            //    Console.WriteLine("{0}", car.Year);
            //}
            //Console.WriteLine("{0} {1} {2}",
            //    firstBMW.Make,
            //    firstBMW.Model,
            //    firstBMW.Year);
            myCars.ForEach(car => car.StickerPrice -= 5000);
            myCars.ForEach(car => Console.WriteLine("{0} {1:C}", car.VIN, car.StickerPrice));
            Console.WriteLine(myCars.TrueForAll(x => x.Year > 2007));
            Console.WriteLine(myCars.Exists(p => p.Model == "745li"));
            Console.WriteLine("{0:C}", myCars.Sum(p => p.StickerPrice));
            Console.WriteLine(myCars.GetType());
            Console.WriteLine(myCars);
            Console.WriteLine(bmws);
            Console.WriteLine(orderedCars);
            Console.WriteLine(newCars.GetType());
            foreach (var bmw in bmws) Console.WriteLine("{0} {1}", bmw.Make, bmw.Model);
            bmws.ToList().ForEach(bmw => Console.WriteLine("{0} {1}", bmw.Make, bmw.Model));
            Console.WriteLine("{0} BMWs in my Car", myCars.FindAll(car => car.Make == "BMW").Count);

            //Exit ----------------------------------------------------------//
            Console.ReadLine();
        }

        private void TestLINQ()
        {
            myCars = myCars.OrderBy(x => x.VIN).ToList();
            myCars = (List<Car>)myCars.OrderBy(x => x.VIN);

            List<Car> bmws = myCars.Where(x => x.Year > 2000).ToList();
        }
    }

    public class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }

}
