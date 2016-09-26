using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BankAccountProject
{
   abstract class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Welcome to Gringott's Bank.");
            Console.WriteLine("Please enter your name.");
            string memberName = Console.ReadLine();
            

            SavingsAccount memberSavingsAccount = new SavingsAccount(memberName);
            CheckingAccount memberCheckingAccount = new CheckingAccount(memberName);
            ReserveAccount memberReserveAccount = new ReserveAccount(memberName);
            string accountMenuOptions;
            bool quitting = false;
            do
            {
                Console.WriteLine("Please choose an option.");
                Console.WriteLine("\t1 Checking");
                Console.WriteLine("\t2 Savings");
                Console.WriteLine("\t3 Reserve");
               

                accountMenuOptions = Console.ReadLine();
                switch (accountMenuOptions)
                {
                    case "1":
                        AccountMenuOptions(memberCheckingAccount);
                        break;
                    case "2":
                        AccountMenuOptions(memberSavingsAccount);
                        break;
                    case "3":
                        AccountMenuOptions(memberReserveAccount);
                        break;
                    default:
                        Console.WriteLine("Thank you for visiting Gringott's. Good-bye.");
                        quitting = true;
                        break;
                }
            }
            while (!quitting);
        }


        //Account Menu Method
        public static void AccountMenuOptions(AccountBase memberAccount)
        {
            bool quitting = false;
            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("\t1 Deposit");
                Console.WriteLine("\t2 Withdraw");
                Console.WriteLine("\t3 View Balance");
            
                string menuOption = Console.ReadLine();
                switch (menuOption)
                {
                    case "1":
                        Console.WriteLine("Enter the amount you would like to deposit.");
                        try
                        {
                            double amount = Double.Parse(Console.ReadLine());
                            if (amount > 0)
                            {
                                memberAccount.Deposited(amount);
                            }
                            else
                            {
                                Console.WriteLine("That is not a valid entry, try again.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("That is not a valid entry, try again.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter the amount you would like to withdraw.");
                        try
                        {
                            double amount = Double.Parse(Console.ReadLine());
                            if (amount > 0)
                            {
                                memberAccount.Withdrawn(amount);
                            }
                            else
                            {
                                Console.WriteLine("That is not a valid entry, try again.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("That is not a valid entry, try again.");

                        }
                        break;
                    case "3":
                        memberAccount.ViewAccountBalance(true);
                        break;
                    default:
                        Console.WriteLine("Thank you for visiting Gringott's. Good-bye.");
                        quitting = true;
                        break;
                }
            }
            while (!quitting);

        }
    
    }
}
