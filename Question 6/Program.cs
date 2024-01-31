using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student's name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter exam marks: ");
            if (int.TryParse(Console.ReadLine(), out int marks))
            {
                if (marks >= 0 && marks <= 100)
                {
                    string grade = CalculateGrade(marks);
                    Console.WriteLine($"{studentName} has been assigned Grade {grade}.");
                }
                else
                {
                    Console.WriteLine("Error: Marks should be between 0 and 100 (inclusive).");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input for exam marks. Please enter a valid number.");
            }
            Console.ReadLine();
        }

        static string CalculateGrade(int marks)
        {
            if (marks >= 75 && marks <= 100)
            {
                return "A";
            }
            else if (marks >= 60 && marks <= 74)
            {
                return "B";
            }
            else if (marks >= 50 && marks <= 59)
            {
                return "C";
            }
            else if (marks >= 40 && marks <= 49)
            {
                return "D";
            }
            else
            {
                return "Fail";
            }
        }
    }
}
