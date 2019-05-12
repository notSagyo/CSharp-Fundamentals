using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            //Timer init ----------------------------------------------------//
            Timer myTimer = new Timer(2000);


            //Timer functionalities -----------------------------------------//
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += elapsed2;

            myTimer.Start();

            Console.WriteLine("Press enter to remove the red event");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
                myTimer.Elapsed -= elapsed2;

            //Exit ----------------------------------------------------------//
            Console.ReadLine();
        }

        private static void elapsed2(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }

}
