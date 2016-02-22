using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world !");
            Console.WriteLine("Hello world !");
            Console.WriteLine("Hello world !");
            Console.WriteLine("Hello world !");
            Console.WriteLine("Hello world !");
            Console.WriteLine("Hello world !");
            Console.WriteLine("Hello world !");

            List<String> CountryList = new List<string>() { "India","Pakistan","Bangladesh","Nepal","China"};

            foreach (string str in CountryList) {

                Console.WriteLine("*"+str);
            }

        }
    }
}
