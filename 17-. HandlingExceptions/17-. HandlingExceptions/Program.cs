using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "";
            string directory = @"D:\file.txt";
            try
            {         
                content = System.IO.File.ReadAllText(directory);
                Console.WriteLine(content);   
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("File not found!\n" +
                     "Make sure {0} exists!", directory);
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found!\n" +
                     "Make sure {0} exists!",directory);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Code to finalize
                //setting objects to null
                //Closing database connections
                Console.WriteLine("Closing application now...");
            }
            Console.ReadLine();
        }
    }
}
