using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    struct Account
    {

        // Define a struct Account with private attributes AccountId, AccountHolder, and Balance. 

        private int accountId;
        private string accountHolder;
        private double balance;


        // Provide public properties for accessing these attributes
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value > 0 ? value : 100; }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value > 4000 ? value : 4000; }
        }

        public Account(int _Id, string _Holder, double _Balance)
        {
            accountId = _Id;
            accountHolder = _Holder;
            balance = _Balance;
        }

        public override string ToString()
        {
            return ($"AccountId: {accountId}, Holder: {accountHolder}, Balance: {balance}");
        }

    }
}
