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
        //fields

        private string nameOnAccount;
        private int accountBalance;


        //properties


        //constructor
        public AccountBase(string holderName)
        {
            nameOnAccount = holderName;
        }

        //methods

        public virtual int Deposit(int money)
        {
            return accountBalance;
        }

        public virtual int Withdrawal(int money)
        {
            return accountBalance;
        }

        public virtual void ViewAccountBalance()
        {

        }

        public void ClientInfo()
        {
            Console.WriteLine("Name: " + nameOnAccount);
        }

    }
}

