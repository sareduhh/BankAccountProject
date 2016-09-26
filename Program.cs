using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BankAccountProject
{
        class Program
    {
        static void Main(string[] args)
        {
            //open streamwriter to create text file
            StreamWriter accountReserve = new StreamWriter("ReserveAccount.txt");
            StreamWriter accountSavings = new StreamWriter("SavingsAccount.txt");
            StreamWriter accountChecking = new StreamWriter("CheckingAccount.txt");

         
            //get member name
            Console.WriteLine("Please enter your name.");
            string memberName = Console.ReadLine();

            Console.Clear();

            //create objects to use classes
            SavingsAccount savings = new SavingsAccount(memberName);
            CheckingAccount checking = new CheckingAccount(memberName);
            ReserveAccount reserve = new ReserveAccount(memberName);

            //streamwriter .txt files
            accountChecking.WriteLine("Gringott's Member " + memberName);
            accountChecking.WriteLine("Account Number: " + checking.AccountNumber);
            accountChecking.WriteLine("Account Type: Checking Account");
            accountChecking.WriteLine("Account Balance: " + checking.AccountBalance);

            accountSavings.WriteLine("Gringott's Member " + memberName);
            accountSavings.WriteLine("Account Number: " + savings.AccountNumber);
            accountSavings.WriteLine("Account Type: Savings Account");
            accountSavings.WriteLine("Account Balance: " + savings.AccountBalance);

            accountReserve.WriteLine("Gringott's Member " + memberName);
            accountReserve.WriteLine("Account Number: " + reserve.AccountNumber);
            accountReserve.WriteLine("Account Type: Reserve Account");
            accountReserve.WriteLine("Account Balance: " + reserve.AccountBalance);

            //loop for menu
            while (true)
            {
                //menu
                Console.WriteLine("Welcome to Gringott's Bank for Wizards and Witches. Please make a selection.");
                Console.WriteLine("1: View Member Info");
                Console.WriteLine("View Account Balance of:" + memberName);
                Console.WriteLine("\t2: Checking Account");
                Console.WriteLine("\t3: Savings Account");
                Console.WriteLine("\t4: Reserve Account");
                Console.WriteLine("5: Deposit Funds");
                Console.WriteLine("6: Withdrawal Funds");
        

                //member choice for which action on menu
                int action = int.Parse(Console.ReadLine());

                Console.Clear();

                //switch/case actions
                switch (action)
                {
                    case 1:
                        savings.ClientInfo();
                        break;

                    case 2:
                        checking.ViewAccountBalance();
                        break;

                    case 3:
                        savings.ViewAccountBalance();
                        break;

                    case 4:
                        reserve.ViewAccountBalance();
                        break;

                    case 5:
                        Console.WriteLine("Please make a selection.");
                        Console.WriteLine("1: Checking Account");
                        Console.WriteLine("2: Savings Account");
                        Console.WriteLine("3: Reserve Account");

                        int choice = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter deposit amount.");

                        int deposit = int.Parse(Console.ReadLine());


                        // switch/case for deposit selection
                        switch (choice)
                        {
                            case 1:
                                checking.Deposit(deposit);
                                Console.WriteLine("Your account balance is " + checking.AccountBalance);
                                accountChecking.WriteLine("+ " + deposit + " " + DateTime.Now);
                                accountChecking.WriteLine("Account Balance: " + checking.AccountBalance);
                                break;

                            case 2:
                                savings.Deposit(deposit);
                                Console.WriteLine("Your account balance is " + savings.AccountBalance);
                                accountSavings.WriteLine("+ " + deposit + " " + DateTime.Now);
                                accountSavings.WriteLine("Account Balance: " + savings.AccountBalance);
                                break;

                            case 3:
                                reserve.Deposit(deposit);
                                Console.WriteLine("Your account balance is " + reserve.AccountBalance);
                                accountReserve.WriteLine("+ " + deposit + " " + DateTime.Now);
                                accountReserve.WriteLine("Account Balance: " + reserve.AccountBalance);
                                break;

                            default:
                                break;

                        }
                        break;

                    case 6:
                        Console.WriteLine("Please make a selection.");
                        Console.WriteLine("1: Checking Account");
                        Console.WriteLine("2: Savings Account");
                        Console.WriteLine("3: Reserve Account");

                        int pick = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter withdrawal amount.");

                        int withdrawal = int.Parse(Console.ReadLine());

                        //switch/case for withdrawing
                        switch (pick)
                        {
                            case 1:
                                checking.Withdrawal(withdrawal);
                                Console.WriteLine("The new balance is " + checking.AccountBalance);
                                accountChecking.WriteLine("- " + withdrawal + " " + DateTime.Now);
                                accountChecking.WriteLine("Account Balance: " + checking.AccountBalance);
                                break;

                            case 2:
                                savings.Withdrawal(withdrawal);
                                Console.WriteLine("The new balance is " + savings.AccountBalance);
                                accountSavings.WriteLine("- " + withdrawal + " " + DateTime.Now);
                                accountSavings.WriteLine("Account Balance: " + savings.AccountBalance);
                                break;

                            case 3:
                                reserve.Withdrawal(withdrawal);
                                Console.WriteLine("The new balance is " + reserve.AccountBalance);
                                accountReserve.WriteLine("- " + withdrawal + " " + DateTime.Now);
                                accountReserve.WriteLine("Account Balance: " + reserve.AccountBalance);
                                break;
                        }
                        break;

                    default:
                        //quits
                        break;

                }


                Console.WriteLine("Do you need more time?");
                string yesOrNo = Console.ReadLine();
                if (yesOrNo.ToLower() == "y")
                {
                    Console.Clear();
                }
                else
                {
               //quits the program if "no"
                    Console.Clear();
                    break;
                }

            }

            //closes the streamwriters
            accountReserve.Close();
            accountSavings.Close();
            accountChecking.Close();

            Quit();
        }


        //quit method
        static void Quit()
        {
            Console.WriteLine("Thank you for choosing Gringott's.");
            Environment.Exit(0);
        }
    }
}

