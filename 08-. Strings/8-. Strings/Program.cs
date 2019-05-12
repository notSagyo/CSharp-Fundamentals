using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run Examples---------------------------------------------------//
            StringExamples();

            //Exit ----------------------------------------------------------//
            Console.ReadKey();
        }

        private static void StringExamples()
        {
            //Escape characters ---------------------------------------------//
            string myString = "Escaped Characters:I'm\n\"fine\"";
            Print(myString);
            NewLine();

            //Literal String | Verbatim Identifier --------------------------//
            myString = @"Literal String: Go to your C:\Drive";
            Print(myString);
            NewLine();


            //Composite Formatting ------------------------------------------//
            myString = string.Format("Group Separator: {0:N2}", 12345678.99);
            Print(myString);
            NewLine();

            myString = string.Format("Currency: {0:C}", 12345678.99);
            Print(myString);
            NewLine();

            myString = string.Format("Percentage: {0:P}", .675);
            Print(myString);
            NewLine();

            myString = string.Format
                ("Phone Number: {0:### ###-####}", 28044326789);
            Print(myString);

            //Clear Screen when finishing formatting examples
            Console.ReadLine();
            Console.Clear();


            //Manipulate Strings --------------------------------------------//
            myString = "f you. Please remove that 29.Hello World!";
            myString =  myString.Substring(29, 8);
            Print(myString);
            NewLine();

            myString = "Today was an unproductive day";
            Print(myString);
            NewLine();
            myString = myString.Replace("an unproductive", "a productive");
            myString = myString.Replace(" ","-");
            Print(myString);
            NewLine();

            myString = "You're fricking boring";
            myString = myString.Remove(7, 9);
            Print(myString);
            NewLine();

            myString = "         remooove the spaceeees         ".Trim();
            Print(myString);
            NewLine();

            //String Builder-------------------------------------------------//
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello World!");
            stringBuilder.Append(" Eat fish and vegetables.");
            stringBuilder.Clear();
            stringBuilder.Append("Eat pizza everyday.");

            Print(stringBuilder.ToString());
            NewLine();
        }
        
        private static void Print(string s)
        {
            Console.WriteLine(s);
        }


        //New Line Method to Skip n lines -----------------------------------//
        private static void NewLine()
        {
            Console.WriteLine();
        }

        private static void NewLine(int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
