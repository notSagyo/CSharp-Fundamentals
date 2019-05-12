using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        //Declared variables, methods and 
        //classes are private  by default
        private static string s = "";

        static void Main(string[] args)
        {
            //Using items in scope ------------------------------------------//
            s = "I'm a string";

            Console.WriteLine(s);

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();


            //Exit ----------------------------------------------------------//
            Console.ReadLine();
        }


        //Static Method -----------------------------------------------------//
        //Can be used inside the same class, methods 
        //in  same  class  are  considered  siblings
        static void HelperMethod()
        {
            Console.WriteLine("Value of s from the HelperMethod(): {0}", s);
        }
    }


    //Class Car -------------------------------------------------------------//
    class Car
    {
        //This is what user will use
        public void DoSomething()
        {
            Console.WriteLine(HelperMethod());
        }

        //This will be called to successfully 
        //execute   the   previous   function
        private string HelperMethod()
        {
            return "Hello world!";
        }
    }
}
