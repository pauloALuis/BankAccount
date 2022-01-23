using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Entities
{
    class Account
    {

        public Person OwnerAccount { get; set; }
        public int Number { get; set; }
        public double Balance { get; set; }

        public Account(int number,  double balance, Person ownerAccount)
        {
            Number = number;
            Balance = balance;
            OwnerAccount = ownerAccount;
        }

        public override string ToString()
        {
            return base.ToString() + $"({Number} , {Balance}, {OwnerAccount})";
        }



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
