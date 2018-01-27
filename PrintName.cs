using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Everything was programmed in Microsoft Visual Studios.

    namespace ConsoleApp1
    {
        class Program
        {
            static void Main(string[] args)
            {
                string myName;
                Console.WriteLine("What is your name?");

                myName = Console.ReadLine();

                Console.WriteLine("Hello, {0}", myName);
                Console.ReadLine();
            }
        }
    }
