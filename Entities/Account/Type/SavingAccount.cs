using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Entities.Account.Type
{
   sealed class SavingAccount : Accounts
    {
        public SavingAccount()
        {
        }

        public double InterestRate { get; set; }

        public SavingAccount(double interestRate)
        {
            InterestRate = interestRate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="balance"></param>
        /// <param name="ownerAccount"></param>
        /// <param name="interestRate"></param>
        public SavingAccount(int number,  double balance, Person ownerAccount, double interestRate): base(number, balance, ownerAccount)
        {
            InterestRate = interestRate;
        }

        /// <summary>
        /// 
        /// </summary>
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDrawWithTax(double amount)
        {

            base.WithDrawWithTax(amount);
            Balance -= 2.1;//surcharge the 2.1
        }

   
        /// <summary>
        ///  object String
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $" (UpdateBalance: {Balance} , InterestRate: {InterestRate}  )";
        }
    }
}
