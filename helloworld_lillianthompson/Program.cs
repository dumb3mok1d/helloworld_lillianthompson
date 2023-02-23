// System namespace needed to use Console class.
using System;

// My collection for classes for the project
namespace HelloWorld_Thompson_Lillian
{
    // Main Class for our program
    class Program
    {
        // The Main method is executed when applicaton starts 
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name"); // Ask the user for first name
            string firstName = Console.ReadLine();        // Assigns user input to firstName variable 
            Console.WriteLine("what is your last name");  // Ask the user for last name
            string lastname = Console.ReadLine();         // Assigns user input to lastName variable 

            Console.WriteLine("Hello," + firstName + " " + lastname + "!"); // Prints a welcome message with firstName and lastName
                       
       

        }   

      
    }
} 
