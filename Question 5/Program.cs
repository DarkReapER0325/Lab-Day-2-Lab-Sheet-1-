using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int Number))
            {
                Console.WriteLine($"Multiplication table for {Number}:");

                for (int i = 1; i <= 10; i++)
                {
                    int result = Number * i;
                    Console.WriteLine($"{Number} x {i} = {result}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ReadLine();
        }
    }
}
