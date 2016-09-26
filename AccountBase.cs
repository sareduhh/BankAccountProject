using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    abstract class AccountBase
    {
        //Fields (2)
        private double balanceAmount;
        private string accountType;
        private string memberName;
        private bool checking;
        private bool savings;
        private bool reserve;


        //Properties (2)

        public double BalanceAmount
        {
            get { return this.BalanceAmount; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }
        public string UserID
        {
            get { return this.memberName; }
            set { this.memberName = value; }
        }

        public string FileName
        {
            get { return this.memberName + "_" + this.accountType + ".txt"; }
        }


        //Constructors (1)

        public AccountBase(string type, string member)
        {
            accountType = type;
            memberName = member;
            balanceAmount = 0.0;
        
        }

        

        //The withdrawing method
        public void Withdraw(double amount)
        { 
            if (amount < balanceAmount)
            {
                balanceAmount -= amount;
                string withdrawOutPut = "Withdrawing $" + amount + " from " + accountType;
                string fileText = memberName + " " + " " + accountType + " " + DateTime.Now + " -" + amount + " " + balanceAmount;
                StreamWriter writer = new StreamWriter("CheckingAccount.txt", true);
                Console.WriteLine(withdrawOutPut);
                writer.WriteLine(fileText);
                string balanceError = ViewAccountBalance(true);
                writer.WriteLine(balanceError);
                writer.Close();
            }
            else if (amount < balanceAmount)
            {
                balanceAmount -= amount;
                string withdrawOutPut = "Withdrawing $" + amount + " from " + accountType;
                string fileText = memberName + " " + " " + accountType + " " + DateTime.Now + " -" + amount + " " + balanceAmount;
                StreamWriter writer = new StreamWriter("SavingsAccount.txt", true);
                Console.WriteLine(withdrawOutPut);
                writer.WriteLine(fileText);
                string balanceError = ViewAccountBalance(true);
                writer.WriteLine(balanceError);
                writer.Close();
            }
            else if (amount < balanceAmount)
            {
                balanceAmount -= amount;
                string withdrawOutPut = "Withdrawing $" + amount + " from " + accountType;
                string fileText = memberName + " " + " " + accountType + " " + DateTime.Now + " -" + amount + " " + balanceAmount;
                StreamWriter writer = new StreamWriter("ReserveAccount.txt", true);
                Console.WriteLine(withdrawOutPut);
                writer.WriteLine(fileText);
                string balanceError = ViewAccountBalance(true);
                writer.WriteLine(balanceError);
                writer.Close();
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        //The depositing method
        public void Deposit(double amount)
        {
            if (checking)
            {
                balanceAmount += amount;
                string depositOutPut = "Depositing $" + amount + " to " + accountType;
                string fileText = memberName + " " + " " + accountType + " " + DateTime.Now + " +" + amount + " " + balanceAmount;
                StreamWriter writer = new StreamWriter("CheckingAccount.txt", true);
                Console.WriteLine(depositOutPut);
                writer.WriteLine(fileText);
                string balanceError = ViewAccountBalance(true);
                writer.WriteLine(balanceError);
                writer.Close();
            }
            else if (savings)
            {
                balanceAmount += amount;
                string depositOutPut = "Depositing $" + amount + " to " + accountType;
                string fileText = memberName + " " + " " + accountType + " " + DateTime.Now + " +" + amount + " " + balanceAmount;
                StreamWriter writer = new StreamWriter("SavingsAccount.txt", true);
                Console.WriteLine(depositOutPut);
                writer.WriteLine(fileText);
                string balanceError = ViewAccountBalance(true);
                writer.WriteLine(balanceError);
                writer.Close();
            }
            else if (reserve)
                {
                balanceAmount += amount;
                string depositOutPut = "Depositing $" + amount + " to " + accountType;
                string fileText = memberName + " " + " " + accountType + " " + DateTime.Now + " +" + amount + " " + balanceAmount;
                StreamWriter writer = new StreamWriter("ReserveAccount.txt", true);
                Console.WriteLine(depositOutPut);
                writer.WriteLine(fileText);
                string balanceError = ViewAccountBalance(true);
                writer.WriteLine(balanceError);
                writer.Close();
            }
            else
            {
                Console.WriteLine("Invalid request.");
            }
        }
        //The view account balance method
        public string ViewAccountBalance(bool writeToConsole)
        {
            string balanceError = "The most recent balance on your " + accountType + " is $" + balanceAmount;
            if (balanceAmount < 0)
            {
                balanceError += "\n Your account needs immediate attention.";
            }
            if (writeToConsole)
            {
                Console.WriteLine(balanceError);
            }
            return balanceError;
        }

        internal void Deposited(double amount)
        {
          
        }

        internal void Withdrawn(double amount)
        {
          
        }
    }
}

