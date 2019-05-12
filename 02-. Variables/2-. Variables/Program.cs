using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What's your name?");
            string firstName = Console.ReadLine();

            Console.WriteLine(firstName + " What's your last name"); //Concatenate string.
            string lastName = Console.ReadLine();

            //Composite formatting ("{0} bla bla {1}", 0reference, 1reference).
            Console.WriteLine("Nice to meet you {0} {1}! :)", firstName, lastName); 
            Console.ReadLine();
        }
    }
}
