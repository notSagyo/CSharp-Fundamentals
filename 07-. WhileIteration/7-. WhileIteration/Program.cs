using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables -------------------------------------------------------
            bool displayMenu = true;


            //Display Menu Until False ----------------------------------------
            while (displayMenu) displayMenu = MainMenu();
        }

        private static bool MainMenu()
        {
            //Option Selection ------------------------------------------------
            Console.Clear();

            Console.WriteLine("Choose an option:" +
                             "\n1) Print Numbers" +
                             "\n2) Guessing Game" +
                                     "\n3) Exit"  );

            ConsoleKeyInfo input = Console.ReadKey();


            //Option Action ---------------------------------------------------
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    PrintNumber();
                    return true;
                case ConsoleKey.D2:
                    GuessingGame();
                    return true;
                case ConsoleKey.D3:
                    return false;
                default:
                    return true;
            }
        }

        private static void PrintNumber()
        {
            //Read Input ------------------------------------------------------
            Console.Clear();
            Console.Write("Print Numbers" +
                            "\nType a Number: ");

            int result = int.Parse(Console.ReadLine());


            //Write result ----------------------------------------------------
            for (int i = 0; i < result; i++)
            {
                Console.Write((i + 1) + " ");
            }


            //Exit ------------------------------------------------------------
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            //Declare variables -----------------------------------------------
            int guesses = 0;
            bool incorrect = true;


            //Set Random ------------------------------------------------------
            Random random = new Random();
            int rand = random.Next(1, 10);


            //Message ---------------------------------------------------------
            Console.Clear();
            Console.WriteLine("Guessing Game");
            Console.Write("Guess a number between 1 and 10: ");


            //Play guessing game ----------------------------------------------
            do
            {
                if (Console.ReadLine() == rand.ToString()) incorrect = false;
                    else Console.WriteLine("Wrong!");

                guesses++;
            } while (incorrect == true);


            //Exit ------------------------------------------------------------
            Console.WriteLine("Correcto!\nIt took you: {0} guesses", guesses);
            Console.ReadLine();
        }
    }
}