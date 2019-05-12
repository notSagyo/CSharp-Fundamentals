using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess game!\n1 - 2 - 3?: ");
            string userValue = Console.ReadLine();

            string message = "";

            /*if (userValue == "1")
                message = "You won a car.";
            else if (userValue == "2")
                message = "Big Prize! You won an Avocado!";
            else if (userValue == "3")
                message = "No prize for you.";
            else
                message = "I said 1 2 or 3 noob.";*/

            switch (userValue)
            {
                case "1":
                    message = "You won a car.";
                    break;
                case "2":
                    message = "Big Prize! You won an Avocado!";
                    break;
                case "3" when message != "4":
                    message = "No prize for you.";
                    break;
                default:
                    if (userValue == "5" || userValue == "9")
                        message = "Secret code activated.";
                    else
                        message = "I said 1 2 or 3 noob.";
                    break;
            }

            Console.WriteLine(message + "\nWant to change your choice? 1=yes, 2=no.");
            userValue = Console.ReadLine();
            //"?" = Ternary Operator. Condition ? valueIfTrue : elseValue;
            message = (userValue == "1") ? "You can't. Ha." : (userValue == "2") ? "I'm glad." : "Dumbass"; 
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
