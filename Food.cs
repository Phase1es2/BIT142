// Rubyna Vohra
// April 04, 2019
// Food.cs
// Purpose: This program prints various lines to the console depending on
//          the input variables 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Food
    {
        static void Main(string[] args)
        {
            // Simple if/else structure 
            double lecture = 5.8;
            int age = 56;
            if (age < 80)
            {
                Console.WriteLine("I am 56 years old!");
            }
            if (age > lecture)
            {
                Console.WriteLine("I am older than you!");
            }

            // Complex if/else structure using comparison for strings
            string favFood = "Burgers";
            string hateFood = "fries";
            Console.WriteLine(favFood.Equals(hateFood));

            if (favFood.Equals(hateFood))
            {
                Console.WriteLine("hmmm I think you are lying...");
            }
            else
            {
                Console.WriteLine("You're telling the truth");
            }
            Console.ReadLine(); // used to keep the console screen open
        }
    }
}

/*
this is how you multi-line comment
*/
