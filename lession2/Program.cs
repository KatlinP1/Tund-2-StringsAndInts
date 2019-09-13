using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lession2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.ReadLine();
            string firstName;
            string lastName;
            string favouriteColor;
            Console.WriteLine("Enter your first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            lastName = Console.ReadLine();
            //Console.WriteLine("Nice to meet you, " + firstName + " " + lastName + "!");
            //i´m just a comment
            Console.WriteLine("enter your favourite color");
            favouriteColor = Console.ReadLine();
            Console.WriteLine("Nice to meet you {0} {1}, your favourite color is {2}." , firstName, lastName, favouriteColor );
            Console.ReadLine();

            //Console.WriteLine("What is your favorite color?");
            //Console.ReadLine();
            
            
            
            
            
        
        }
    }
}
