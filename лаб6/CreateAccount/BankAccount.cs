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

        public void Populate(long number, decimal balance)
        {
            accNo = number;
            accBal = balance;
            accType = AccountType.Checking;
        }
        public static long NextNumber()
        {
            return nextAccNo++;
        }


        private long accNo;
        private decimal accBal;

        private AccountType accType;

        private static long nextAccNo;

        public long Number()
    {
        return accNo;
    }
    public decimal Balance()
    {
        return accBal;
    }
        public string Type()
        {
            return accType.ToString();
        }

    }
}
  
       