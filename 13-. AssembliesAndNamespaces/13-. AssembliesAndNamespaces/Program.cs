using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates File with System.IO namespace, and System.Net ---------//
            string text = "heru, am a text file";

            Console.WriteLine(text);
            System.IO.File.WriteAllText ( @"D:\MyFile.txt", text );

            System.Net.WebClient client = new System.Net.WebClient();
            //or use 'using System.Net' instead.
            string reply = client.DownloadString("http://docs.microsoft.com/");

            Console.WriteLine(reply);
            System.IO.File.WriteAllText( @"D:\MicrosoftDocs.txt", reply );


            //Exit ----------------------------------------------------------//
            Console.ReadLine();
        }
    }
}
