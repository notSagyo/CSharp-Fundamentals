using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace isn't necessary to match Solution Name.
namespace HelloWorld
{
	class HelloWorldClass
	{
		static void Main() //Class must contain a static Main, strictly named "Main".
        {
			
			string name; //Static methods can't use non-static variables.

            Console.WriteLine("Hello World!\n\nWhat's your name?"); //Everything with ThisFormat() is a Class or Method.
            
            name = Console.ReadLine(); //Console.Readline(name) doesn't work.

            Console.WriteLine($"\nHello {name}."); //Use $ to create interpolated strings.
            Console.ReadKey();
		}
	}
}