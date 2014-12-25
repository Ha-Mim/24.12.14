using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationApp
{
    class Account
    {
        private string accountNo;
        private string name;

        private double balance;

      

        public string AccountNo
        {
            get { return accountNo; }
            set { accountNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public double Deposit(double amount)
        {
            return balance = Balance + amount;
            
        }

        public double Withdraw(double amount)
        {
           return balance = Balance - amount;
            
        }
    }
}
