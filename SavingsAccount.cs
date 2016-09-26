using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class SavingsAccount : AccountBase
    {
        //fields (2)

        private int accountBalance;
        private string accountNumber;


        //properties (2)

        public int AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //constructor (1)

        public SavingsAccount(string memberName) : base(memberName)
        {
            this.accountNumber = "0091234734";
            this.accountBalance = 123876;
        }

        //methods

        public override int Deposit(int money)
        {
            this.accountBalance += money;
            return this.accountBalance;
        }

        public override int Withdrawal(int money)
        {
            this.accountBalance -= money;
            return this.accountBalance;
        }

        public override void ViewAccountBalance()
        {
            Console.WriteLine("Account Balance: " + AccountBalance);
        }

    }
}
