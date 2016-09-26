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
        private static object memberAccount;
        private static string memberName;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gringott's Bank.");
            Console.WriteLine("Please enter your name.");

            string memberName = Console.ReadLine();



            StreamWriter checking = new StreamWriter("CheckingAccount.txt", true);
            StreamWriter savings = new StreamWriter("SavingsAccount.txt", true);
            StreamWriter reserve = new StreamWriter("ReserveAccount.txt", true);

            double amount = Double.Parse(Console.ReadLine());

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
                        using (checking)
                        {
                            checking.Write("Checking Account Number 09182431023847." + memberName + amount);
                        }
                        checking.Close();
                        break;
                    case "2":
                        AccountMenuOptions(memberSavingsAccount);
                        using (savings)
                        {
                            savings.Write("Savings Account Number 13248723483." + memberName + amount);
                        }
                        savings.Close();
                            break;
                    case "3":
                        AccountMenuOptions(memberReserveAccount);
                        using (reserve)
                        {
                            reserve.Write("Reserve Account Number 823472348." + memberName + amount);
                        }
                        reserve.Close();
                            break;
                    default:
                        Console.WriteLine("Thank you for visiting Gringott's. Good-bye.");
                        quitting = true;
                        break;
                }
            }
            while (!quitting);
            
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
                           
                            if (amount > 0)
                            {
                                memberAccount.Deposited(amount)
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
                                using (checking) using (savings) using (reserve)
                                {
                                    checking.Write("Checking Account Number 09182431023847." + memberName + amount);
                                    savings.Write("Savings Account Number 13248723483." + memberName + amount);
                                    reserve.Write("Reserve Account Number 823472348." + memberName + amount);
                                }
                                checking.Close(); savings.Close(); reserve.Close();
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

        private static void AccountMenuOptions(CheckingAccount memberCheckingAccount)
        {
            throw new NotImplementedException();
        }
    }
}
