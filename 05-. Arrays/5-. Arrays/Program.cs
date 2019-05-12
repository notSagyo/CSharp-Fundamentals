using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Array numbers ---------------------------------------------------
            int[] numbers = new int[5];

            numbers[0] =  4;
            numbers[1] =  8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine("Last number in array \"numbers\" is: \n" + numbers.Last());


            //Array myArray ---------------------------------------------------
            int[] myArray = new int[] { 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            Console.WriteLine("\nAverage in array \"myArray\" is: \n" + myArray.Average());


            //Array names -----------------------------------------------------
            string[] names = new string[] { "Boris", "Cabo", "Hanzo", "Teo" };

            Console.WriteLine("\nThe names in array \"names\" are:");

            foreach (var name in names) Console.WriteLine(name);


            //Reversed names --------------------------------------------------
            Console.WriteLine("\nThe names in array \"names\" reversed are:");

            foreach (var name in names)
            {
                char[] charArray = name.ToCharArray();

                Array.Reverse(charArray);

                Console.WriteLine(charArray);
            }
            

            //Exit ------------------------------------------------------------
            Console.ReadKey();
        }
    }
}