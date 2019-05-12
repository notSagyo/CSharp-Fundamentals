using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print Date ----------------------------------------------------//
            DateTime myValue = DateTime.Now;

            Console.WriteLine(myValue);
            Console.WriteLine("\n" + myValue.ToShortDateString());
            Console.WriteLine("\n" + myValue.ToShortTimeString());
            Console.WriteLine("\n" + myValue.ToLongDateString());
            Console.WriteLine("\n" + myValue.ToLongTimeString());


            //Math with dates -----------------------------------------------//
            Console.WriteLine("\nIn 10 days it will be: " + 
                myValue.AddDays(10).ToShortDateString());
            Console.WriteLine("\nIn 2 hours the time is: " + 
                myValue.AddHours(2).ToShortTimeString());
            Console.WriteLine("\nYesterday was: " 
                + myValue.AddDays(-1).ToShortDateString());
            Console.WriteLine("\nWe are in month: " + myValue.Month);

            DateTime myBirthday = new DateTime(1998, 4, 7);

            Console.WriteLine("\nFrom my birthday to now have passed: " + 
                myValue.Subtract(myBirthday).Days + " days");

            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine("\nI'm {0} years old", 
                Math.Round(myAge.Days / 365.25));


            //Parsing Date --------------------------------------------------//
            myBirthday = DateTime.Parse("1998 4 5");
            Console.WriteLine("\nMy birthday is: " + 
                myBirthday.ToShortDateString());


            //Exit ----------------------------------------------------------//
            Console.ReadLine();
        }
    }
}
