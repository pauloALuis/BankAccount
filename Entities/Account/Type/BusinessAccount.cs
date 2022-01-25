using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Entities.Type
{
    class BusinessAccount : Account
    {


        public double LoanLimit { get; set; }
    

        public BusinessAccount(int number,  double balance, Person ownerAccount, double loanLimit) 
            : base(number,  balance, ownerAccount)
        {
            LoanLimit = loanLimit;
        }

        public BusinessAccount() 
        {

            //Account()
            Number = 0001;
            Balance = 100;
            OwnerAccount = new Person("P-001", "firstName", "secondName", "20-05-1998", Other.Gender.Male);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void LoadAccount(double amount)
        {

        }


      /// <summary>
      /// 
      /// </summary>
      /// <param name="amount"></param>
        public void Loan(double amount)
        {
            if (amount >= 1 || amount <= LoanLimit)
            {
                 Balance += amount;
                 Console.WriteLine("authorized Loan\n Amount: "
                            + amount + "€ - Current Balace: " 
                            + Balance + "€");
                return;
            }

            Console.WriteLine("Unauthorized Loan");

        }
    }
}
