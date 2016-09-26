using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class CheckingAccount : AccountBase
    {
        //Fields (2)

        public string checkingAccountName;
        public string checkingAccountSettings;

        //Properties (2)

        public string CheckingAccountName
        {
            get { return this.checkingAccountName; }
            set { this.checkingAccountName = value; }
        }

        public string CheckingAccountSettings
        {
            get { return this.checkingAccountSettings; }
            set { this.checkingAccountSettings = value; }
        }

        public int AmountDeposited { get; private set; }

        //Constructors (1)

        public CheckingAccount(string memberName) : base("Checking", memberName)
        {
            //follows the default constructor
            //passes in the checking type
        }

        //Methods

        //Withdrawing from the Checking account
        public void Withdrawn(int amountWithdrawn)
        {
            Console.WriteLine("", amountWithdrawn, this.AmountDeposited);
            Withdrawn(amountWithdrawn);
        }
        //Depositing into the Checking account
        public void Deposit(int amountDeposited)
        {
            Console.WriteLine("", amountDeposited);
            this.AmountDeposited = amountDeposited;
        }
    }
}
