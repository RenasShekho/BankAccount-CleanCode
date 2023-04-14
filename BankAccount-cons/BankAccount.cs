using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAccount_cons
{
    public class BankAccount
    {
        private double balance;  //  an instance variable for balance with variable type "double". instance variable is variable without value 

        public BankAccount(double balance) // the constructor takes a balance as parameter and it will be use to set the "balance field"
        {
            this.balance = balance;
        }

        public string print() // method with parameter for print 
        {
            return "Your balance is: " + balance; // return statment
        }
        public string newbalance() // method with parameter for print 
        {
            return "" + balance; // return statment
        }


        public string Withdraw(double amount) // take money from balance
        {
            if (balance >= amount) // if the Balance has money more than the amount
            {
                balance -= amount; // so take money from balance
                Console.ForegroundColor = ConsoleColor.Green;
                return "Withdrawal successful. Your current balance is: " + balance;
                 Console.ResetColor();
            }
            else //  if the amount (user withdraw) more than the balance ..... print next line of the code
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "Withdrawal failed. Your current balance is: " + balance + ". Please try to withdraw your current amount.";
           Console.ResetColor();
            }
        }

        public void deposit(double amount) // put money to balance
        {
            balance += amount;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" successful. Your current balance is: " + balance);
            
        }
    }
}
