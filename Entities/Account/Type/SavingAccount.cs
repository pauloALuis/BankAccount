using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Entities.Account.Type
{
    class SavingAccount : Accounts
    {
        public SavingAccount()
        {
        }

        public double InterestRate { get; set; }

        public SavingAccount(double interestRate)
        {
            InterestRate = interestRate;
        }


        public SavingAccount(int number,  double balance, Person ownerAccount, double interestRate): base(number, balance, ownerAccount)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDrawWithTax(double amount)
        {
            Balance -= amount;
            base.WithDrawWithTax(amount);
        }

        /* public override void WithDrawWithTax(double amount)
         {
             Balance -= amount;
            // base.WithDraw1(amount);
         }*/

        public override string ToString()
        {
            return base.ToString() + $" (UpdateBalance: {Balance} , InterestRate: {InterestRate}  )";
        }
    }
}
