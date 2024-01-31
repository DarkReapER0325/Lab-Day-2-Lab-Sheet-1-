using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    internal class Program
    {
        static double balance = 1000;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple ATM Machine!");

            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your balance: ${balance}");
        }

        static void DepositMoney()
        {
            Console.Write("Enter the amount to deposit: $");
            double depositAmount = double.Parse(Console.ReadLine());

            if (depositAmount > 0)
            {
                balance += depositAmount;
                Console.WriteLine($"${depositAmount} deposited successfully.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
            }
        }

        static void WithdrawMoney()
        {
            Console.Write("Enter the amount to withdraw: $");
            double withdrawAmount = double.Parse(Console.ReadLine());

            if (withdrawAmount > 0 && withdrawAmount <= balance)
            {
                balance -= withdrawAmount;
                Console.WriteLine($"${withdrawAmount} withdrawn successfully.");
            }
            else if (withdrawAmount > balance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal amount exceeds balance.");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Please enter a positive value.");
            }
        }
    }
}
