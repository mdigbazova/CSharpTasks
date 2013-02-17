using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Methods
{
    class HelloMan
    {



        public static void Main(string[] args)
        {
            // 1. Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
            // Write a program to test this method.
            PrintName();          
            
        }


        public static void PrintName()
        {
            Console.WriteLine("A method that asks the user for his name and prints 'Hello, <name>'. \n\n");

            Console.WriteLine("What is you name?");
            string name = Console.ReadLine();

            if (ProgramForCheckingName(name))
            {
                ProgramForHello(name);
            }
            else
            { Console.WriteLine("You have entered invalid string for name"); }
        }

       
        public static void ProgramForHello(string name)
        {
            Console.WriteLine("Hello {0}!", name);
        }


        public static bool ProgramForCheckingName(string name) 
        {
            bool isString = true;
            for (int letterPosition = 0; letterPosition < name.Length; letterPosition++)
            {
                isString = Char.IsLetter(name, letterPosition);
                if (!isString)
                { break; }
            }
            return isString;
        }


    }
}
