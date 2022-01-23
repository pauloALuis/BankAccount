using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Entities.Type
{
    class BusinessAcount : Account
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="holder"></param>
        /// <param name="balance"></param>
        /// <param name="ownerAccount"></param>
        public BusinessAcount(int number,  double balance, Person ownerAccount) : base(number,  balance, ownerAccount)
        {
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
        /// <returns></returns>
        public double LoanLimit(double amount)
        {
            return 0.0;
        }
    }
}
