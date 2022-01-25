using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Entities
{
    class Account
    {

        public Person OwnerAccount { get; protected set; }
        protected int Number { get; set; }
        public double Balance { get;protected set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="balance"></param>
        /// <param name="ownerAccount"></param>
        public Account(int number,  double balance, Person ownerAccount)
        {
            Number = number;
            Balance = balance;
            OwnerAccount = ownerAccount;
        }

        public Account()
        {
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $"({Number} , {Balance}, {OwnerAccount})";
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void WithDraw(double amount)
    {
        if (amount > Balance || amount <= 0)
        {
             Console.WriteLine("Unauthorized withdrawal");
               return;

         }
            Balance -= amount;
            Console.WriteLine("Authorized Withdrawal\n Amount: " 
                + amount + "€ - Current Balace: " + Balance + "€");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void deposit(double amount)
        {
            if (amount <= 0)
            {
               Console.WriteLine("Unauthorized Deposit");
                return;
            }
            Balance += amount;
            Console.WriteLine("authorized Deposot\n Amount: "
                + amount + "€ - Current Balace: " + Balance + "€");
            
        }
    }
}
