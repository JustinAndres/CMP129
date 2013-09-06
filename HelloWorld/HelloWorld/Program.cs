using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            string myString = "Hello World From String"; //sentence with numbers and letters
            char myChar= 'a'; //individual characters
            int myInt = 0; // whole numbers only ex: 5, 6, 8,
            float myFloat = 5f; //any decimal point 5.6
            double myDbl = 5; //more precise floats
            bool myBool = false; //true or false
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            
            while ( myInt < 11)
            {
                Console.WriteLine( myInt++);
            }
       
        }

    }
}
