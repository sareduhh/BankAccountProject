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
        //Fields (2)

        public string savingsAccountName;
        public string savingsAccountSettings;

        //Properties (2)

        public string SavingsAccountName
        {
            get { return this.savingsAccountName; }
            set { this.savingsAccountName = value; }
        }

        public string SavingsAccountSettings
        {
            get { return this.savingsAccountSettings; }
            set { this.savingsAccountSettings = value; }
        }

        public int AmountDeposited { get; private set; }

        //Constructors (1)

        public SavingsAccount(string memberName) : base("Savings", memberName)
        {
            //follows the default constructor
            //passes in the savings type
        }

        //Methods

        //Withdrawing from the Savings account.
        public void Withdrawn(int amountWithdrawn)
        {
            Console.WriteLine("");
        }
        //Depositing into the Savings account.
        public void Deposit(int amountDeposited)
        {
            Console.WriteLine("", amountDeposited);
            this.AmountDeposited = amountDeposited;
        }

    }
}
