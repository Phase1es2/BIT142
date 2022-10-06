// Hao Yang
// 10/17/2019
// Major Assignment2.cs
// Purpose: Console.Write and using for loops.

/*

make a ConsoleApp1 on visual studio. and make a file Program.cs and paste and run the program

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Draw
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tina's Quilts! I'm glad you're here!");
            Console.WriteLine("What size quilt would you like?");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
                Console.Write("#================# ");
            Console.WriteLine();
            for (int i = 0; i < 10 * size - 1 - 2 * size - 2; i++)
                Console.Write(" ");
            Console.Write("| ");
            for (int i = 0; i < size; i++)
                Console.Write("<><>");
            Console.Write(" |\n");

            for (int i = 0; i < 10 * size - 1 - 2 * size - 2 - 2; i++)
                Console.Write(" ");
            Console.Write("| ");
            Console.Write("<>");
            for (int i = 0; i < size; i++)
                Console.Write("....");
            Console.Write("<>");
            Console.Write(" |\n");

            for (int i = 0; i < 6 * (size - 1) + 1; i++)
                Console.Write(" ");
            Console.Write("| ");
            Console.Write("<>");
            for (int i = 0; i < size; i++)
                Console.Write("........");
            Console.Write("<>");
            Console.Write(" |\n");

            for (int i = 0; i < 4 * (size - 1) - 1; i++)
                Console.Write(" ");
            Console.Write("|");
            Console.Write("<>");
            for (int i = 0; i < size; i++)
                Console.Write("............");
            Console.Write("<>");
            Console.Write("|\n");

            for (int i = 0; i < 4 * (size - 1) - 1; i++)
                Console.Write(" ");
            Console.Write("|");
            Console.Write("<>");
            for (int i = 0; i < size; i++)
                Console.Write("............");
            Console.Write("<>");
            Console.Write("|\n");

            for (int i = 0; i < 6 * (size - 1) + 1; i++)
                Console.Write(" ");
            Console.Write("| ");
            Console.Write("<>");
            for (int i = 0; i < size; i++)
                Console.Write("........");
            Console.Write("<>");
            Console.Write(" |\n");

            for (int i = 0; i < 10 * size - 1 - 2 * size - 2 - 2; i++)
                Console.Write(" ");
            Console.Write("| ");
            Console.Write("<>");
            for (int i = 0; i < size; i++)
                Console.Write("....");
            Console.Write("<>");
            Console.Write(" |\n");

            for (int i = 0; i < 10 * size - 1 - 2 * size - 2; i++)
                Console.Write(" ");
            Console.Write("| ");
            for (int i = 0; i < size; i++)
                Console.Write("<><>");
            Console.Write(" |\n");

            for (int i = 0; i < size; i++)
                Console.Write("#================# ");
            Console.WriteLine();

            Console.ReadLine();
        }
    }

}