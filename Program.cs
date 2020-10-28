using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string selectedCountry;

            // Prints welcome message to user
            Console.WriteLine($"Welcome to the Vacation Budget Planner!");
            
            //Asks user for their name and saves it as a string variable
            Console.WriteLine($"Please enter your name:");
            userName = Console.ReadLine();

            //Welcome message and travel option 
            Console.WriteLine($"Welcome {userName}! Please enter the country you wanto to? Jamacia or Mexico");
            selectedCountry = Console.ReadLine();
            
            //Saves the selected country as a string variable
            Console.WriteLine($"You have selected {selectedCountry}. Save those dollars!");
            Console.ReadLine();
           
        }
    }
}
