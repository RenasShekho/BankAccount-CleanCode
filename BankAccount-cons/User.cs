using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;




namespace BankAccount_cons
{


    public class User
    {
        public static void Menu() // method for user interface
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bank Account Menu");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Withdraw money");
            Console.WriteLine("3. Deposit money");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter '1' to check balance '2' to withdraw, '3' to deposit, or '4' to quit:");
            Console.ResetColor();
        }

        public static void optins(BankAccount account)
        {
            double input; // Declare input outside of the if statement
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out input)) 
                {
                    continue; // Continue the loop if the input is invalid
                }
                switch (input)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(account.print());
                        Console.ResetColor();
                        break;

                    case 2:
                        Console.WriteLine("Enter the amount to withdraw:");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        {
                            string result = account.Withdraw(withdrawAmount);
                            Console.WriteLine(result);
                           
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for withdrawal amount.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter the amount to deposit:");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            account.deposit(depositAmount);
                           
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input for deposit amount.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thanks, Have a good Time");
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option selected.");
                        break;
                }
            }
        }
    } 
}   
       
   

