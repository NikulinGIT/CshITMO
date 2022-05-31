using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAccount
{
    enum AccountType
    {
        Checking,
        Deposit
    }

    internal class BankAccount
    {
        // public void Populate(long number, decimal balance);
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        public long Number()
            {
                return accNo;
            }
            public decimal Balance()
            {
                return accBal;
            }
            public AccountType Type()
            {
                return accType;
            }

  
        
    }
}
