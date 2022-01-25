using BankAccount.Entities.Type;
using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount businessAccount = new BusinessAccount();
            Console.WriteLine("Hello World!" + businessAccount);
        }
    }
}
