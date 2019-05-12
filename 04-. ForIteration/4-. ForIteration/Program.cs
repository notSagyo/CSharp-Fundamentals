using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine(i);
                if (i == 198)
                {
                    Console.WriteLine("Found {0}",i);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
