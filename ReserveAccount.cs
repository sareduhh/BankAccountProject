using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class ReserveAccount : AccountBase
    {
        //Fields (2)

        private string reserveAccountName;
        private string reserveAccountSettings;

        //Properties (2)

        public string ReserveAccountName
        {
            get { return this.reserveAccountName; }
            set { this.reserveAccountName = value; }
        }

        public string ReserveAccountSettings
        {
            get { return this.reserveAccountSettings; }
            set { this.reserveAccountSettings = value; }
        }

        public int AmountDeposited { get; private set; }

        //Constructors (1)

        public ReserveAccount(string memberName) : base("Reserve", memberName)
        {
            //follows the default constructor
            //passes in the reserve type
        }

        //Methods
        //Withdrawing from the Reserve account.
        public void Withdrawn(int amountWithdrawn)
        {
            Console.WriteLine("");
        }
        //Depositing into the Reserve account.
        public void Deposit(int amountDeposited)
        {
            Console.WriteLine("", amountDeposited);
            this.AmountDeposited = amountDeposited;
           
        }
    }
}
