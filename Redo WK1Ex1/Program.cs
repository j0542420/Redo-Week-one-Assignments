using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redo_WK1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this prints out the assignment from week 1
            Console.WriteLine("This is the assignment from Week 1");
            // this prints out a welcome message
            Console.WriteLine("Welcome to ITSE1302");
            // space between the title and the user input
            Console.WriteLine();

            // prints out a title
            Console.WriteLine("Information Input");
            // asking the user for their first name
            Console.WriteLine("What is your First Name? ");
            // user inputs their first name
            string firstName = Console.ReadLine();

            // asking the user for their last name
            Console.WriteLine("What is your Last Name? ");
            // user inputs their last name
            string lastName = Console.ReadLine();

            // asking the user for their Age
            Console.WriteLine("What is your Age? ");
            // user inputs their age
            string age = Console.ReadLine();

            // asking the user for their Favorite Color
            Console.WriteLine("What is your Favorite Color? ");
            // user inputs their Favorite Color
            string color = Console.ReadLine();

            // prints out a meessage with the user's inputs
            Console.WriteLine("Hello, " + firstName + " " + lastName + "! You are " + age + " years old and your favorite color is " + color + ".");
        }
    }
}
