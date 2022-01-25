using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Entities
{
     class Accounts
    {

        public Person OwnerAccount { get; protected set; }
        protected int Number { get; set; }
        public double Balance { get;protected set; }


        public Accounts()
        {
        }

        public Accounts( int number, double balance, Person ownerAccount)
        {
            OwnerAccount = ownerAccount;
            Number = number;
            Balance = balance;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $"(Number: {Number} ,Balance: {Balance},OwnerAccount: {OwnerAccount})";
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
