using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run Game --------------------------------------------------------
            NameGame();


            //Exit ------------------------------------------------------------
            Console.ReadKey();
        }

        private static void NameGame()
        {
            //Read Data -------------------------------------------------------
            Console.Write("The Name Game\nWhat's your first name? ");
            string name = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string city = Console.ReadLine();


            //Write Reversed String -------------------------------------------
            Console.WriteLine("Results: {0}, {1}, {2}",
                ReverseString(name),
                ReverseString(lastName),
                ReverseString(city));
        }

        private static string ReverseString(string str)
        {
            //String to Array and reverse order -------------------------------
            char[] charArray = str.ToArray();
            Array.Reverse(charArray);


            //Return a reversed string ----------------------------------------
            return String.Concat(charArray);
        }


        //Overload method. Method with same name that recieves a different type
        //of data. Which method will be called depends on which data is passed.
        private static char[] ReverseString(char[] charArray)
        {
            //Reverse charArray -----------------------------------------------
            Array.Reverse(charArray);


            //Return a reversed Array of Chars --------------------------------
            return charArray;
        }
    }
}