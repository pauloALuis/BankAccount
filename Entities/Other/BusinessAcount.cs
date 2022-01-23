using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Entities.Type
{
    class BusinessAcount : Account
    {
        public BusinessAcount(int number, string holder, double balance, Person ownerAccount) : base(number, holder, balance, ownerAccount)
        {
        }

        public void LoadAccount(double amount)
        {

        }
        public double LoanLimit(double amount)
        {
            return 0.0;
        }
    }
}
