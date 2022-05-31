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
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
}
